namespace mapas;


internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> frutas= new Dictionary<int, string>();
        frutas.Add(1, "manzana");
        frutas.Add(2, "pera");
        frutas.Add(3, "uvas");

        Console.WriteLine(frutas[2]);

        foreach (var s in frutas)
        {
            //Console.WriteLine(s);
            Console.WriteLine($"Clave: {s.Key} y valor: {s.Value}");
        }
        Console.ReadKey();

    }
}
