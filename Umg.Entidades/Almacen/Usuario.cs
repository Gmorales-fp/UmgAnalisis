using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class Usuario
    {
        public int idusuario { get; set; }
        public string password_hash { get; set; }
        public string password_sal { get; set; }
        public int idPersona { get; set; }
        public int idRol { get; set; }

    }
}
