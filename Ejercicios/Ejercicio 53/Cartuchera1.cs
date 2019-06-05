using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
  public class Cartuchera1
  {
    public List<IAcciones> miObj;

    public bool ProbarMetodos()
    {
      bool flag = true;
      foreach (IAcciones a in miObj)
      {
        if (a.UnidadesDeEscritura > 0)
        {
          a.UnidadesDeEscritura -= 1;
        }
        else
        {
          flag = false;
        }
        if (a.UnidadesDeEscritura == 0)
        {
          a.Recargar(100);
        }
      }
      return flag;
    }
  }
}
