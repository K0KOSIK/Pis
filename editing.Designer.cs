namespace Pis
{
    partial class Editing
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
            input = new TextBox();
            input2 = new TextBox();
            input3 = new TextBox();
            input6 = new TextBox();
            input5 = new TextBox();
            input7 = new TextBox();
            table1 = new Label();
            table2 = new Label();
            table3 = new Label();
            table4 = new Label();
            table5 = new Label();
            table6 = new Label();
            table7 = new Label();
            cancellation = new Button();
            save = new Button();
            input4 = new DomainUpDown();
            input8 = new TextBox();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(50, 45);
            input.Name = "input";
            input.Size = new Size(100, 23);
            input.TabIndex = 0;
            // 
            // input2
            // 
            input2.Location = new Point(50, 116);
            input2.Name = "input2";
            input2.Size = new Size(100, 23);
            input2.TabIndex = 1;
            // 
            // input3
            // 
            input3.Location = new Point(50, 189);
            input3.Name = "input3";
            input3.Size = new Size(100, 23);
            input3.TabIndex = 2;
            // 
            // input6
            // 
            input6.ForeColor = SystemColors.WindowText;
            input6.Location = new Point(244, 189);
            input6.Name = "input6";
            input6.Size = new Size(100, 23);
            input6.TabIndex = 3;
            // 
            // input5
            // 
            input5.ForeColor = SystemColors.WindowText;
            input5.Location = new Point(244, 116);
            input5.Name = "input5";
            input5.Size = new Size(100, 23);
            input5.TabIndex = 5;
            // 
            // input7
            // 
            input7.ForeColor = SystemColors.WindowText;
            input7.Location = new Point(422, 45);
            input7.Name = "input7";
            input7.Size = new Size(100, 23);
            input7.TabIndex = 6;
            // 
            // table1
            // 
            table1.AutoSize = true;
            table1.ForeColor = SystemColors.ButtonHighlight;
            table1.Location = new Point(50, 27);
            table1.Name = "table1";
            table1.Size = new Size(17, 15);
            table1.TabIndex = 7;
            table1.Text = "Id";
            // 
            // table2
            // 
            table2.AutoSize = true;
            table2.ForeColor = SystemColors.ButtonHighlight;
            table2.Location = new Point(50, 98);
            table2.Name = "table2";
            table2.Size = new Size(35, 15);
            table2.TabIndex = 8;
            table2.Text = "input";
            // 
            // table3
            // 
            table3.AutoSize = true;
            table3.ForeColor = SystemColors.ButtonHighlight;
            table3.Location = new Point(50, 171);
            table3.Name = "table3";
            table3.Size = new Size(35, 15);
            table3.TabIndex = 9;
            table3.Text = "input";
            // 
            // table4
            // 
            table4.AutoSize = true;
            table4.ForeColor = SystemColors.ButtonHighlight;
            table4.Location = new Point(244, 27);
            table4.Name = "table4";
            table4.Size = new Size(35, 15);
            table4.TabIndex = 10;
            table4.Text = "input";
            // 
            // table5
            // 
            table5.AutoSize = true;
            table5.ForeColor = SystemColors.ButtonHighlight;
            table5.Location = new Point(244, 98);
            table5.Name = "table5";
            table5.Size = new Size(35, 15);
            table5.TabIndex = 11;
            table5.Text = "input";
            // 
            // table6
            // 
            table6.AutoSize = true;
            table6.ForeColor = SystemColors.ButtonHighlight;
            table6.Location = new Point(244, 171);
            table6.Name = "table6";
            table6.Size = new Size(35, 15);
            table6.TabIndex = 12;
            table6.Text = "input";
            // 
            // table7
            // 
            table7.AutoSize = true;
            table7.ForeColor = SystemColors.ButtonHighlight;
            table7.Location = new Point(422, 27);
            table7.Name = "table7";
            table7.Size = new Size(35, 15);
            table7.TabIndex = 13;
            table7.Text = "input";
            // 
            // cancellation
            // 
            cancellation.BackColor = SystemColors.ActiveCaption;
            cancellation.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            cancellation.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption;
            cancellation.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            cancellation.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            cancellation.FlatStyle = FlatStyle.Flat;
            cancellation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cancellation.ForeColor = SystemColors.ButtonHighlight;
            cancellation.Location = new Point(453, 289);
            cancellation.Name = "cancellation";
            cancellation.Size = new Size(112, 41);
            cancellation.TabIndex = 14;
            cancellation.Text = "Отмена";
            cancellation.UseVisualStyleBackColor = false;
            cancellation.Click += cancellation_Click;
            // 
            // save
            // 
            save.BackColor = SystemColors.ActiveCaption;
            save.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            save.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption;
            save.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            save.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            save.ForeColor = SystemColors.ButtonHighlight;
            save.Location = new Point(609, 289);
            save.Name = "save";
            save.Size = new Size(129, 39);
            save.TabIndex = 15;
            save.Text = "Сохранить ";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // input4
            // 
            input4.Items.Add("Высокий");
            input4.Items.Add("Средний");
            input4.Items.Add("Низкий");
            input4.Location = new Point(244, 45);
            input4.Name = "input4";
            input4.Size = new Size(120, 23);
            input4.TabIndex = 16;
            // 
            // input8
            // 
            input8.Location = new Point(244, 45);
            input8.Name = "input8";
            input8.Size = new Size(100, 23);
            input8.TabIndex = 17;
            // 
            // Editing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(input8);
            Controls.Add(input4);
            Controls.Add(save);
            Controls.Add(cancellation);
            Controls.Add(table7);
            Controls.Add(table6);
            Controls.Add(table5);
            Controls.Add(table4);
            Controls.Add(table3);
            Controls.Add(table2);
            Controls.Add(table1);
            Controls.Add(input7);
            Controls.Add(input5);
            Controls.Add(input6);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Editing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private TextBox input2;
        private TextBox input3;
        private TextBox input6;
        
        private TextBox input5;
        private TextBox input7;
        private Label table1;
        private Label table2;
        private Label table3;
        private Label table4;
        private Label table5;
        private Label table6;
        private Label table7;
        private Button cancellation;
        private Button save;
        private DomainUpDown input4;
        private TextBox input8;
    }
}