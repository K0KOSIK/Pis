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
    public partial class Admin : Form
    {
        private Avtorisation _form1;

       

        public Admin(Avtorisation form1)
        {
            InitializeComponent();
            _form1 = form1;
            this.FormClosed += Admin_FormClosed;
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            activeEntity = ActiveEntity.AlertLogs;
        }

        private void UpdateInfo()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525PiskunovDvKursovayaContext context = new();
            var AlertLogs = context.AlertLogs
                .Include(x => x.PlcDevicesIdPlcDevices)
                .OrderBy(x => x.IdAlertLogs)
                .Select(x => new
                {
                    x.IdAlertLogs,
                    x.Timestamp,
                    x.AlertMessage,
                    x.Severity,
                    x.PlcDevicesIdPlcDevices

                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525PiskunovDvKursovayaContext contex = new();
            var DeviceTypes = contex.DeviceTypes
                .OrderBy(x => x.IdDeviceType)
                .Select(x => new
                {
                    x.IdDeviceType,
                    x.Device,

                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525PiskunovDvKursovayaContext context2 = new();
            var PerformanceReports = context2.PerformanceReports
                .Include(x => x.PlcDevicesIdPlcDevices)
                .OrderBy(x => x.IdPerformanceReports)
                .Select(x => new
                {
                    x.IdPerformanceReports,
                    x.StartTime,
                    x.EndTime,
                    x.TotalRuntime,
                    x.Downtime,
                    x.Efficiency,
                    x.PlcDevicesIdPlcDevices,


                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525PiskunovDvKursovayaContext context3 = new();
            var MonitoringData = context3.MonitoringData
                .Include(x => x.PlcDevicesIdPlcDevices)
                .OrderBy(x => x.IdMonitoringData)
                .Select(x => new
                {
                    x.IdMonitoringData,
                    x.Timestamp,
                    x.Temperature,
                    x.Load,
                    x.PlcDevicesIdPlcDevices

                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525PiskunovDvKursovayaContext context4 = new();
            var PLC_Devices = context4.PlcDevices
                .OrderBy(x => x.IdPlcDevices)
                .Select(x => new
                {
                    x.IdPlcDevices,
                    x.DeviceName,
                    x.DeviceType,
                    x.Status,
                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525PiskunovDvKursovayaContext context5 = new();
            var Severity = context5.Severities
                .Include(x => x.AlertLogsIdAlertLogs)
                .OrderBy(x => x.IdSeverity)
                .Select(x => new
                {
                    x.IdSeverity,
                    x.Severity1,
                    x.AlertLogsIdAlertLogs,

                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525PiskunovDvKursovayaContext context6 = new();
            var Status = context6.Statuses
                .OrderBy(x => x.IdStatus)
                .Select(x => new
                {
                    x.IdStatus,
                    x.Status1,

                });
        }

        private enum ActiveEntity { AlertLogs, Device_Type, PerformanceReports, MonitoringData, PLC_Devices, Severity, Status }
        private ActiveEntity activeEntity;

        private void button1_Click(object sender, EventArgs e)
        {
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.AlertLogs.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
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
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.Severities.ToList();
            dataGridView1.Columns[3].Visible = false;
            activeEntity = ActiveEntity.Severity;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ispr2525PiskunovDvKursovayaContext context = new();
            dataGridView1.DataSource = context.Statuses.ToList();
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
            if (activeEntity == ActiveEntity.AlertLogs)
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось удалить: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }
            }

            if (activeEntity == ActiveEntity.Device_Type)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Ispr2525PiskunovDvKursovayaContext contex = new();
                    var DeviceTypes = contex.DeviceTypes.Where(x => x.IdDeviceType == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        DeviceTypes.ExecuteDelete();
                        contex.SaveChanges();
                        UpdateInfo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось удалить: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }
            }
            if (activeEntity == ActiveEntity.PerformanceReports)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Ispr2525PiskunovDvKursovayaContext contex2 = new();
                    var PerformanceReports = contex2.PerformanceReports.Where(x => x.IdPerformanceReports == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        PerformanceReports.ExecuteDelete();
                        contex2.SaveChanges();
                        UpdateInfo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось удалить: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.MonitoringData)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Ispr2525PiskunovDvKursovayaContext contex3 = new();
                    var MonitoringData = contex3.MonitoringData.Where(x => x.IdMonitoringData == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        MonitoringData.ExecuteDelete();
                        contex3.SaveChanges();
                        UpdateInfo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось удалить: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.PLC_Devices)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Ispr2525PiskunovDvKursovayaContext contex4 = new();
                    var PLC_Devices = contex4.PlcDevices.Where(x => x.IdPlcDevices == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        PLC_Devices.ExecuteDelete();
                        contex4.SaveChanges();
                        UpdateInfo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось удалить: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.Severity)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Ispr2525PiskunovDvKursovayaContext contex5 = new();
                    var Severity = contex5.Severities.Where(x => x.IdSeverity == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        Severity.ExecuteDelete();
                        contex5.SaveChanges();
                        UpdateInfo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось удалить: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.Status)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Ispr2525PiskunovDvKursovayaContext contex6 = new();
                    var Status = contex6.Statuses.Where(x => x.IdStatus == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        Status.ExecuteDelete();
                        contex6.SaveChanges();
                        UpdateInfo();
                    }
                    catch (Exception ex)
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
