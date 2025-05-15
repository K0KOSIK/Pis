using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class MonitoringDatum
{
    public int IdMonitoringData { get; set; }

    public DateTime Timestamp { get; set; } 

    public string Temperature { get; set; } = null!;

    public string Load { get; set; } = null!;

    public int PlcDevicesIdPlcDevices { get; set; }

    public virtual PlcDevice PlcDevicesIdPlcDevicesNavigation { get; set; } = null!;
}
