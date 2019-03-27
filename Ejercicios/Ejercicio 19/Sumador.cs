using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
  class Sumador
  {
    private int cantidadSumas;

    public Sumador():this(0)
    {    }
    public Sumador(int suma)
    {
      this.cantidadSumas = suma;
    }

    public long Sumar(long a, long b)
    {
      this.cantidadSumas++;
      return a + b;
    }
    public string Sumar(string a, string b)
    {
      this.cantidadSumas++;
      return a + b;
    }
    public static long operator +(Sumador s1,Sumador s2)
    {
      return s1.cantidadSumas + s2.cantidadSumas;
    }
    public static bool operator |(Sumador s1, Sumador s2)
    {
      return s1.cantidadSumas == s2.cantidadSumas;
    }
    public static explicit operator int(Sumador s)
    {
      return s.cantidadSumas;
    }
  }
}
