using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
  public class Pesos
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    static Pesos()
    {
      Pesos.cotizRespectoDolar = 0.023f;
    }
    public Pesos(double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Pesos(double cantidad, float cotizacion):this(cantidad)
    {
      Pesos.cotizRespectoDolar = cotizacion;
    }

    public double GetCantidad() { return this.cantidad; }
    public static float GetCotizacion() {  return Pesos.cotizRespectoDolar; }

    public static explicit operator Dolar(Pesos p)
    {
      return new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
    }

    public static explicit operator Euro(Pesos p)
    {
      var aux = (Dolar)p;
     
      return new Euro(aux.GetCantidad() * Euro.GetCotizacion());
    }
    public static implicit operator Pesos(double d)
    {
      return new Pesos(d);
    }

    public static bool operator ==(Pesos p, Dolar d)
    {
      return (((Dolar)p).GetCantidad() == d.GetCantidad());
    }

    public static bool operator !=(Pesos p, Dolar d)
    {
      return !(p == d);
    }


  }
}
