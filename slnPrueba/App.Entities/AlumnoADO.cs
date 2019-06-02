using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class AlumnoADO
    {
        public int AlumnoID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
