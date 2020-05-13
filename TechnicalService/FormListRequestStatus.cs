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
    public partial class FormListRequestStatus : Form
    {
        public FormListRequestStatus()
        {
            InitializeComponent();
            FillListStatuses();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRequestStatusCreate().ShowDialog();
            FillListStatuses();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            RequestStatus requestStatus =
                (RequestStatus)listBox1.SelectedItem;
            var requests = RequestDB.GetInstance().
                GetRequests()
                .GetRequestsByStatus(requestStatus);
            if (requests.requests.Count == 0)
            {
                RequestStatusDB.GetInstance().
                      RemoveRequestStatus(requestStatus);
                FillListStatuses();
            }
            else
                MessageBox.Show("Невозможно удалить статус, " +
                    "Существуют заявки с таким статусом");
        }
        void FillListStatuses()
        {
            listBox1.DataSource =
                RequestStatusDB.GetInstance().
                GetRequestStatuses();
            listBox1.DisplayMember = "Name";
        }
    }
}
