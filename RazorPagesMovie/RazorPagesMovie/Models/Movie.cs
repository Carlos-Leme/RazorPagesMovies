using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "Titulo")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]

        [Display(Name = "Data de Lançamento")]
        //[DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
       
        [Display(Name = "Genêro")]
        public string Genre { get; set; } = string.Empty;
       
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
