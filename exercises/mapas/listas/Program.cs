namespace listas;

internal class Program
{
    static void Main(string[] args)
    {
        //sintasys moderna
        List<string> nombres1 = [];
        IReadOnlyList<string> nombres3 = [];
        //sintasys antigua
        List<string> nombres2 = new List<string>();

       
        nombres1.Add("Rodney");
        nombres1.Add("cecilia");

        nombres2.Add("juan");
        nombres2.Add("samuel");

        foreach (string n in nombres2)
        {
            Console.WriteLine(n);
        }

       foreach (string n in nombres1) 
        {
            Console.WriteLine(n);
        }

        Console.ReadKey();
    }
}
