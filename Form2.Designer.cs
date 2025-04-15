namespace Pis.Models
{
    partial class Form2
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
            bt_exit = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView7 = new DataGridView();
            dataGridView6 = new DataGridView();
            dataGridView5 = new DataGridView();
            dataGridView4 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 375);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
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
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.IndianRed;
            bt_exit.Dock = DockStyle.Right;
            bt_exit.FlatAppearance.BorderSize = 0;
            bt_exit.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            bt_exit.FlatAppearance.MouseOverBackColor = Color.IndianRed;
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
            button7.Location = new Point(495, 0);
            button7.Name = "button7";
            button7.Size = new Size(85, 25);
            button7.TabIndex = 6;
            button7.Text = "Status";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(410, 0);
            button6.Name = "button6";
            button6.Size = new Size(85, 25);
            button6.TabIndex = 5;
            button6.Text = "Severity";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(325, 0);
            button5.Name = "button5";
            button5.Size = new Size(85, 25);
            button5.TabIndex = 4;
            button5.Text = "PLC_Devices";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(240, 0);
            button4.Name = "button4";
            button4.Size = new Size(85, 25);
            button4.TabIndex = 3;
            button4.Text = "Performance Reports";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 0);
            button3.Name = "button3";
            button3.Size = new Size(85, 25);
            button3.TabIndex = 2;
            button3.Text = "MonitoringData";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(80, 0);
            button2.Name = "button2";
            button2.Size = new Size(85, 25);
            button2.TabIndex = 1;
            button2.Text = "Device_Type";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(85, 25);
            button1.TabIndex = 0;
            button1.Text = "AlertLogs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView7);
            panel2.Controls.Add(dataGridView6);
            panel2.Controls.Add(dataGridView5);
            panel2.Controls.Add(dataGridView4);
            panel2.Controls.Add(dataGridView3);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 375);
            panel2.TabIndex = 2;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Dock = DockStyle.Fill;
            dataGridView7.Location = new Point(0, 0);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.Size = new Size(800, 375);
            dataGridView7.TabIndex = 6;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Dock = DockStyle.Fill;
            dataGridView6.Location = new Point(0, 0);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(800, 375);
            dataGridView6.TabIndex = 5;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Dock = DockStyle.Fill;
            dataGridView5.Location = new Point(0, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(800, 375);
            dataGridView5.TabIndex = 4;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(800, 375);
            dataGridView4.TabIndex = 3;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(800, 375);
            dataGridView3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(800, 375);
            dataGridView2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 50);
            panel3.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button7;
        private Button button6;
        private Button button5;
        private DataGridView dataGridView7;
        private DataGridView dataGridView6;
        private DataGridView dataGridView5;
        private DataGridView dataGridView4;
        private Button bt_exit;
        private Panel panel3;
    }
}