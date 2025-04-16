using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis.Models
{
    public partial class tester : Form
    {
        private Avtorisation _form1;

        public tester(Avtorisation form1)
        {
            InitializeComponent();
            _form1 = form1;
            this.FormClosed += tester_FormClosed;
        }

        private void tester_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }
        private void tester_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.MonitoringData.ToList();
            dataGridView1.Columns[5].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.PerformanceReports.ToList();
            dataGridView1.Columns[7].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.PlcDevices.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
