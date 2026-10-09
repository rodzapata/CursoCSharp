using System;
using System.Collections.Generic;
using System.Text;

namespace Linq;
public class Game
{
    public string Title { get; set; } = string.Empty;
    public GameGenre Genre { get; set; } 
    public int Level { get; set; }
    public int Rating { get; set; }
    public int ReleaseYear { get; set; }

    public decimal Price { get; set; }


}
