using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    [Table("Comments")] //nombre de la tabla
    public class Comment
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        //para conectar en relacion a la base de datos
        public int? StockId { get; set; }
        //propiedad de navegacion y eso nos permite acceder
        public Stock? Stock { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }


        /* [NotMapped]
        public object Comments { get; internal set; } */
    }
}