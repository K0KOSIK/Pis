namespace Pis
{
    partial class ConnectionSelectorForm
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
            cmbConnections = new ComboBox();
            logs = new Label();
            btnConnect = new Button();
            SMS = new Label();
            SuspendLayout();
            // 
            // cmbConnections
            // 
            cmbConnections.BackColor = SystemColors.InactiveCaption;
            cmbConnections.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbConnections.ForeColor = SystemColors.ButtonHighlight;
            cmbConnections.FormattingEnabled = true;
            cmbConnections.Location = new Point(320, 215);
            cmbConnections.Name = "cmbConnections";
            cmbConnections.Size = new Size(145, 33);
            cmbConnections.TabIndex = 0;
            // 
            // logs
            // 
            logs.Anchor = AnchorStyles.Top;
            logs.AutoSize = true;
            logs.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logs.ForeColor = SystemColors.ButtonHighlight;
            logs.Location = new Point(255, 95);
            logs.Name = "logs";
            logs.Size = new Size(302, 50);
            logs.TabIndex = 12;
            logs.Text = "АВТОРИЗАЦИЯ";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = SystemColors.ActiveCaption;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnConnect.ForeColor = SystemColors.ButtonHighlight;
            btnConnect.Location = new Point(320, 300);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(145, 34);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "ВОЙТИ";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // SMS
            // 
            SMS.Anchor = AnchorStyles.Top;
            SMS.AutoSize = true;
            SMS.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            SMS.ForeColor = SystemColors.ButtonHighlight;
            SMS.Location = new Point(320, 9);
            SMS.Name = "SMS";
            SMS.Size = new Size(157, 86);
            SMS.TabIndex = 11;
            SMS.Text = "SMS";
            // 
            // ConnectionSelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnect);
            Controls.Add(SMS);
            Controls.Add(cmbConnections);
            Controls.Add(logs);
            Name = "ConnectionSelectorForm";
            Text = "ConnectionSelectorForm";
            Load += ConnectionSelectorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbConnections;
        private Label logs;
        private Button btnConnect;
        private Label SMS;
    }
}