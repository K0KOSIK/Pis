namespace Pis.Models
{
    partial class Admin
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            bt_delete = new Button();
            bt_edit = new Button();
            bt_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 372);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(bt_min);
            panel1.Controls.Add(bt_max);
            panel1.Controls.Add(bt_exit);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // bt_min
            // 
            bt_min.BackColor = Color.DeepSkyBlue;
            bt_min.Dock = DockStyle.Right;
            bt_min.FlatAppearance.BorderSize = 0;
            bt_min.FlatAppearance.MouseDownBackColor = Color.Blue;
            bt_min.FlatAppearance.MouseOverBackColor = Color.Blue;
            bt_min.FlatStyle = FlatStyle.Flat;
            bt_min.Location = new Point(725, 0);
            bt_min.Name = "bt_min";
            bt_min.Size = new Size(25, 25);
            bt_min.TabIndex = 9;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_min_Click;
            // 
            // bt_max
            // 
            bt_max.BackColor = Color.LimeGreen;
            bt_max.Dock = DockStyle.Right;
            bt_max.FlatAppearance.BorderSize = 0;
            bt_max.FlatAppearance.MouseDownBackColor = Color.Green;
            bt_max.FlatAppearance.MouseOverBackColor = Color.Green;
            bt_max.FlatStyle = FlatStyle.Flat;
            bt_max.Location = new Point(750, 0);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(25, 25);
            bt_max.TabIndex = 8;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.IndianRed;
            bt_exit.Dock = DockStyle.Right;
            bt_exit.FlatAppearance.BorderSize = 0;
            bt_exit.FlatAppearance.MouseDownBackColor = Color.Red;
            bt_exit.FlatAppearance.MouseOverBackColor = Color.Red;
            bt_exit.FlatStyle = FlatStyle.Flat;
            bt_exit.Location = new Point(775, 0);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(25, 25);
            bt_exit.TabIndex = 7;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(128, 128, 255);
            button7.Location = new Point(495, 0);
            button7.Name = "button7";
            button7.Size = new Size(85, 25);
            button7.TabIndex = 6;
            button7.Text = "Status";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 128, 255);
            button6.Location = new Point(410, 0);
            button6.Name = "button6";
            button6.Size = new Size(85, 25);
            button6.TabIndex = 5;
            button6.Text = "Severity";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 128, 255);
            button5.Location = new Point(325, 0);
            button5.Name = "button5";
            button5.Size = new Size(85, 25);
            button5.TabIndex = 4;
            button5.Text = "PLC_Devices";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.Location = new Point(240, 0);
            button4.Name = "button4";
            button4.Size = new Size(85, 25);
            button4.TabIndex = 3;
            button4.Text = "Performance Reports";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.Location = new Point(160, 0);
            button3.Name = "button3";
            button3.Size = new Size(85, 25);
            button3.TabIndex = 2;
            button3.Text = "MonitoringData";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.Location = new Point(80, 0);
            button2.Name = "button2";
            button2.Size = new Size(85, 25);
            button2.TabIndex = 1;
            button2.Text = "Device_Type";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(85, 25);
            button1.TabIndex = 0;
            button1.Text = "AlertLogs";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 372);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(bt_delete);
            panel3.Controls.Add(bt_edit);
            panel3.Controls.Add(bt_add);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 53);
            panel3.TabIndex = 7;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = SystemColors.Highlight;
            bt_delete.Location = new Point(165, 6);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 40);
            bt_delete.TabIndex = 2;
            bt_delete.Text = "Удалить";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_edit
            // 
            bt_edit.BackColor = SystemColors.Highlight;
            bt_edit.Location = new Point(84, 6);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(75, 40);
            bt_edit.TabIndex = 1;
            bt_edit.Text = "Изменить";
            bt_edit.UseVisualStyleBackColor = false;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_add
            // 
            bt_add.BackColor = SystemColors.Highlight;
            bt_add.Location = new Point(3, 6);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 40);
            bt_add.TabIndex = 0;
            bt_add.Text = "Добавить";
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Admin_FormClosed;
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel2;
        private Button button4;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button bt_exit;
        private Panel panel3;
        private Button bt_add;
        private Button bt_max;
        private Button bt_delete;
        private Button bt_edit;
        private Button bt_min;
    }
}