using System;

namespace Ejercicio_41
{
    public class CentralitaException: Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get { return this.nombreClase; } }
        public string NombreMetodo { get { return this.nombreMetodo; } }

        public CentralitaException(string mensaje, string clase, string metodo):base(mensaje)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }
        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) { }
    }
}
