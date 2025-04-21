using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class AlertLog
{
    public int IdAlertLogs { get; set; }

    public DateTime Timestamp { get; set; }

    public string AlertMessage { get; set; } = null!;

    public string Severity { get; set; } = null!;

    public int PlcDevicesIdPlcDevices { get; set; }

    public virtual PlcDevice PlcDevicesIdPlcDevicesNavigation { get; set; } = null!;

    public virtual ICollection<Severity> Severities { get; set; } = new List<Severity>();
    public object PLC_Devices_idPLC_Devices { get; internal set; }
    public object IdPerformanceRepots { get; internal set; }
}
