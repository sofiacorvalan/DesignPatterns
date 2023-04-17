using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program { 
        static void Main(string[] args)
        {
            Repartidores rep1 = Creador.crear(Creador.motociclista);
            Console.WriteLine(rep1.tipoRepartidor());

            Repartidores rep2 = Creador.crear(Creador.dron);
            Console.WriteLine(rep2.tipoRepartidor());

            Repartidores rep3 = Creador.crear(Creador.ciclista);
            Console.WriteLine(rep3.tipoRepartidor());

            Console.ReadKey();
        }
    }
}
