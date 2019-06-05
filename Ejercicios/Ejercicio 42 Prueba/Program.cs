using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_42;

namespace Ejercicio_42_Prueba
{
  class Program
  {
    static void Main(string[] args)
    {

      try
      {
        Class1 a = new Class1();
        a.PuntoD();
      }
      catch (MiException e)
      {
        Console.WriteLine(e.Message);
        Exception innerEx = e.InnerException;

        while (innerEx != null)
        {
          Console.WriteLine(innerEx.Message);
          innerEx = innerEx.InnerException;
        }

        Console.ReadLine();
      }


    }
  }
}
