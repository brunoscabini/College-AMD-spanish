using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BLL;

namespace Verificaciones
{
    public class Verificacion_persona
    {
        BLL_Persona persona;
        public Verificacion_persona()
        {
            persona = new BLL_Persona();
        }

        public bool Verificar(int pNumero_verficacion)
        {
            return persona.Obtener_lista_personas().Exists(x => x.Numero_identificacion == pNumero_verficacion);
        }
    }
}
