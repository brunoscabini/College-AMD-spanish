using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;

namespace BLL
{
    public class BLL_Materia
    {
        Controlador controlador;

        public BLL_Materia()
        {
            controlador = new Controlador();
        }

        public void Alta(BE_Materia pMateria)
        {
            controlador.Alta(pMateria);
        }

        public void Modificar(BE_Materia pMateria_original, BE_Materia pMateria_actualizacion)
        {
            controlador.Modificar(pMateria_original, pMateria_actualizacion);
        }

        public void Baja(BE_Materia pMateria)
        {
            controlador.Baja(pMateria);
        }

        public List<BE_Materia> Obtener_lista()
        {
            return controlador.Obtener_lista_materias();
        }
    }
}
