using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class PerformanceReport
{
    public int IdPerformanceReports { get; set; }

    public string StartTime { get; set; } = null!;

    public string EndTime { get; set; } = null!;

    public float TotalRuntime { get; set; }

    public float Downtime { get; set; }

    public float Efficiency { get; set; }

    public int PlcDevicesIdPlcDevices { get; set; }

    public virtual PlcDevice PlcDevicesIdPlcDevicesNavigation { get; set; } = null!;
}
