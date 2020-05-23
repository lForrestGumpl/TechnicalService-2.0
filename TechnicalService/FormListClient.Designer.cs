namespace TechnicalService
{
    partial class FormListClient
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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddRequest = new System.Windows.Forms.Button();
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
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(540, 201);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 146;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Статус";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Телефон";
            this.columnHeader4.Width = 115;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.Remove);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.AddRequest);
            this.panel1.Location = new System.Drawing.Point(161, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 32);
            this.panel1.TabIndex = 43;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(258, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(128, 23);
            this.Remove.TabIndex = 42;
            this.Remove.Text = "Удалить";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(3, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(115, 23);
            this.Edit.TabIndex = 41;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // AddRequest
            // 
            this.AddRequest.Location = new System.Drawing.Point(124, 3);
            this.AddRequest.Name = "AddRequest";
            this.AddRequest.Size = new System.Drawing.Size(128, 23);
            this.AddRequest.TabIndex = 40;
            this.AddRequest.Text = "Добавить";
            this.AddRequest.UseVisualStyleBackColor = true;
            this.AddRequest.Click += new System.EventHandler(this.AddRequest_Click);
            // 
            // FormListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormListClient";
            this.Text = "Клиентская База";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddRequest;
    }
}