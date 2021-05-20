using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class Persona
    {
        public int idPersona { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Error")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Error")]
        public string Tipo_persona { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Error")]
        public string Tipo_documento { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string num_documento { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 25, ErrorMessage = "Error")]
        public string direccion { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Error")]
        public string telefono { get; set; }

        [RegularExpression(@"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/",
        ErrorMessage ="Error correo no valido")]        
        public string email { get; set; }
        public int idEstado { get; set; }


    }
}
