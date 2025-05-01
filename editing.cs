using Pis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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



        public Editing(ActiveEntity activeEntity, object entityData)
        {
            InitializeComponent();
            x = activeEntity;
            ConfigureForm(entityData);
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


                    // Добавьте другие сущности по аналогии
            }
        }

        private void BindAlertLogs(AlertLog alertLogs)
        {
            // Привязка данных к TextBox'ам
            input.DataBindings.Add("Text", alertLogs, nameof(alertLogs.IdAlertLogs));
            input2.DataBindings.Add("Text", alertLogs, nameof(alertLogs.Timestamp));
            input3.DataBindings.Add("Text", alertLogs, nameof(alertLogs.AlertMessage));
            input4.DataBindings.Add("Text", alertLogs, nameof(alertLogs.Severity));
            input5.DataBindings.Add("Text", alertLogs, nameof(alertLogs.PlcDevicesIdPlcDevices));

            // Скрыть ненужные поля
            input6.Visible = false;
            table6.Visible = false;
            input7.Visible = false;
            table7.Visible = false;
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
            // ... остальные поля
        }

        private void BindPerformanceReports(PerformanceReport performanceReports)
        {
            // Привязка данных к TextBox'ам
            input.DataBindings.Add("Text", performanceReports, nameof(performanceReports.IdPerformanceReports));
            input2.DataBindings.Add("Text", performanceReports, nameof(performanceReports.StartTime));
            input3.DataBindings.Add("Text", performanceReports, nameof(performanceReports.EndTime));
            input4.DataBindings.Add("Text", performanceReports, nameof(performanceReports.TotalRuntime));
            input5.DataBindings.Add("Text", performanceReports, nameof(performanceReports.Downtime));
            input6.DataBindings.Add("Text", performanceReports, nameof(performanceReports.Efficiency));
            input7.DataBindings.Add("Text", performanceReports, nameof(performanceReports.PlcDevicesIdPlcDevices));
        }


        private void save_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case ActiveEntity.AlertLogs:
                    AlertLog alertLog = new();
                    alertLog.IdAlertLogs = Convert.ToInt32(input.Text);
                    alertLog.Timestamp = Convert.ToDateTime(input2.Text);
                    alertLog.AlertMessage = input3.Text;
                    alertLog.Severity = input4.Text;
                    alertLog.PlcDevicesIdPlcDevices = Convert.ToInt32(input5.Text);
                    Ispr2525PiskunovDvKursovayaContext context = new();
                    context.Update(alertLog);
                    context.SaveChanges();
                    break;
                case ActiveEntity.Device_Type:
                    DeviceType deviceType = new();
                    deviceType.IdDeviceType = Convert.ToInt32(input.Text);
                    deviceType.Device = input2.Text;
                    Ispr2525PiskunovDvKursovayaContext context2 = new();
                    context2.Update(deviceType);
                    context2.SaveChanges();
                    break;
                case ActiveEntity.PerformanceReports:
                    PerformanceReport performanceReport = new();
                    performanceReport.IdPerformanceReports = Convert.ToInt32(input.Text);
                    performanceReport.StartTime = Convert.ToDateTime(input2.Text);
                    performanceReport.EndTime = Convert.ToDateTime(input3.Text);
                    performanceReport.TotalRuntime = Convert.ToInt32(input4.Text);
                    performanceReport.Downtime = Convert.ToInt32(input5.Text);
                    performanceReport.Efficiency = Convert.ToInt32(input6.Text);
                    performanceReport.PlcDevicesIdPlcDevices = Convert.ToInt32(input7.Text);
                    Ispr2525PiskunovDvKursovayaContext context3 = new();
                    context3.Update(performanceReport);
                    context3.SaveChanges();
                    break;
                case ActiveEntity.MonitoringData:
                    break;
                case ActiveEntity.PLC_Devices:
                    break;
                case ActiveEntity.Severity:
                    break;
                case ActiveEntity.Status:
                    break;
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

            //  другая форма (переход)
        }

        private void editing_Load(object sender, EventArgs e)
        {

        }

        private void cancellation_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case ActiveEntity.AlertLogs:
                    Ispr2525PiskunovDvKursovayaContext context = new();
                    context.SaveChanges();
                    break;
                case ActiveEntity.Device_Type:
                    Ispr2525PiskunovDvKursovayaContext context2 = new();
                    context2.SaveChanges();
                    break;
                case ActiveEntity.PerformanceReports:
                    Ispr2525PiskunovDvKursovayaContext context3 = new();
                    context3.SaveChanges();
                    break;
                case ActiveEntity.MonitoringData:
                    break;
                case ActiveEntity.PLC_Devices:
                    break;
                case ActiveEntity.Severity:
                    break;
                case ActiveEntity.Status:
                    break;
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
