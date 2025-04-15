using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class MonitoringDatum
{
    public int IdMonitoringData { get; set; }

    public string Timestamp { get; set; } = null!;

    public string Temperature { get; set; } = null!;

    public string Load { get; set; } = null!;

    public int PlcDevicesIdPlcDevices { get; set; }

    public virtual PlcDevice PlcDevicesIdPlcDevicesNavigation { get; set; } = null!;
}
