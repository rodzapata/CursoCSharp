using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias;

public class Refrigerator : Equipment
{
    public override void PerformMaintenance()
    {
        Console.WriteLine("Realizando mantenimiento al Refrigerador");
    }
}
