namespace TechnicalService
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентскаяБазаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Priority = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.ResetTheFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.worker = new System.Windows.Forms.ComboBox();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.AddRequest = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remove = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(194, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(554, 215);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Заголовок";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата создания";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Статус";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Приоритет";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Исполнитель";
            this.columnHeader6.Width = 110;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.статусыЗаявокToolStripMenuItem,
            this.клиентскаяБазаToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // статусыЗаявокToolStripMenuItem
            // 
            this.статусыЗаявокToolStripMenuItem.Name = "статусыЗаявокToolStripMenuItem";
            this.статусыЗаявокToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.статусыЗаявокToolStripMenuItem.Text = "Статусы заявок";
            this.статусыЗаявокToolStripMenuItem.Click += new System.EventHandler(this.статусыЗаявокToolStripMenuItem_Click);
            // 
            // клиентскаяБазаToolStripMenuItem
            // 
            this.клиентскаяБазаToolStripMenuItem.Name = "клиентскаяБазаToolStripMenuItem";
            this.клиентскаяБазаToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.клиентскаяБазаToolStripMenuItem.Text = "Клиентская База";
            this.клиентскаяБазаToolStripMenuItem.Click += new System.EventHandler(this.клиентскаяБазаToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(3, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Фильтр по дате создания";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Приоритет";
            // 
            // Priority
            // 
            this.Priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Priority.FormattingEnabled = true;
            this.Priority.Location = new System.Drawing.Point(3, 62);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(158, 21);
            this.Priority.TabIndex = 34;
            this.Priority.SelectedIndexChanged += new System.EventHandler(this.Priority_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Статус";
            // 
            // Status
            // 
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(3, 22);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(158, 21);
            this.Status.TabIndex = 32;
            // 
            // ResetTheFilter
            // 
            this.ResetTheFilter.Location = new System.Drawing.Point(3, 224);
            this.ResetTheFilter.Name = "ResetTheFilter";
            this.ResetTheFilter.Size = new System.Drawing.Size(158, 23);
            this.ResetTheFilter.TabIndex = 39;
            this.ResetTheFilter.Text = "Сбросить фильтр";
            this.ResetTheFilter.UseVisualStyleBackColor = true;
            this.ResetTheFilter.Click += new System.EventHandler(this.ResetTheFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Исполнитель";
            // 
            // worker
            // 
            this.worker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.worker.FormattingEnabled = true;
            this.worker.Location = new System.Drawing.Point(3, 102);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(158, 21);
            this.worker.TabIndex = 37;
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.Location = new System.Drawing.Point(3, 195);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(158, 23);
            this.ApplyFilter.TabIndex = 36;
            this.ApplyFilter.Text = "Применить фильтр";
            this.ApplyFilter.UseVisualStyleBackColor = true;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
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
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(3, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(115, 23);
            this.Edit.TabIndex = 41;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.Remove);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.AddRequest);
            this.panel1.Location = new System.Drawing.Point(194, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 32);
            this.panel1.TabIndex = 42;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(258, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(128, 23);
            this.Remove.TabIndex = 42;
            this.Remove.Text = "Удалить";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.Status);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.ResetTheFilter);
            this.panel2.Controls.Add(this.Priority);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.worker);
            this.panel2.Controls.Add(this.ApplyFilter);
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 253);
            this.panel2.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Список заявок";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыЗаявокToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Priority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Button ResetTheFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox worker;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.Button AddRequest;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem клиентскаяБазаToolStripMenuItem;
    }
}

