using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        public string nombre;
        public string apellido;
        public int legajo;
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public static string colegio = "UBA";

        public Alumno() { }
        static Alumno()
        {
            colegio = "UBABA";
        }
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            this.notaFinal = -1;
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random final = new Random();
                this.notaFinal = final.Next(4, 10);
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            if (this.notaFinal != -1)
            {
                return this.nombre + " " + this.apellido + " " + this.notaFinal.ToString() + " " + colegio;
            }
            else
            {
                return "Alumno desaprobado";
            }
        }


    }
}
