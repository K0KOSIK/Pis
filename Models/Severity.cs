using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class Severity
{
    public int IdSeverity { get; set; }

    public string Severity1 { get; set; } = null!;

    public int AlertLogsIdAlertLogs { get; set; }

    public virtual AlertLog AlertLogsIdAlertLogsNavigation { get; set; } = null!;
}
