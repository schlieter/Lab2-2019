using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public abstract class Periferico
    {
        private EConector conector;
        private string marca;
        private string modelo;

        public Periferico(string marca, string modelo, EConector conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.conector = conector;
        }

        public static explicit operator string(Periferico p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: " + p.marca);
            sb.AppendLine("Modelo: " + p.modelo);
            sb.AppendLine("Conector: " + p.conector.ToString());
            return sb.ToString();
        }
        public abstract string ExponerDatos();

        public static bool operator ==(Periferico p1, Periferico p2)
        {
            return (p1.marca == p2.marca && p1.modelo == p2.modelo);
        }
        public static bool operator !=(Periferico p1, Periferico p2)
        {
            return !(p1 == p2);
        }


    }
}
