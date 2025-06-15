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
            btnConnect = new Button();
            SuspendLayout();
            // 
            // cmbConnections
            // 
            cmbConnections.FormattingEnabled = true;
            cmbConnections.Location = new Point(330, 125);
            cmbConnections.Name = "cmbConnections";
            cmbConnections.Size = new Size(121, 23);
            cmbConnections.TabIndex = 0;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(362, 263);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "button1";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // ConnectionSelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnect);
            Controls.Add(cmbConnections);
            Name = "ConnectionSelectorForm";
            Text = "ConnectionSelectorForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbConnections;
        private Button btnConnect;
    }
}