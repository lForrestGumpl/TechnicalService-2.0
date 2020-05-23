using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TechnicalService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillFilters();
        }

        void FillFilters()
        {
            Status.DataSource = RequestStatusDB.GetInstance().GetRequestStatuses();                   
            Status.DisplayMember = "Name";
            Priority.DataSource = typeof(RequestPriority).GetEnumValues();               
            worker.DataSource = WorkerDB.GetInstance().GetWorkers();               
            worker.DisplayMember = "LastName";
            client.DataSource = ClientDB.GetInstance().GetClients();
            client.DisplayMember = "LastName";
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormListWorkers().ShowDialog();
            FillFilters();
        }

        private void статусыЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormListRequestStatus().ShowDialog();
            FillFilters();
        }

        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            ArrayRequests result = RequestDB.GetInstance().GetRequests();              
            if (checkBox1.Checked)
                result = result.GetRequestsCreateBetweenDate(dateTimePicker1.Value);
           else if (Status.SelectedIndex != -1)
                result = result.GetRequestsByStatus((RequestStatus)Status.SelectedItem);                  
          else  if (Priority.SelectedIndex != -1)
                result = result.GetRequestsByPriority( (RequestPriority)Priority.SelectedItem);                   
          else  if (worker.SelectedIndex != -1)
                result = result.GetRequestsByWorker((Worker)worker.SelectedItem);
          else  if (client.SelectedIndex != -1)
                result = result.GetRequestsByClient((Client)client.SelectedItem);
            
            ShowRequests(result.requests);
        }

        private void ShowRequests(List<Request> requests)
        {
            listView1.Items.Clear();
            RequestStatusDB statusDB = RequestStatusDB.GetInstance();
            WorkerDB workerDB = WorkerDB.GetInstance();
            ClientDB clientDB = ClientDB.GetInstance();
            foreach (var request in requests)
            {
                ListViewItem row =
                    new ListViewItem(request.Name);
                row.SubItems.Add(request.DateCreate.ToString());
                if (request.Closed)
                row.SubItems.Add(" ");
                row.SubItems.Add(statusDB.GetRequestStatusByID(request.StatusID).Name);                                
                row.SubItems.Add(request.Priority.ToString());
                row.SubItems.Add(workerDB. GetWorkerByID(request.WorkerID).LastName);
                row.SubItems.Add(clientDB.GetClientByID(request.ClientID).LastName);
                row.Tag = request;
                listView1.Items.Add(row);
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRequestEdit().Show();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBox1.Checked;
        }

       

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            Request edit = (Request)listView1.SelectedItems[0].Tag;
            new FormRequestEdit(edit).ShowDialog();
            ApplyFilter_Click(this, null);
        }

        private void AddRequest_Click(object sender, EventArgs e)
        {
            new FormRequestEdit().Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {

        }

        private void клиентскаяБазаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormListClient().ShowDialog();
            FillFilters();
        }

        private void Priority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResetTheFilter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is CheckBox)
                    ((CheckBox)Controls[i]).Checked = false;
                else if (Controls[i] is ComboBox)
                    ((ComboBox)Controls[i]).SelectedIndex = -1;
                else if (Controls[i] is DateTimePicker)
                    ((DateTimePicker)Controls[i]).Value = DateTime.Now;
                       
            }
        }
    }
}
