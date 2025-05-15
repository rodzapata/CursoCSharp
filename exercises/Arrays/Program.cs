using Arrays;

Console.WriteLine("Array ");
int[] numeros = new int[3] ; //defininos una array de numeros tipo numero 
numeros[0] = 10 ;
numeros[1] = 20 ;
numeros[2] = 30;

foreach (var item in numeros)
{
    System.Console.WriteLine(item);
}

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

Console.WriteLine("Array de objetos");

Empleado[] arrayEmpleado = new Empleado[2];
arrayEmpleado[0] = new Empleado("rondey", 50);

// Crear primero una instancia y luego agregar al array
Empleado ceci = new Empleado("cecilia", 37);
arrayEmpleado[1] = ceci;

foreach (var item in arrayEmpleado)
{
    Console.WriteLine($"{item.Nombre} y edad {item.Edad}");
}