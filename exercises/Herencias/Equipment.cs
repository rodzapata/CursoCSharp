using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias;

public abstract class Equipment
{
    public string SerialNumber { get; set; }=string.Empty;
    public abstract void PerformMaintenance();

}
