﻿using System;
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
    public partial class FormListClient : Form
    {
        public FormListClient()
        {
            InitializeComponent();
            ShowListClient();
        }

        private void AddRequest_Click(object sender, EventArgs e)
        {
            new FormClientEdit().Show();
        }
        void ShowListClient()
        {
            listView1.Items.Clear();
            var clients = ClientDB.GetInstance().
                GetClients();
            foreach (var client in clients)
            {
                ListViewItem row = new ListViewItem(
                    client.FirstName);
                row.SubItems.Add(client.LastName);
                row.SubItems.Add(client.Status.ToString());
                row.SubItems.Add(client.Phone.ToString());
                row.Tag = client;
                listView1.Items.Add(row);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {         
            if (listView1.SelectedIndices.Count == 0)
                return;
           Client client = (Client)listView1.SelectedItems[0].Tag;
            ClientDB.GetInstance().RemoveClient(client);
            ShowListClient();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            var client = (Client)listView1. SelectedItems[0].Tag;
            new FormClientEdit(client).ShowDialog();
            ShowListClient();
        }
    }
}
