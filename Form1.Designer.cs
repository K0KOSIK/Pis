namespace Pis
{
    partial class Form1
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bt_exit = new Button();
            panel1 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(372, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(359, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Location = new Point(359, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(359, 104);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(359, 173);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button bt_exit;
        private Panel panel1;
        private Button bt_min;
        private Button bt_max;
    }
}
