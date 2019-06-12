using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
  class Program
  {
    static void Main(string[] args)
    {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio farmacia = new Negocio(caja1, caja2);

            farmacia.Clientes.Add("Pepe");
            farmacia.Clientes.Add("Patri");
            farmacia.Clientes.Add("Susana");
            farmacia.Clientes.Add("Maria");
            farmacia.Clientes.Add("Claudia");
            farmacia.Clientes.Add("Mercedes");
            farmacia.Clientes.Add("Alba");
            farmacia.Clientes.Add("Irene");
            farmacia.Clientes.Add("Tere");
            farmacia.Clientes.Add("Leonor");


            Thread hilofarmacia = new Thread(farmacia.AsignarCaja);
            Thread hiloCaja1 = new Thread(caja1.AtenderClientes);
            hiloCaja1.Name = "Caja 1";
            Thread hiloCaja2 = new Thread(caja2.AtenderClientes);
            hiloCaja2.Name = "Caja 2";

            hilofarmacia.Start();
            hilofarmacia.Join();

            hiloCaja1.Start();
            hiloCaja2.Start();

            Console.ReadLine();

        }
  }
}
