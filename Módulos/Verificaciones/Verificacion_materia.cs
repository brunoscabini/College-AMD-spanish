using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace Verificaciones
{
    public class Verificacion_materia
    {
        BLL_Materia materia;

        public Verificacion_materia()
        {
            materia = new BLL_Materia();
        }

        public bool Verificar(int pNumero_identificacion)
        {
            return materia.Obtener_lista().Exists(x => x.Numero_identificacion == pNumero_identificacion);
        }
    }
}
