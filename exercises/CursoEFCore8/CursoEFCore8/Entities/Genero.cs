using System.ComponentModel.DataAnnotations;

namespace CursoEFCore8.Entities
{
    public class Genero
    {
        public int Id { get; set; }
        //[StringLength(maximumLength:150)]
        public string Nombre { get; set; } = null!;
    }
}
