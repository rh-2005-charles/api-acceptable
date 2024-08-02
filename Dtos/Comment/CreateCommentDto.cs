using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos.Comment
{
    public class CreateCommentDto
    {
        //para validar datos
        [Required]
        [MinLength(5, ErrorMessage ="Title must be 5 characters => El título debe tener 5 caracteres.")]
        [MaxLength(250, ErrorMessage ="Title cannot be over 250 characters => El título no puede tener más de 250 caracteres.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage ="Content must be 5 characters => El contenido debe tener 5 caracteres.")]
        [MaxLength(250, ErrorMessage ="Content cannot be over 250 characters => El contenido no puede tener más de 250 caracteres.")]
        public string Content { get; set; } = string.Empty;
    }
}