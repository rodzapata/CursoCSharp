namespace init;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("pruebas con init");
        //var equipment = new Equipment("chiller", "ch-001");
        var equipment = new Equipment
        {
            Name = "chiller",
            SerialNumber = "ch-001"
        };

        Console.WriteLine($"Nombre = {equipment.Name} y serial {equipment.SerialNumber}");
    }
}
