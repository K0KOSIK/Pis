﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis.Models
{
    public partial class Form2 : Form
    {
        //public Form2()
        //{
        //    InitializeComponent();
        //    this.FormClosed += Form2_FormClosed;
        //}
        //private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Form1 form1 = new Form1();
        //    form1.Show();
        //}
        private Form1 _form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            this.FormClosed += Form2_FormClosed;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.AlertLogs.ToList();
            dataGridView2.DataSource = context.DeviceTypes.ToList();
            dataGridView3.DataSource = context.MonitoringData.ToList();
            dataGridView4.DataSource = context.PerformanceReports.ToList();
            dataGridView5.DataSource = context.PlcDevices.ToList();
            dataGridView6.DataSource = context.Severities.ToList();
            dataGridView7.DataSource = context.Statuses.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Show();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Show();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Show();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Show();
            dataGridView6.Hide();
            dataGridView7.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Show();
            dataGridView7.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Show();
        }
    }
}
