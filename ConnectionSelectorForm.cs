using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis
{
    public partial class ConnectionSelectorForm : Form
    {
        public string SelectedConnection { get; private set; }

        public ConnectionSelectorForm()
        {
            InitializeComponent();
            var config = AppConfig.Load();

            foreach (var connection in config.ConnectionStrings.Keys)
            {
                cmbConnections.Items.Add(connection);
            }

            cmbConnections.SelectedItem = config.DefaultConnection;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SelectedConnection = cmbConnections.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
