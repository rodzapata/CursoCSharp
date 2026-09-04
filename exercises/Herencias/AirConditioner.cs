using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias;

internal class AirConditioner : Equipment
{
    public override void PerformMaintenance()
    {
        Console.WriteLine("Realizar mantenimiento al aire acondicionado");
    }
}
