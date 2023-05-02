using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Materia
    {
        public int Numero_identificacion { get; set; }
        public string Nombre { get; set; }
        public int Año_revision { get; set; }
        public string Descripcion { get; set; }

        public BE_Materia(object[] obj)
        {
            Numero_identificacion = int.Parse(obj[0].ToString());
            Nombre = obj[1].ToString();
            Año_revision = int.Parse(obj[2].ToString());
            Descripcion = obj[3].ToString();
        }
    }
}
