using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un proyecto del tipo Console: 
             * i. Crear un programa que genere 2 torneos, uno de Futbol y otro de Basquet. 
             * ii. Crear 3 equipos de cada tipo. 
             * iii. Agregar los equipos en tantos torneos como se pueda.
             * iv. Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla. 
             * v. Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su respuesta por pantalla. 
             */

            Torneo<EquipoBasquet> TorneoBasquet = new Torneo<EquipoBasquet>();
            Torneo<EquipoFutbol> TorneoFutbol = new Torneo<EquipoFutbol>();

            EquipoBasquet SanAntonio = new EquipoBasquet(DateTime.Now, "San Antonio");
            EquipoBasquet GoldenState = new EquipoBasquet(DateTime.Now, "Golden State");
            EquipoBasquet Boston = new EquipoBasquet(DateTime.Now, "Boston Celtic");
            EquipoBasquet Warriors = new EquipoBasquet(DateTime.Now, "Golden State");


            EquipoFutbol Lanus = new EquipoFutbol(DateTime.Now, "Lanus");
            EquipoFutbol Tigre = new EquipoFutbol(DateTime.Now, "Tigre");
            EquipoFutbol Independiente = new EquipoFutbol(DateTime.Now, "Independiente");

            TorneoBasquet += SanAntonio;
            TorneoBasquet += GoldenState;
            TorneoBasquet += Boston;
            TorneoBasquet += Warriors;

            TorneoFutbol += Lanus;
            TorneoFutbol += Tigre;
            TorneoFutbol += Independiente;

            Console.WriteLine(TorneoBasquet.Mostrar());
            Console.WriteLine(TorneoFutbol.Mostrar());

            Console.WriteLine(TorneoBasquet.JugarPartido);
            Console.WriteLine(TorneoBasquet.JugarPartido);
            Console.WriteLine(TorneoBasquet.JugarPartido);

            Console.WriteLine(TorneoFutbol.JugarPartido);
            Console.WriteLine(TorneoFutbol.JugarPartido);
            Console.WriteLine(TorneoFutbol.JugarPartido);

            Console.ReadLine();
        }
    }
}

