using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalService
{
    public partial class FormRequestEdit : Form
    {
        Request request;
        public FormRequestEdit()
        {
            InitializeComponent();
            FillFilters();
        }

        public FormRequestEdit(Request request)
        {
            InitializeComponent();
            FillFilters();
            this.request = request;
            textBox1.Text = request.Name;
            comboBox1.SelectedItem = request.Priority;
            comboBox2.SelectedItem = RequestStatusDB.
                GetInstance().GetRequestStatusByID(
                request.StatusID);
            comboBox3.SelectedItem = WorkerDB.
                GetInstance().GetWorkerByID(
                request.WorkerID);
            dateTimePicker1.Value = request.DateCreate;
           
        }
        void SaveRequestChanges()
        {
            request.Priority = (RequestPriority)
                comboBox1.SelectedItem;
            request.StatusID = ((RequestStatus)
                comboBox2.SelectedItem).ID;
            request.WorkerID = ((Worker)
                comboBox3.SelectedItem).ID;
        }
        void FillFilters()
        {
            comboBox2.DataSource = RequestStatusDB.
                    GetInstance().GetRequestStatuses();
            comboBox2.DisplayMember = "Name";
            comboBox1.DataSource = typeof(RequestPriority).
                GetEnumValues();
            comboBox3.DataSource = WorkerDB.GetInstance().
                GetWorkers();
            comboBox3.DisplayMember = "LastName";
        }

        private void butttonSaveRequest_Click(object sender, EventArgs e)
        {
            if (request == null)
                request = RequestDB.GetInstance().
                    CreateRequest(textBox1.Text,
                        dateTimePicker1.Value);
            SaveRequestChanges();
            Close();
        }

       
    }
}
