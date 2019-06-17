using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67
{
    public class Temporizador
    {
        public delegate void encargadoTiempo();
        private Thread hilo;
        private int intervalo;

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
       /* public bool Activo
        {
            get
            {
                return this.hilo.IsAlive;
            }
            set
            {
                this.hilo = new Thread(Corriendo);
                if(value == true && this.hilo.IsAlive == false)
                {
                    this.hilo.Start();
                }
                else if(value == false && this.hilo.IsAlive == true)
                {
                    this.hilo.Abort();
                }
            }
        }

        private void Corriendo()
        {
            EventoTiempo.Invoke();
            Thread.Sleep(this.Intervalo);
            
        }*/
        public event encargadoTiempo EventoTiempo;


        public bool Activo
        {
            get
            {
                return this.hilo.IsAlive;
            }
            set
            {
                this.hilo = new Thread(new ParameterizedThreadStart(Corriendo));
                if (value == true && this.hilo.IsAlive == false)
                {
                    this.hilo.Start(this.Intervalo);
                }
                else if (value == false && this.hilo.IsAlive == true)
                {
                    this.hilo.Abort();
                }
            }
        }

        private void Corriendo(object intervalo)
        {
            EventoTiempo.Invoke();
            Thread.Sleep((int)intervalo);

        }
    }
}
