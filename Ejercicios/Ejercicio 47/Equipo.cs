using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
  public abstract class Equipo
  {
    public string nombre;
    public DateTime fechaCreacion;

    public Equipo(DateTime fecha, string nombre)
    {
      this.fechaCreacion = fecha;
      this.nombre = nombre;
    }
    public static bool operator ==(Equipo a, Equipo b)
    {
      return (a.nombre == b.nombre && a.fechaCreacion == b.fechaCreacion);
    }
    public static bool operator !=(Equipo a, Equipo b)
    {
      return !(a == b);
    }
    public string Ficha()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(this.nombre + " fundado el " + this.fechaCreacion.Date.ToString());
      return sb.ToString();
    }
    
  }
}
