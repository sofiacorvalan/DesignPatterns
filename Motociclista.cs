﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Motociclista:Repartidores
    {
        public override string tipoRepartidor()
        {
            return "Soy un repartidor motociclista.";
        }
    }
}
