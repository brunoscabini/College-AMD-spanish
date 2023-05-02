using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;

namespace BLL
{
    public class BLL_Persona
    {
        Controlador controlador;

        public BLL_Persona()
        {
            controlador = new Controlador();
        }

        public void Alta(BE_Persona pPersona)
        {
            controlador.Alta(pPersona);
        }

        public void Modificar(BE_Persona pPersona_original, BE_Persona pPersona_actualizacion)
        {
            controlador.Modificar(pPersona_original, pPersona_actualizacion);
        }

        public void Baja(BE_Persona pPersona)
        {
            controlador.Baja(pPersona);
        }

        public List<BE_Persona> Obtener_lista_personas()
        {
            return controlador.Obtener_lista_personas();
        }

        public void Asignar(BE_Alumno pAlumno, BE_Cursada pCursada)
        {
            controlador.Asignar(pAlumno, pCursada);
        }

        public void Derogar(BE_Alumno pAlumno, BE_Cursada pCursada)
        {
            controlador.Derogar(pAlumno, pCursada);
        }

        public List<BE_Cursada> Obtener_cursadas_asociadas(BE_Alumno pAlumno)
        {
            return controlador.Obtener_cursadas_asociadas(pAlumno);
        }
    }
}
