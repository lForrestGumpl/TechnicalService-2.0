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
    public partial class FormWorkerEdit : Form
    {
        Worker worker;
        public FormWorkerEdit()
        {
            InitializeComponent();
            comboBox1.DataSource = typeof(WorkerStatus).GetEnumValues();
        }
            public FormWorkerEdit(Worker worker)
            
            {
                InitializeComponent();
                comboBox1.DataSource = typeof(WorkerStatus).GetEnumValues();
                    
                this.worker = worker;
                textBox1.Text = worker.FirstName;
                textBox2.Text = worker.LastName;
                comboBox1.SelectedItem = worker.Status;
            }

           

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (worker == null)
                worker = WorkerDB.GetInstance().
                    CreateWorker();
            worker.FirstName = textBox1.Text;
            worker.LastName = textBox2.Text;
            worker.Status = (WorkerStatus)comboBox1.SelectedItem;
                Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
