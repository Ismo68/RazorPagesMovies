using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovies.Models
{
    public class Movie
    {

        public int ID { get; set; } //identificador para cada pelicula

        public string Title { get; set; } // nombre de la pelicula 


        //Añadimos el siguiente codigo porque el atributo Display especifica qué se muestra como nombre de un campo
        // en este caso, "Release Date" en lugar de "ReleaseDate".
        [Display(Name = "Release Date")]

        [DataType(DataType.Date)] //tipo de dato que utilizara la variable ReleaseDate( si es de tipo date solo se vera la fecha, no la hora)
        public DateTime ReleaseDate { get; set; } // fecha de lanzamiento



        public string Genero { get; set; } // Genero de la pelicula



        [Column(TypeName = "decimal(18,2)")] //Permite que Entity Framework Core asigne correctamente Price a la 
                                             //moneda de la base de datos (En todas las paginas sea decimal y no en algunas
                                             //entero, asi todas iguales).
        public decimal Price { get; set; } // Precio de la pelicula
    

    }
}
