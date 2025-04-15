using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class PlcDevice
{
    public int IdPlcDevices { get; set; }

    public string DeviceName { get; set; } = null!;

    public string DeviceType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<AlertLog> AlertLogs { get; set; } = new List<AlertLog>();

    public virtual ICollection<MonitoringDatum> MonitoringData { get; set; } = new List<MonitoringDatum>();

    public virtual ICollection<PerformanceReport> PerformanceReports { get; set; } = new List<PerformanceReport>();
}
