using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
  class Cartuchera2
  {
    public List<Boligrafo> misBoligrafos;
    public List<Lapiz> misLapices;

    public bool ProbarElementos()
    {
      bool flag = true;
      foreach(Boligrafo b in misBoligrafos)
      {
        if(b.UnidadesDeEscritura > 0)
        {
          b.UnidadesDeEscritura -= 1;
        }
        else
        {
          flag = false;
        }
        if(b.UnidadesDeEscritura == 0)
        {
          b.Recargar(100);
        }
      }
      foreach(Lapiz l in misLapices)
      {
        if(((IAcciones)l).UnidadesDeEscritura > 0)
        {
          ((IAcciones)l).UnidadesDeEscritura -= 1;
        }
        else
        {
          flag = false;
        }
        if(((IAcciones)l).UnidadesDeEscritura == 0)
        {
          ((IAcciones)l).Recargar(100);
        }
      }
      return flag;
    }


  }
}
