using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
  public class Torneo<T> where T : Equipo
  {

    public List<T> equipos;
    public string nombre;

    public static bool operator ==(Torneo<T> torneo, T b)
    {
      foreach (T equipo in torneo.equipos)
      {
        if (b == equipo)
        {
          return true;
        }
      }
      return false;
    }
    public static bool operator !=(Torneo<T> torneo, T b)
    {
      return !(torneo == b);
    }
    public static bool operator +(Torneo<T> torneo, T b)
    {
      if (torneo != b)
      {
        torneo.equipos.Add(b);
        return true;
      }
      return false;
    }
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Torneo " + this.nombre);
      foreach(T equipo in this.equipos)
      {
        sb.AppendLine(equipo.Ficha());
      }
      return sb.ToString();
    }
    private string CalcularPartido(T a, T b)
    {

    }
  }
}
