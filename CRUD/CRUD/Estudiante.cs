using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Carrera { get; set; }
        public string Jornada { get; set; }

        // Este método es el que usa DisplayMember para mostrar en el ListBox
        public override string ToString()
        {
            // Puedes personalizar cómo se muestra cada estudiante
            return $"{Nombre} - {Cedula}";
            // O simplemente: return Nombre;
        }
    }
}
