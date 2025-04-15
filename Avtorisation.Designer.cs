namespace Pis
{
    partial class Avtorisation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Avtorises = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bt_exit = new Button();
            panel1 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            SMS = new Label();
            logs = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Avtorises
            // 
            Avtorises.Anchor = AnchorStyles.Top;
            Avtorises.BackColor = SystemColors.GradientActiveCaption;
            Avtorises.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            Avtorises.FlatAppearance.BorderSize = 0;
            Avtorises.FlatAppearance.MouseDownBackColor = SystemColors.GradientInactiveCaption;
            Avtorises.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
            Avtorises.FlatStyle = FlatStyle.Flat;
            Avtorises.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Avtorises.ForeColor = SystemColors.ButtonHighlight;
            Avtorises.Location = new Point(411, 278);
            Avtorises.Name = "Avtorises";
            Avtorises.Size = new Size(93, 47);
            Avtorises.TabIndex = 0;
            Avtorises.Text = "ВОЙТИ";
            Avtorises.UseVisualStyleBackColor = false;
            Avtorises.Click += button1_Click;
            Avtorises.MouseEnter += Avtorises_MouseEnter;
            Avtorises.MouseLeave += Avtorises_MouseLeave;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(201, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Location = new Point(201, 331);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(201, 226);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(201, 304);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
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
            bt_exit.TabIndex = 8;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bt_min);
            panel1.Controls.Add(bt_max);
            panel1.Controls.Add(bt_exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 9;
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
            bt_min.TabIndex = 11;
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
            bt_max.TabIndex = 10;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // SMS
            // 
            SMS.AutoSize = true;
            SMS.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            SMS.ForeColor = SystemColors.ButtonHighlight;
            SMS.Location = new Point(323, 28);
            SMS.Name = "SMS";
            SMS.Size = new Size(157, 86);
            SMS.TabIndex = 10;
            SMS.Text = "SMS";
            // 
            // logs
            // 
            logs.AutoSize = true;
            logs.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logs.ForeColor = SystemColors.ButtonHighlight;
            logs.Location = new Point(249, 114);
            logs.Name = "logs";
            logs.Size = new Size(302, 50);
            logs.TabIndex = 11;
            logs.Text = "АВТОРИЗАЦИЯ";
            // 
            // Avtorisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(logs);
            Controls.Add(SMS);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Avtorises);
            Name = "Avtorisation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Avtorises;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button bt_exit;
        private Panel panel1;
        private Button bt_min;
        private Button bt_max;
        private Label SMS;
        private Label logs;
    }
}
