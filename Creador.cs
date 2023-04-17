using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Creador
    {
        public const int motociclista = 1;
        public const int dron = 2;
        public const int ciclista = 3;
        public static Repartidores crear(int tipo)
        {
            switch(tipo)
            {
                case motociclista:
                    return new Motociclista();
                case dron: 
                    return new Dron();
                case ciclista:
                    return new Ciclista();
                default: return null;
            }
            
        }
    }
}
