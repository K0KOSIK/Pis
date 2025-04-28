using Microsoft.EntityFrameworkCore;
using Pis.Models;
using System.Runtime.InteropServices;

namespace Pis
{
    public partial class Avtorisation : Form
    {
        public Avtorisation()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ispr2525PiskunovDvKursovayaContext context = new();
                User? user = context.Users
                    .Where(user => user.Username == textBox1.Text && user.Password == textBox2.Text)
                    .Include(user => user.Roles)
                    .FirstOrDefault();
                if (true)
                {
                    MessageBox.Show(user.Role);
                    Admin form2 = new Admin(this);
                    form2.Show();
                }
                if (user.Role == "çàì äèðåêòîðà")
                {
                    MessageBox.Show(user.Role);
                    Deputy_Director form3 = new Deputy_Director(this);
                    form3.Show();
                }
                if (user.Role == "äèðåêòîð")
                {
                    MessageBox.Show(user.Role);
                    director form3 = new director(this);
                    form3.Show();
                }
                if (user.Role == "ðàçðàáîò÷èê")
                {
                    MessageBox.Show(user.Role);
                    Developer form4 = new Developer(this);
                    form4.Show();
                }
                if (user.Role == "òåñòèðîâùèê")
                {
                    MessageBox.Show(user.Role);
                    tester form5 = new tester(this);
                    form5.Show();
                }
                this.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Íåïðàâèëüíûé ëîãèí èëè ïàðîëü");
                textBox1.Text = "";
                textBox2.Text = "";
            }
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

        private void Avtorises_MouseEnter(object sender, EventArgs e)
        {
            Avtorises.ForeColor = Color.FromArgb(48, 119, 140);
        }

        private void Avtorises_MouseLeave(object sender, EventArgs e)
        {
            Avtorises.ForeColor = Color.FromKnownColor(KnownColor.White);
        }
    }
}
