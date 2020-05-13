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
    public partial class FormListWorkers : Form
    {
        public FormListWorkers()
        {
            InitializeComponent();
            ShowListWorkers();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormWorkerEdit().ShowDialog();
            ShowListWorkers();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            var worker = (Worker)listView1.
                SelectedItems[0].Tag;
            new FormWorkerEdit(worker).ShowDialog();
            ShowListWorkers();

        }
        void ShowListWorkers()
        {
            listView1.Items.Clear();
            var workers = WorkerDB.GetInstance().
                GetWorkers();
            foreach (var worker in workers)
            {
                ListViewItem row = new ListViewItem(
                    worker.FirstName);
                row.SubItems.Add(worker.LastName);
                row.SubItems.Add(worker.Status.ToString());
                row.Tag = worker;
                listView1.Items.Add(row);
            }
        }
    }
}
