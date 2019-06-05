using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    class Lapiz : IAcciones
    {
        private float tamanioMina;

        ConsoleColor IAcciones.Color { get { return ConsoleColor.Gray; } set { throw new NotImplementedException(); } }
        float IAcciones.UnidadesDeEscritura { get { return this.tamanioMina; } set { this.tamanioMina = value; } }

        public Lapiz(int unidades)
        {
            this.tamanioMina = (float)unidades;
        }
        public override string ToString()
        {
            return "Lapiz " + ((IAcciones)this).Color.ToString() + " " + ((IAcciones)this).UnidadesDeEscritura.ToString();
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            ((IAcciones)this).UnidadesDeEscritura -= texto.Count() * 0.1f;
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }
    }
}
