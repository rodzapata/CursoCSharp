using Linq;
using System.Reflection;

Console.WriteLine("=== Ejercicios con lINQ ====");


var games = new List<Game>
{
    new() {Title="The legend of Zelda",Genre=GameGenre.Adventure, ReleaseYear=2020, Level=1, Price=100m},
    new() {Title="Mario Bross",Genre=GameGenre.Adventure, ReleaseYear=1987, Level=5, Price=80m},
    new() {Title="Resident Evil",Genre=GameGenre.Horror, ReleaseYear=1990, Level=5, Price=90m},

};

Console.WriteLine("filtramos Genero=Terror");

var generoTerror = games.Where(g => g.Genre == GameGenre.Horror);


foreach (var game in generoTerror)
{
    Console.WriteLine(game.Title);
}

Console.WriteLine("=== ordenar por precion ===");
var gameSort = games.OrderBy(g => g.Price);


foreach (var game in gameSort)
{
    Console.WriteLine($"{game.Title} y  price is {game.Price}");
}


Console.WriteLine(" ====  Ordenar por precio descendente =====");

var gameSortDesc = games.OrderByDescending(g => g.Price);

foreach (var game in gameSortDesc)
{
    Console.WriteLine(game.Title);
}

Console.WriteLine(" ====  el juego mas caro es =====");
var gameMax = games.MaxBy(g => g.Price);

    Console.WriteLine(gameMax?.Title);


Console.WriteLine("==== precio promedio del juego ===");
var gameAveragePrice = games.Average(g => g.Price);

Console.WriteLine($"el precio promedio del juego es {gameAveragePrice}");

Console.WriteLine("===== Generos distinto, osea que no se repitan ===== ");

var gameDistint = games.Select(g => g.Genre).Distinct();

foreach (var game in gameDistint)
{
    Console.WriteLine(game);
}

Console.ReadLine();

