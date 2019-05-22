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

        static Random resultado = new Random();
        static Random i = new Random();

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }

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
        public static Torneo<T> operator +(Torneo<T> torneo, T b)
        {
           if(torneo != b)
            {
                torneo.equipos.Add(b);
                Console.WriteLine("Equipo agregado");
                return torneo;
            }
            Console.WriteLine("El equipo ya se encuentra");
            return torneo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Torneo " + this.nombre);
            foreach (T equipo in this.equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T a, T b)
        {
            StringBuilder sb = new StringBuilder();

            if (a is EquipoBasquet)
            {
                sb.Append(a.nombre + " " + resultado.Next(50, 150) + " - ");
                sb.Append(b.nombre + " " + resultado.Next(50, 150));
            }
            else
            {
                sb.Append(a.nombre + " " + resultado.Next(0, 10) + " - ");
                sb.Append(b.nombre + "  " + resultado.Next(0, 10));
            }
            return sb.ToString();
        }
        public string JugarPartido
        {
            get
            {
                int a = i.Next(0, this.equipos.Count);
                int b = i.Next(0, this.equipos.Count);
                if (a == b)
                {
                    return this.CalcularPartido(this.equipos[a], this.equipos[b]);
                }
                return this.CalcularPartido(this.equipos[a], this.equipos[b]);
            }
        }
    }
}
