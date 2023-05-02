using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo_usuario { get; set; }
        public string Tipo_identificacion { get; set; }
        public int Numero_identificacion { get; set; }
        public string Pais_origen { get; set; }
    
        public string Genero { get; set; }
        private DateTime _fecha_nacimiento { get; set; }

        public int Edad
        {
            get
            {
                int x = DateTime.Now.Year - _fecha_nacimiento.Year;
                if (_fecha_nacimiento.DayOfYear < DateTime.Now.DayOfYear)
                {
                    x--;
                }
                return x;
            }
        }

        public BE_Persona(object[] obj)
        {
            Nombre = obj[0].ToString();
            Apellido = obj[1].ToString();
            Tipo_identificacion = obj[2].ToString();
            Numero_identificacion = (int)obj[3];
            Pais_origen = obj[4].ToString();
            Genero = obj[5].ToString();
            _fecha_nacimiento = DateTime.Parse(obj[6].ToString());
        }

        public DateTime Obtener_fecha_nacimiento()
        {
            return _fecha_nacimiento;
        }
    }

    public class BE_Alumno : BE_Persona
    {
        public BE_Alumno(object[] obj) : base(obj)
        {
            Tipo_usuario = "Alumno";
        }
    }

    public class BE_Docente : BE_Persona
    {
        public BE_Docente(object[] obj) : base(obj)
        {
            Tipo_usuario = "Docente";
        }
    }
}
