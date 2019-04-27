using System;

namespace Entidades
{
    public abstract class Persona
    {
        private string _apellido;
        private string _nombre;
        private int _edad;
        private int _dni;

        public string Apeliido { get {return this._apellido; } }
        public string Nombre { get { return this._nombre; } }
        public int Edad { get { return this._edad} }
        public int DNI { get { return this._dni; } }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._dni = dni;
        }

        public string Mostrar()
        {

        }
    }
}
