using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class PerformanceReport
{
    public int IdPerformanceReports { get; set; }

    public DateTime StartTime { get; set; } 

    public DateTime EndTime { get; set; } 

    public decimal TotalRuntime { get; set; }

    public decimal Downtime { get; set; }

    public decimal Efficiency { get; set; }

    public int PlcDevicesIdPlcDevices { get; set; }

    public virtual PlcDevice PlcDevicesIdPlcDevicesNavigation { get; set; } = null!;
}
