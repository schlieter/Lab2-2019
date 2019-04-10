using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
  public class Euro
  {

    private double cantidad;
    private static float cotizRespectoDolar;

    static Euro()
    {
      Euro.cotizRespectoDolar = 0.89f;
    }
    public Euro(double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Euro(double cantidad, float cotizacion) : this(cantidad)
    {
      Euro.cotizRespectoDolar = cotizacion;
    }

    public double GetCantidad() { return this.cantidad; }
    public static float GetCotizacion() { return Euro.cotizRespectoDolar; }

    public static explicit operator Dolar(Euro e)
    {
      return new Dolar(e.GetCantidad() * Euro.GetCotizacion());
    }
    public static explicit operator Pesos(Euro e)
    {
      Dolar aux = (Dolar)e;
      //var aux = (Dolar)e;
      return new Pesos(aux.GetCantidad() * Pesos.GetCotizacion());
    }
    public static implicit operator Euro(double d)
    {
      return new Euro(d);
    }
  }
}
