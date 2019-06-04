using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase21DB
{
  public class Provincia
  {
    public string nombre;
    public int id;

    public Provincia(int id, string nombre)
    {
      this.id = id;
      this.nombre = nombre;
    }
    public override string ToString()
    {
      return this.nombre;
    }
  }
}
