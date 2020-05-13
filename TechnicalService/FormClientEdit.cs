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
    public partial class FormClientEdit : Form

    {
        Client client;
        public FormClientEdit()
        {
            InitializeComponent();
            comboBox1.DataSource = typeof(ClientStatus).GetEnumValues();
        }

        private void FormClientEdit_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (client == null)
               client = ClientDB.GetInstance().
                    CreateClient();
            client.FirstName = textBox3.Text;
            client.LastName = textBox2.Text;
            client.Status = (ClientStatus)comboBox1.SelectedItem;
            Close();
        }
    }
}
