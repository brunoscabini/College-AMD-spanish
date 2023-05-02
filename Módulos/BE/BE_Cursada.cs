using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Cursada
    {
        public int Numero_identificacion;
        private BE_Materia _materia;
        public string Materia
        {
            get
            {
                return _materia.Nombre;
            }
        }
        private BE_Docente _docente;
        public string Nombre_docente
        {
            get
            {
                return _docente.Nombre;
            }
        }
        public string Apellido_docente
        {
            get
            {
                return _docente.Apellido;
            }
        }

        public int Ciclo_lectivo { get; set; }
        public int Cuatrimestre { get; set; }
        public BE_Cursada(BE_Materia pMateria, BE_Docente pDocente, object[] obj)
        {
            Numero_identificacion = int.Parse(obj[0].ToString());
            _materia = pMateria;
            _docente = pDocente;
            Ciclo_lectivo = int.Parse(obj[1].ToString());
            Cuatrimestre = int.Parse(obj[2].ToString());
        }

        public BE_Materia Obtener_materia()
        {
            return _materia;
        }

        public BE_Docente Obtener_docente()
        {
            return _docente;
        }

    }
}
