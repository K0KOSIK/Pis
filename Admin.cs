using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[6].Visible = false;

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

        private ActiveEntity activeEntity;
        private IsEdit isEdit;

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
            dataGridView1.Columns[7].Visible = false;
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
                        dataGridView1.DataSource = context.AlertLogs.ToList();
                        dataGridView1.Columns[5].Visible = false;
                        dataGridView1.Columns[6].Visible = false;
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
                        dataGridView1.DataSource = contex.DeviceTypes.ToList();
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
                        dataGridView1.DataSource = contex2.PerformanceReports.ToList();
                        dataGridView1.Columns[5].Visible = false;
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
                        dataGridView1.DataSource = contex3.MonitoringData.ToList();
                        dataGridView1.Columns[5].Visible = false;
                        dataGridView1.Columns[7].Visible = false;
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
                        dataGridView1.DataSource = contex4.PlcDevices.ToList();
                        dataGridView1.Columns[4].Visible = false;
                        dataGridView1.Columns[5].Visible = false;
                        dataGridView1.Columns[6].Visible = false;

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
                        dataGridView1.DataSource = contex5.Severities.ToList();
                        dataGridView1.Columns[3].Visible = false;

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
                        dataGridView1.DataSource = contex6.Statuses.ToList();
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

        private void bt_edit_Click(object sender, EventArgs e)
        {
            isEdit = IsEdit.Y;
            if (activeEntity == ActiveEntity.AlertLogs)
            {
                try
                {
                    var alertLogs = new AlertLog
                    {
                        IdAlertLogs = ((int)dataGridView1.SelectedRows[0].Cells[0].Value),
                        Timestamp = ((DateTime)dataGridView1.SelectedRows[0].Cells[1].Value),
                        AlertMessage = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                        Severity = (string)dataGridView1.SelectedRows[0].Cells[3].Value,
                        PlcDevicesIdPlcDevices = ((int)dataGridView1.SelectedRows[0].Cells[4].Value)
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.AlertLogs, alertLogs);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context = new();
                        dataGridView1.DataSource = context.AlertLogs.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Device_Type)
            {
                try
                {
                    var deviceType = new DeviceType
                    {
                        IdDeviceType = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Device = (string)dataGridView1.SelectedRows[0].Cells[1].Value
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.Device_Type, deviceType);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context1 = new();
                        dataGridView1.DataSource = context1.DeviceTypes.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.PerformanceReports)
            {
                try
                {
                    var performanceReport = new PerformanceReport
                    {
                        IdPerformanceReports = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        StartTime = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        EndTime = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                        TotalRuntime = (decimal)dataGridView1.SelectedRows[0].Cells[3].Value,
                        Downtime = (decimal)dataGridView1.SelectedRows[0].Cells[4].Value,
                        Efficiency = (decimal)dataGridView1.SelectedRows[0].Cells[5].Value,
                        PlcDevicesIdPlcDevices = (int)dataGridView1.SelectedRows[0].Cells[6].Value,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.PerformanceReports, performanceReport);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context2 = new();
                        dataGridView1.DataSource = context2.PerformanceReports.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.MonitoringData)
            {
                try
                {
                    var monitoringDatum = new MonitoringDatum
                    {
                        IdMonitoringData = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Timestamp = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        Temperature = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                        Load = (string)dataGridView1.SelectedRows[0].Cells[3].Value,
                        PlcDevicesIdPlcDevices = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.MonitoringData, monitoringDatum);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context3 = new();
                        dataGridView1.DataSource = context3.MonitoringData.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.PLC_Devices)
            {
                try
                {
                    var pLC_Devices = new PlcDevice
                    {
                        IdPlcDevices = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        DeviceName = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        DeviceType = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                        Status = (string)dataGridView1.SelectedRows[0].Cells[3].Value,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.PLC_Devices, pLC_Devices);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context4 = new();
                        dataGridView1.DataSource = context4.PlcDevices.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Severity)
            {
                try
                {
                    var severity = new Severity
                    {
                        IdSeverity = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Severity1 = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        AlertLogsIdAlertLogs = (int)dataGridView1.SelectedRows[0].Cells[2].Value,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.Severity, severity);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context5 = new();
                        dataGridView1.DataSource = context5.Severities.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Status)
            {
                try
                {
                    var status = new Status
                    {
                        IdStatus = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Status1 = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.Status, status);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context6 = new();
                        dataGridView1.DataSource = context6.Statuses.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            isEdit = IsEdit.N;
            if (activeEntity == ActiveEntity.AlertLogs)
            {
                try
                {
                    var alertLogs = new AlertLog
                    {
                        IdAlertLogs = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Timestamp = DateTime.MinValue,
                        AlertMessage = "",
                        Severity = "",
                        PlcDevicesIdPlcDevices = 0
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.AlertLogs, alertLogs);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context = new();
                        dataGridView1.DataSource = context.AlertLogs.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Device_Type)
            {
                try
                {
                    var deviceType = new DeviceType
                    {
                        IdDeviceType = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value+1,
                        Device = ""
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.Device_Type, deviceType);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context1 = new();
                        dataGridView1.DataSource = context1.DeviceTypes.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.PerformanceReports)
            {
                try
                {
                    var performanceReport = new PerformanceReport
                    {
                        IdPerformanceReports = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        StartTime = "", //ПЕРЕДЕДЛАТЬ
                        EndTime = "", //ПЕРЕДЕДЛАТЬ
                        TotalRuntime = 0,
                        Downtime = 0,
                        Efficiency = 0,
                        PlcDevicesIdPlcDevices = 0,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.PerformanceReports, performanceReport);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context2 = new();
                        dataGridView1.DataSource = context2.PerformanceReports.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.MonitoringData)
            {
                try
                {
                    var monitoringDatum = new MonitoringDatum
                    {
                        IdMonitoringData = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Timestamp = "", //ПЕРЕДЕДЛАТЬ
                        Temperature = "", //ПЕРЕДЕДЛАТЬ
                        Load = "", //ПЕРЕДЕДЛАТЬ
                        PlcDevicesIdPlcDevices = 0,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.MonitoringData, monitoringDatum);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context3 = new();
                        dataGridView1.DataSource = context3.MonitoringData.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.PLC_Devices)
            {
                try
                {
                    var pLC_Devices = new PlcDevice
                    {
                        IdPlcDevices = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        DeviceName = "",
                        DeviceType = "",
                        Status = "",
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.PLC_Devices, pLC_Devices);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context4 = new();
                        dataGridView1.DataSource = context4.PlcDevices.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Severity)
            {
                try
                {
                    var severity = new Severity
                    {
                        IdSeverity = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Severity1 = "",
                        AlertLogsIdAlertLogs = 0,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.Severity, severity);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context5 = new();
                        dataGridView1.DataSource = context5.Severities.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Status)
            {
                try
                {
                    var status = new Status
                    {
                        IdStatus = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Status1 = "",
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.Status, status);
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525PiskunovDvKursovayaContext context6 = new();
                        dataGridView1.DataSource = context6.Statuses.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
        }
    }
}
