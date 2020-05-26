namespace TechnicalService
{
    partial class FormListWorkers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveWorker = new System.Windows.Forms.Button();
            this.EditWorker = new System.Windows.Forms.Button();
            this.AddWorker = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(564, 231);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Статус";
            this.columnHeader3.Width = 187;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.RemoveWorker);
            this.panel1.Controls.Add(this.EditWorker);
            this.panel1.Controls.Add(this.AddWorker);
            this.panel1.Location = new System.Drawing.Point(185, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 32);
            this.panel1.TabIndex = 43;
            // 
            // RemoveWorker
            // 
            this.RemoveWorker.Location = new System.Drawing.Point(258, 3);
            this.RemoveWorker.Name = "RemoveWorker";
            this.RemoveWorker.Size = new System.Drawing.Size(128, 23);
            this.RemoveWorker.TabIndex = 42;
            this.RemoveWorker.Text = "Удалить";
            this.RemoveWorker.UseVisualStyleBackColor = true;
            this.RemoveWorker.Click += new System.EventHandler(this.RemoveWorker_Click);
            // 
            // EditWorker
            // 
            this.EditWorker.Location = new System.Drawing.Point(3, 3);
            this.EditWorker.Name = "EditWorker";
            this.EditWorker.Size = new System.Drawing.Size(115, 23);
            this.EditWorker.TabIndex = 41;
            this.EditWorker.Text = "Редактировать";
            this.EditWorker.UseVisualStyleBackColor = true;
            this.EditWorker.Click += new System.EventHandler(this.EditWorker_Click);
            // 
            // AddWorker
            // 
            this.AddWorker.Location = new System.Drawing.Point(124, 3);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(128, 23);
            this.AddWorker.TabIndex = 40;
            this.AddWorker.Text = "Добавить";
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // FormListWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormListWorkers";
            this.Text = "Список сотрудников";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveWorker;
        private System.Windows.Forms.Button EditWorker;
        private System.Windows.Forms.Button AddWorker;
    }
}