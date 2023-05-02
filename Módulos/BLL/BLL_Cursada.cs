using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;

namespace BLL
{
    public class BLL_Cursada
    {
        Controlador controlador;

        public BLL_Cursada() 
        {
            controlador = new Controlador();
        }

        public void Alta(BE_Cursada pCursada)
        {
            controlador.Alta(pCursada);
        }

        public void Modificar(BE_Cursada pCursada_original, BE_Cursada pCursada_actualizacion)
        {
            controlador.Modificar(pCursada_original, pCursada_actualizacion);
        }

        public void Baja(BE_Cursada pCursada)
        {
            controlador.Baja(pCursada);
        }

        public List<BE_Cursada> Obtener_lista()
        {
            return controlador.Obtener_lista_cursadas();
        }

        public List<BE_Alumno> Obtener_alumnos_asociados(BE_Cursada pCursada)
        {
            return controlador.Obtener_alumnos_asociados(pCursada);
        }
        
    }
}
