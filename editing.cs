using Pis.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Pis
{
    public partial class Editing : Form
    {
        public int IdAlertLogs { get; set; }

        public DateTime Timestamp { get; set; }

        public string AlertMessage { get; set; }

        //public string Severity { get; set; }

        public int PlcDevicesIdPlcDevices { get; set; }

        public int IdDeviceType { get; set; }

        public string Device { get; set; }

        public int IdMonitoringData { get; set; }

        public string Temperature { get; set; }

        public string Load { get; set; }

        public int IdPerformanceReports { get; set; }

        public string StartTime { get; set; } = null!;

        public string EndTime { get; set; } = null!;

        public float TotalRuntime { get; set; }

        public float Downtime { get; set; }

        public float Efficiency { get; set; }

        public int IdPlcDevices { get; set; }

        public string DeviceName { get; set; }

        public string DeviceType { get; set; }

        public string Status { get; set; }

        public int IdRole { get; set; }

        public string Role1 { get; set; }

        public int UsersIdUsers { get; set; }

        public int IdSeverity { get; set; }

        public string Severity1 { get; set; }

        public int AlertLogsIdAlertLogs { get; set; }

        public int IdStatus { get; set; }

        public string Status1 { get; set; }

        public int IdUsers { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public ActiveEntity x { get; set; }

        public IsEdit isEdit { get; set; }
        public IsError isError;

        private readonly Ispr2525PiskunovDvKursovayaContext _dbContext;

        public Editing(ActiveEntity activeEntity, object entityData, Ispr2525PiskunovDvKursovayaContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
            x = activeEntity;
            ConfigureForm(entityData);
            isError = IsError.N;
        }

        private void ConfigureForm(object entityData)
        {
            switch (x)
            {
                case ActiveEntity.AlertLogs:
                    BindAlertLogs((AlertLog)entityData);
                    break;
                case ActiveEntity.Device_Type:
                    BindDeviceType((DeviceType)entityData);
                    break;
                case ActiveEntity.PerformanceReports:
                    BindPerformanceReports((PerformanceReport)entityData);
                    break;
                case ActiveEntity.MonitoringData:
                    BindMonitoringData((MonitoringDatum)entityData);
                    break;
                case ActiveEntity.PLC_Devices:
                    BindPLC_Devices((PlcDevice)entityData);
                    break;
                case ActiveEntity.Severity:
                    BindSeverity((Severity)entityData);
                    break;
                case ActiveEntity.Status:
                    BindStatus((Status)entityData);
                    break;


                    // Добавьте другие сущности по аналогии MonitoringDatum monitoringDatum
            }
        }

        private void BindAlertLogs(AlertLog alertLogs)
        {
            // Привязка данных к TextBox'ам
            input.DataBindings.Add("Text", alertLogs, nameof(alertLogs.IdAlertLogs));
            dateTimePicker1.DataBindings.Add("Text", alertLogs, nameof(alertLogs.Timestamp));
            input3.DataBindings.Add("Text", alertLogs, nameof(alertLogs.AlertMessage));
            input4.DataBindings.Add("Text", alertLogs, nameof(alertLogs.Severity));
            input5.DataBindings.Add("Text", alertLogs, nameof(alertLogs.PlcDevicesIdPlcDevices));
            List<string> statesAlertlogs = new List<string>
        {
            "Высокий", "Средний", "Низкий",
        };
            input4.Items.Clear();
            input4.Items.AddRange(statesAlertlogs);

            // Скрыть ненужные поля
            input8.Visible = false;
            input6.Visible = false;
            table6.Visible = false;
            input7.Visible = false;
            table7.Visible = false;
            dateTimePicker2.Visible = false;
            table1.Text = "IdAlertLogs";
            table2.Text = "Timestamp";
            table3.Text = "AlertMessage";
            table4.Text = "Severity";
            table5.Text = "PlcDevicesIdPlcDevices";
        }

        private void BindDeviceType(DeviceType deviceType)
        {
            // Пример для другой сущности
            input.DataBindings.Add("Text", deviceType, nameof(deviceType.IdDeviceType));
            input2.DataBindings.Add("Text", deviceType, nameof(deviceType.Device));
            input3.Visible = false;
            table3.Visible = false;
            input4.Visible = false;
            table4.Visible = false;
            input5.Visible = false;
            table5.Visible = false;
            input6.Visible = false;
            table6.Visible = false;
            input7.Visible = false;
            table7.Visible = false;
            input8.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            table1.Text = "IdDeviceType";
            table2.Text = "Device";

            // ... остальные поля
        }

        private void BindPerformanceReports(PerformanceReport performanceReports)
        {
            // Привязка данных к TextBox'ам
            input.DataBindings.Add("Text", performanceReports, nameof(performanceReports.IdPerformanceReports));
            input2.DataBindings.Add("Text", performanceReports, nameof(performanceReports.StartTime));
            input3.DataBindings.Add("Text", performanceReports, nameof(performanceReports.EndTime));
            input4.Visible = false;
            input8.DataBindings.Add("Text", performanceReports, nameof(performanceReports.TotalRuntime));
            input5.DataBindings.Add("Text", performanceReports, nameof(performanceReports.Downtime));
            input6.DataBindings.Add("Text", performanceReports, nameof(performanceReports.Efficiency));
            input7.DataBindings.Add("Text", performanceReports, nameof(performanceReports.PlcDevicesIdPlcDevices));
            input3.Visible = false;
            table1.Text = "IdPerformanceReports";
            table2.Text = "StartTime";
            table3.Text = "EndTime";
            table4.Text = "TotalRuntime";
            table5.Text = "Downtime";
            table6.Text = "Efficiency";
            table7.Text = "PlcDevicesIdPlcDevices";
        }

        private void BindMonitoringData(MonitoringDatum MonitoringDatum)
        {
            // Привязка данных к TextBox'ам
            input.DataBindings.Add("Text", MonitoringDatum, nameof(MonitoringDatum.IdMonitoringData));
            input2.DataBindings.Add("Text", MonitoringDatum, nameof(MonitoringDatum.Timestamp));
            input3.DataBindings.Add("Text", MonitoringDatum, nameof(MonitoringDatum.Temperature));
            input8.DataBindings.Add("Text", MonitoringDatum, nameof(MonitoringDatum.Load));
            input5.DataBindings.Add("Text", MonitoringDatum, nameof(MonitoringDatum.PlcDevicesIdPlcDevices));

            // Скрыть ненужные поля
            input6.Visible = false;
            table6.Visible = false;
            input7.Visible = false;
            table7.Visible = false;
            input4.Visible = false;
            dateTimePicker2.Visible = false;
            table1.Text = "IdMonitoringData";
            table2.Text = "Timestamp";
            table3.Text = "Temperature";
            table4.Text = "Load";
            table5.Text = "PlcDevicesIdPlcDevices";


        }
        private void BindPLC_Devices(PlcDevice pLC_Devices)
        {
            // Привязка данных к TextBox'ам
            input.DataBindings.Add("Text", pLC_Devices, nameof(pLC_Devices.IdPlcDevices));
            input2.DataBindings.Add("Text", pLC_Devices, nameof(pLC_Devices.DeviceName));
            input3.DataBindings.Add("Text", pLC_Devices, nameof(pLC_Devices.DeviceType));
            input4.DataBindings.Add("Text", pLC_Devices, nameof(pLC_Devices.Status));
            List<string> statesPLCDev = new List<string>
        {
            "Работает", "Остановлено", "В ремонте",
        };
            input4.Items.Clear();
            input4.Items.AddRange(statesPLCDev);

            // Скрыть ненужные поля
            input5.Visible = false;
            input6.Visible = false;
            table6.Visible = false;
            input7.Visible = false;
            table7.Visible = false;
            input8.Visible = false;
            table5.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            table1.Text = "IdPlcDevices";
            table2.Text = "DeviceName";
            table3.Text = "DeviceType";
            table4.Text = "Status";
        }
        private void BindSeverity(Severity severity)
        {
            // Пример для другой сущности
            input.DataBindings.Add("Text", severity, nameof(severity.IdSeverity));
            input4.DataBindings.Add("Text", severity, nameof(severity.Severity1));
            input3.DataBindings.Add("Text", severity, nameof(severity.AlertLogsIdAlertLogs));
            List<string> statesSeverity = new List<string>
        {
            "Высокий", "Средний", "Низкий",
        };
            input4.Items.Clear();
            input4.Items.AddRange(statesSeverity);
            dateTimePicker1.Visible = false;
            input5.Visible = false;
            table5.Visible = false;
            input6.Visible = false;
            table6.Visible = false;
            input7.Visible = false;
            table7.Visible = false;
            input8.Visible = false;
            table2.Visible = false;
            input2.Visible = false;
            dateTimePicker2.Visible = false;
            table1.Text = "IdSeverity";
            table4.Text = "Severity";
            table3.Text = "AlertLogsIdAlertLogs";

            // ... остальные поля
        }
        private void BindStatus(Status status)
        {
            // Привязка данных к TextBox'ам
            input.DataBindings.Add("Text", status, nameof(status.IdStatus));
            input8.DataBindings.Add("Text", status, nameof(status.Status1));
            //List<string> Status = new List<string>
            //{
            //"Работает", "Остановлено", "В ремонте",
            //};
            //input4.Items.Clear();
            //input4.Items.AddRange(Status);

            // Скрыть ненужные поля
            table2.Visible = false;
            input2.Visible = false;
            input3.Visible = false;
            input5.Visible = false;
            input6.Visible = false;
            table6.Visible = false;
            input7.Visible = false;
            table7.Visible = false;
            input4.Visible = false;
            table5.Visible = false;
            table3.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            table1.Text = "IdStatus";
            table4.Text = "Status";
        }



        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                switch (x)
                {
                    case ActiveEntity.AlertLogs:
                        AlertLog alertLog;
                        if (isEdit == IsEdit.Y)
                        {
                            alertLog = _dbContext.AlertLogs.Find(Convert.ToInt32(input.Text));
                            if (alertLog == null) throw new Exception("Запись не найдена");
                        }
                        else
                        {
                            alertLog = new AlertLog();
                        }

                        alertLog.IdAlertLogs = Convert.ToInt32(input.Text);
                        alertLog.Timestamp = dateTimePicker1.Value;
                        alertLog.AlertMessage = input3.Text;
                        alertLog.Severity = input4.Text;
                        alertLog.PlcDevicesIdPlcDevices = Convert.ToInt32(input5.Text);

                        if (Convert.ToInt32(input5.Text) < 1 || Convert.ToInt32(input5.Text) > 5)
                        {
                            MessageBox.Show("Значение должно быть от 1 до 5", "Ошибка",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isError = IsError.Y;
                            break;
                        }

                        if (isEdit == IsEdit.N)
                        {
                            _dbContext.Add(alertLog);
                        }
                        _dbContext.SaveChanges();
                        break;

                    case ActiveEntity.Device_Type:
                        DeviceType deviceType;
                        if (isEdit == IsEdit.Y)
                        {
                            deviceType = _dbContext.DeviceTypes.Find(Convert.ToInt32(input.Text));
                            if (deviceType == null) throw new Exception("Запись не найдена");
                        }
                        else
                        {
                            deviceType = new DeviceType();
                        }

                        deviceType.IdDeviceType = Convert.ToInt32(input.Text);
                        deviceType.Device = input2.Text;

                        if (isEdit == IsEdit.N)
                        {
                            _dbContext.Add(deviceType);
                        }
                        _dbContext.SaveChanges();
                        break;

                    case ActiveEntity.PerformanceReports:
                        PerformanceReport performanceReport;
                        if (isEdit == IsEdit.Y)
                        {
                            performanceReport = _dbContext.PerformanceReports.Find(Convert.ToInt32(input.Text));
                            if (performanceReport == null) throw new Exception("Запись не найдена");
                        }
                        else
                        {
                            performanceReport = new PerformanceReport();
                        }

                        performanceReport.IdPerformanceReports = Convert.ToInt32(input.Text);
                        performanceReport.StartTime = dateTimePicker1.Value;
                        performanceReport.EndTime = dateTimePicker2.Value;
                        performanceReport.TotalRuntime = Convert.ToDecimal(input8.Text);
                        performanceReport.Downtime = Convert.ToDecimal(input5.Text);
                        performanceReport.Efficiency = Convert.ToDecimal(input6.Text);
                        performanceReport.PlcDevicesIdPlcDevices = Convert.ToInt32(input7.Text);

                        if (Convert.ToInt32(input7.Text) < 1 || Convert.ToInt32(input7.Text) > 5)
                        {
                            MessageBox.Show("Значение должно быть от 1 до 5", "Ошибка",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isError = IsError.Y;
                            break;
                        }

                        if (isEdit == IsEdit.N)
                        {
                            _dbContext.Add(performanceReport);
                        }
                        _dbContext.SaveChanges();
                        break;

                    case ActiveEntity.MonitoringData:
                        MonitoringDatum monitoringDatum;
                        if (isEdit == IsEdit.Y)
                        {
                            monitoringDatum = _dbContext.MonitoringData.Find(Convert.ToInt32(input.Text));
                            if (monitoringDatum == null) throw new Exception("Запись не найдена");
                        }
                        else
                        {
                            monitoringDatum = new MonitoringDatum();
                        }

                        monitoringDatum.IdMonitoringData = Convert.ToInt32(input.Text);
                        monitoringDatum.Timestamp = dateTimePicker1.Value;
                        monitoringDatum.Temperature = input3.Text;
                        monitoringDatum.Load = input8.Text;
                        monitoringDatum.PlcDevicesIdPlcDevices = Convert.ToInt32(input5.Text);

                        if (Convert.ToInt32(input5.Text) < 1 || Convert.ToInt32(input5.Text) > 5)
                        {
                            MessageBox.Show("Значение должно быть от 1 до 5", "Ошибка",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isError = IsError.Y;
                            break;
                        }

                        if (isEdit == IsEdit.N)
                        {
                            _dbContext.Add(monitoringDatum);
                        }
                        _dbContext.SaveChanges();
                        break;

                    case ActiveEntity.PLC_Devices:
                        PlcDevice plcDevice;
                        if (isEdit == IsEdit.Y)
                        {
                            plcDevice = _dbContext.PlcDevices.Find(Convert.ToInt32(input.Text));
                            if (plcDevice == null) throw new Exception("Запись не найдена");
                        }
                        else
                        {
                            plcDevice = new PlcDevice();
                        }

                        plcDevice.IdPlcDevices = Convert.ToInt32(input.Text);
                        plcDevice.DeviceName = input2.Text;
                        plcDevice.DeviceType = input3.Text;
                        plcDevice.Status = input4.Text;

                        if (isEdit == IsEdit.N)
                        {
                            _dbContext.Add(plcDevice);
                        }
                        _dbContext.SaveChanges();
                        break;

                    case ActiveEntity.Severity:
                        Severity severity;
                        if (isEdit == IsEdit.Y)
                        {
                            severity = _dbContext.Severities.Find(Convert.ToInt32(input.Text));
                            if (severity == null) throw new Exception("Запись не найдена");
                        }
                        else
                        {
                            severity = new Severity();
                        }

                        severity.IdSeverity = Convert.ToInt32(input.Text);
                        severity.Severity1 = input4.Text;
                        severity.AlertLogsIdAlertLogs = Convert.ToInt32(input3.Text);

                        if (Convert.ToInt32(input3.Text) < 1 || Convert.ToInt32(input3.Text) > 5)
                        {
                            MessageBox.Show("Значение должно быть от 1 до 5", "Ошибка",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isError = IsError.Y;
                            break;
                        }

                        if (isEdit == IsEdit.N)
                        {
                            _dbContext.Add(severity);
                        }
                        _dbContext.SaveChanges();
                        break;

                    case ActiveEntity.Status:
                        Status status;
                        if (isEdit == IsEdit.Y)
                        {
                            status = _dbContext.Statuses.Find(Convert.ToInt32(input.Text));
                            if (status == null) throw new Exception("Запись не найдена");
                        }
                        else
                        {
                            status = new Status();
                        }

                        status.IdStatus = Convert.ToInt32(input.Text);
                        status.Status1 = input8.Text;

                        if (isEdit == IsEdit.N)
                        {
                            _dbContext.Add(status);
                        }
                        _dbContext.SaveChanges();
                        break;

                    default:
                        break;
                }

                if (isError == IsError.N)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                ExceptionToFile.SaveExceptionToDesktop(ex);
                isError = IsError.Y;
            }
        }

        private void cancellation_Click(object sender, EventArgs e)
        {
            if (isEdit == IsEdit.Y)
            {
                switch (x)
                {
                    case ActiveEntity.AlertLogs:
                        
                        _dbContext.SaveChanges();
                        break;
                    case ActiveEntity.Device_Type:
                        
                        _dbContext.SaveChanges();
                        break;
                    case ActiveEntity.PerformanceReports:
                        
                        _dbContext.SaveChanges();
                        break;
                    case ActiveEntity.MonitoringData:
                        
                        _dbContext.SaveChanges();
                        break;
                    case ActiveEntity.PLC_Devices:
                        
                        _dbContext.SaveChanges();
                        break;
                    case ActiveEntity.Severity:
                        
                        _dbContext.SaveChanges();
                        break;
                    case ActiveEntity.Status:
                        
                        _dbContext.SaveChanges();
                        break;
                    default:
                        break;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            cancellation_Click(sender, e);
        }

        private void cancellation_MouseEnter(object sender, EventArgs e)
        {
            cancellation.ForeColor = Color.Blue;
        }

        private void cancellation_MouseLeave(object sender, EventArgs e)
        {
            cancellation.ForeColor = Color.White;
        }

        private void save_MouseLeave(object sender, EventArgs e)
        {
            save.ForeColor = Color.White;
        }

        private void save_MouseEnter(object sender, EventArgs e)
        {
            save.ForeColor = Color.Blue;
        }
    }
}
