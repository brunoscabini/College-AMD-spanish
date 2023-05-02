using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BE;

namespace Verificaciones
{
    public class Verificacion_cursada
    {
        BLL_Cursada cursada;

        public Verificacion_cursada()
        {
            cursada= new BLL_Cursada();
        }

        public bool Verificar(int pNumero_identificacion)
        {
            return cursada.Obtener_lista().Exists(x => x.Numero_identificacion== pNumero_identificacion);
        }
    }
}
