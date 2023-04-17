using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
   class Dron:Repartidores
    {
        public override string tipoRepartidor()
        {
            return "Soy un dron Repartidor.";
        }
    }
}
