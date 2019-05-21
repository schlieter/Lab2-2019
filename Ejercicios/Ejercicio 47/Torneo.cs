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

        public static bool operator ==(Torneo<T> torneo, Equipo b)
        {
            foreach (Equipo equipo in torneo.equipos)
            {
                if (b == equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, Equipo b)
        {
            return !(torneo == b);
        }
        public static bool operator +(Torneo<T> torneo, Equipo b)
        {
            if(torneo != b)
            {
                torneo.equipos.Add((T)b);////ESTO ESTA BIEN????
                return true;
            }
            return false;
        }
    }
}
