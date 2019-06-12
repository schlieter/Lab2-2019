using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
  class Caja
  {
    private List<string> filaClientes;

    public Caja()
    {
      this.filaClientes = new List<string>();
    }

    public List<string> FilaClientes { get { return this.filaClientes; } }

    public void AtenderClientes()
    {
      
      foreach (string cliente in this.filaClientes)
      {
        Console.WriteLine("Cliente: " + cliente + "Caja: " + Thread.CurrentThread.Name);
      } 
    }

  }
}
