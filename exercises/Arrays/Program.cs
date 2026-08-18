using Arrays;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Channels;


Console.WriteLine("Array ");
int[] numeros = new int[3] ; //defininos una array de numeros tipo numero 
numeros[0] = 10 ;
numeros[1] = 20 ;
numeros[2] = 30;

string[] nombre1 = ["rodney","samuel"] ;
string[] nombre2 = { "rodney", "samuel" };

Console.WriteLine(nombre1[0]);
Console.WriteLine(nombre2[0]);

foreach (var item in numeros)
{
    //System.Console.WriteLine(item);
    Console.WriteLine(item);
}

Console.WriteLine("mostramos el array");
Console.WriteLine(numeros);


Console.WriteLine("Array declarando e iniciado en una linea");
int[] numeros2 = new int[3] { 40, 50, 60 };

foreach (var item in numeros2)
{
    System.Console.WriteLine(item);
}

Console.WriteLine("Array implicito");
var numeros3 = new[] { 60, 70, 80.25 };

foreach (var item in numeros3)
{
    System.Console.WriteLine(item);
}

Console.WriteLine("--- mostrar contenido de array sin recorrerlo con bucles");
string[] nombres = new string[3];
nombres[0] = "rodney";
nombres[1] = "cecilia";
Console.WriteLine("antes de netcore 8 era asi:");
Array.ForEach(nombres,Console.WriteLine);
Console.WriteLine("a partir .net 5 en adelante usamos string.join");
Console.WriteLine(string.Join(",", nombres));


Console.WriteLine("---- Array de objetos");

Empleado[] arrayEmpleado = new Empleado[2];
arrayEmpleado[0] = new Empleado("rondey", 50);

// Crear primero una instancia y luego agregar al array
Empleado ceci = new Empleado("cecilia", 37);
arrayEmpleado[1] = ceci;

foreach (var item in arrayEmpleado)
{
    Console.WriteLine($"{item.Nombre} y edad {item.Edad}");
}

Console.WriteLine("enviar array como parametro a un metodo");
string[] cliente = { "cecilia", "lucila", "yari" };
ConsultarCliente(cliente);

static void ConsultarCliente(string[] cli)
{
    foreach (var item in cli)
    {
        System.Console.WriteLine(item);
    }
}



Console.WriteLine("---enviar odjeto Empleado  como parametro a un metodo");

//Arreglo de objeos Empleado
Empleado[] empleados = new Empleado[3];
empleados[0] = new Empleado("cecilia", 37);
empleados[1] = new Empleado("juan", 17);
empleados[2] = new Empleado("samuel", 9);

MostrarEmpleado(empleados);

static void MostrarEmpleado(Empleado[] lista)
{
    foreach (var emp in lista)
    {
        System.Console.WriteLine($"{emp.Nombre} y edad {emp.Edad}");
    }
}

Console.WriteLine("--suma de arrays ---");
int[] numero1 = [10,20,30];
int[] numero2 = [1, 2, 3];

Console.WriteLine("sumando usando un ciclo");
int[] totalizado = new int[numero1.Length];

for (int i = 0; i < numero1.Length; i++)
{
    totalizado[i] = numero1[i] + numero2[i];
}
//Console.WriteLine("totalizado "+string.Join(",", totalizado));
Console.WriteLine($"totalizado interpolado  {string.Join(",", totalizado)}");

Console.WriteLine("sumando usando LINQ y comando ZIP que convina 2 colecciones");

int[] totalizadoLinq= numero1
    .Zip(numero2 , (a,b)=> a+b)
    .ToArray();

Console.WriteLine("totalizamos linq "+string.Join(",",totalizadoLinq));
