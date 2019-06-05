using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    class Boligrafo:IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = (float)unidades;
        }

        public ConsoleColor Color { get { return this.colorTinta; } set { this.colorTinta = value; } }
        public float UnidadesDeEscritura { get { return this.tinta; } set { this.tinta = value; } }

        public override string ToString()
        {
            return "Boligrafo " + this.Color.ToString() + " " + this.UnidadesDeEscritura.ToString();
        }
        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
            return true;
        }
        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= texto.Count() * 0.3f;
            return new EscrituraWrapper(texto, this.Color);
        }



    }
}
