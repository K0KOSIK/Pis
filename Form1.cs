using Microsoft.EntityFrameworkCore;
using Pis.Models;

namespace Pis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ispr2525PiskunovDvKursovayaContext context = new();
            User? user = context.Users
                .Where(user => user.Username == textBox1.Text && user.Password == textBox2.Text)
                .Include(user => user.Roles)
                .FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show(user.Role);
                Form2 form2 = new Form2(this);
                form2.Show();
                this.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
