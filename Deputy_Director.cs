using Microsoft.EntityFrameworkCore;
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
    public partial class Deputy_Director : Form
    {
        private Avtorisation _form1;

        private enum ActiveEntity { AlertLogs, Device_Type, PerformanceReports, MonitoringData, PLC_Devices, Severity, Status }
        private ActiveEntity activeEntity;

        private void UpdateInfo()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525PiskunovDvKursovayaContext context = new();
            var AlertLogs = context.AlertLogs
                .Include(x => x.PlcDevicesIdPlcDevices)
                .OrderBy(x => x.IdPerformanceRepots)
                .Select(x => new
                {
                    x.IdPerformanceRepots,
                    x.Timestamp,
                    x.AlertMessage,
                    x.Severity,
                    x.PlcDevicesIdPlcDevices

                });
        }

        public Deputy_Director(Avtorisation form1)
        {
            InitializeComponent();
            _form1 = form1;
            this.FormClosed += Deputy_Director_FormClosed;
            activeEntity = ActiveEntity.AlertLogs;
        }

        private void Deputy_Director_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }
        private void Deputy_Director_Load(object sender, EventArgs e)
        {
            button1.Visible= false;
            button6.Visible= false;
            button7.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeEntity = ActiveEntity.AlertLogs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.DeviceTypes.ToList();
            activeEntity = ActiveEntity.Device_Type;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.MonitoringData.ToList();
            dataGridView1.Columns[5].Visible = false;
            activeEntity = ActiveEntity.MonitoringData;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.PerformanceReports.ToList();
            dataGridView1.Columns[5].Visible = false;
            activeEntity = ActiveEntity.PerformanceReports;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.PlcDevices.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            activeEntity = ActiveEntity.PLC_Devices;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            activeEntity = ActiveEntity.Severity;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            activeEntity = ActiveEntity.Status;
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
            if(activeEntity == ActiveEntity.AlertLogs)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Ispr2525PiskunovDvKursovayaContext context = new();
                    var AlertLogs = context.AlertLogs.Where(x => x.IdAlertLogs == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        AlertLogs.ExecuteDelete();
                        context.SaveChanges();
                        UpdateInfo();
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось удалить: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }
            }

            
        }

    }
}
