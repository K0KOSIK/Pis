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
        public ActiveEntity activeEntity;
        public IsEdit isEdit;
        private readonly Ispr2525PiskunovDvKursovayaContext _dbContext;
        public Admin(Avtorisation form1, Ispr2525PiskunovDvKursovayaContext dbContext)
        {
            _dbContext = dbContext;
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
            
            dataGridView1.DataSource = _dbContext.AlertLogs.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            activeEntity = ActiveEntity.AlertLogs;
        }

        private void UpdateInfo()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            
            var AlertLogs = _dbContext.AlertLogs
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
            
            var DeviceTypes = _dbContext.DeviceTypes
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
            
            var PerformanceReports = _dbContext.PerformanceReports
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
            
            var MonitoringData = _dbContext.MonitoringData
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
            
            var PLC_Devices = _dbContext.PlcDevices
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
            
            var Severity = _dbContext.Severities
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
            
            var Status = _dbContext.Statuses
                .OrderBy(x => x.IdStatus)
                .Select(x => new
                {
                    x.IdStatus,
                    x.Status1,

                });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _dbContext.AlertLogs.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            activeEntity = ActiveEntity.AlertLogs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _dbContext.DeviceTypes.ToList();
            activeEntity = ActiveEntity.Device_Type;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _dbContext.MonitoringData.ToList();
            dataGridView1.Columns[5].Visible = false;
            activeEntity = ActiveEntity.MonitoringData;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _dbContext.PerformanceReports.ToList();
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[7].Visible = false;
            activeEntity = ActiveEntity.PerformanceReports;
            dataGridView1.Columns[7].Visible = false;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _dbContext.PlcDevices.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            activeEntity = ActiveEntity.PLC_Devices;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _dbContext.Severities.ToList();
            dataGridView1.Columns[3].Visible = false;
            activeEntity = ActiveEntity.Severity;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _dbContext.Statuses.ToList();
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
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        var AlertLogs = _dbContext.AlertLogs.Where(x => x.IdAlertLogs == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            AlertLogs.ExecuteDelete();
                            _dbContext.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = _dbContext.AlertLogs.ToList();
                            dataGridView1.Columns[5].Visible = false;
                            dataGridView1.Columns[6].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
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
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Ispr2525PiskunovDvKursovayaContext _dbContext = new();
                        var DeviceTypes = _dbContext.DeviceTypes.Where(x => x.IdDeviceType == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            DeviceTypes.ExecuteDelete();
                            _dbContext.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = _dbContext.DeviceTypes.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
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
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        var PerformanceReports = _dbContext.PerformanceReports.Where(x => x.IdPerformanceReports == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            PerformanceReports.ExecuteDelete();
                            _dbContext.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = _dbContext.PerformanceReports.ToList();
                            //dataGridView1.Columns[5].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
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
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        var MonitoringData = _dbContext.MonitoringData.Where(x => x.IdMonitoringData == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            MonitoringData.ExecuteDelete();
                            _dbContext.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = _dbContext.MonitoringData.ToList();
                            dataGridView1.Columns[5].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
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
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        var PLC_Devices = _dbContext.PlcDevices.Where(x => x.IdPlcDevices == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            PLC_Devices.ExecuteDelete();
                            _dbContext.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = _dbContext.PlcDevices.ToList();
                            dataGridView1.Columns[4].Visible = false;
                            dataGridView1.Columns[5].Visible = false;
                            dataGridView1.Columns[6].Visible = false;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
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
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        var Severity = _dbContext.Severities.Where(x => x.IdSeverity == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Severity.ExecuteDelete();
                            _dbContext.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = _dbContext.Severities.ToList();
                            dataGridView1.Columns[3].Visible = false;


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
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
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        var Status = _dbContext.Statuses.Where(x => x.IdStatus == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Status.ExecuteDelete();
                            _dbContext.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = _dbContext.Statuses.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
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
                    var editing = new Editing(ActiveEntity.AlertLogs, alertLogs, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.AlertLogs.ToList();
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
                    var editing = new Editing(ActiveEntity.Device_Type, deviceType, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.DeviceTypes.ToList();
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
                        StartTime = (DateTime)dataGridView1.SelectedRows[0].Cells[1].Value,
                        EndTime = (DateTime)dataGridView1.SelectedRows[0].Cells[2].Value,
                        TotalRuntime = (decimal)dataGridView1.SelectedRows[0].Cells[3].Value,
                        Downtime = (decimal)dataGridView1.SelectedRows[0].Cells[4].Value,
                        Efficiency = (decimal)dataGridView1.SelectedRows[0].Cells[5].Value,
                        PlcDevicesIdPlcDevices = (int)dataGridView1.SelectedRows[0].Cells[6].Value,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.PerformanceReports, performanceReport, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.PerformanceReports.ToList();
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
                        Timestamp = (DateTime)dataGridView1.SelectedRows[0].Cells[1].Value,
                        Temperature = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                        Load = (string)dataGridView1.SelectedRows[0].Cells[3].Value,
                        PlcDevicesIdPlcDevices = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.MonitoringData, monitoringDatum, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.MonitoringData.ToList();
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
                    var editing = new Editing(ActiveEntity.PLC_Devices, pLC_Devices, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.PlcDevices.ToList();
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
                    var editing = new Editing(ActiveEntity.Severity, severity, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.Severities.ToList();
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
                    var editing = new Editing(ActiveEntity.Status, status, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.Statuses.ToList();
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
                        Timestamp = DateTime.Now,
                        AlertMessage = "",
                        Severity = "",
                        PlcDevicesIdPlcDevices = 0
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.AlertLogs, alertLogs, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.AlertLogs.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
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
                    var editing = new Editing(ActiveEntity.Device_Type, deviceType  , _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.DeviceTypes.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.PerformanceReports)
            {
                try
                {
                    var performanceReport = new PerformanceReport
                    {
                        IdPerformanceReports = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        StartTime = DateTime.Now, 
                        EndTime = DateTime.Now, 
                        TotalRuntime = 0,
                        Downtime = 0,
                        Efficiency = 0,
                        PlcDevicesIdPlcDevices = 0,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.PerformanceReports, performanceReport, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.PerformanceReports.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.MonitoringData)
            {
                try
                {
                    var monitoringDatum = new MonitoringDatum
                    {
                        IdMonitoringData = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Timestamp = DateTime.Now, 
                        Temperature = "", 
                        Load = "", 
                        PlcDevicesIdPlcDevices = 0,
                    };
                    this.Hide();
                    var editing = new Editing(ActiveEntity.MonitoringData, monitoringDatum, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.MonitoringData.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
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
                    var editing = new Editing(ActiveEntity.PLC_Devices, pLC_Devices, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.PlcDevices.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
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
                    var editing = new Editing(ActiveEntity.Severity, severity, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.Severities.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
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
                    var editing = new Editing(ActiveEntity.Status, status, _dbContext);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        
                        dataGridView1.DataSource = _dbContext.Statuses.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
        }
    }
}
