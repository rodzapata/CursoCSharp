using System.Security.Cryptography.X509Certificates;

namespace Genericos;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Manegando Genericos");

        int[] arrayNumber = { 1, 2, 3, };
        double[] arrayDouble = { 1.1, 2.2, 3.3 };
        string[] arrayString = { "uno", "dos", "tres" };
        MostrarArray(arrayNumber);
        MostrarArray(arrayDouble);
        MostrarArray(arrayString);

        Console.ReadKey();

        
    }
    public static void MostrarArray<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.WriteLine("elemneto " + item);
        }
    }

}
