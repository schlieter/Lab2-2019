using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Maquina
    {
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;

        private Maquina()
        {
            this.perifericos = new List<Periferico>();
            this.cantidadMaxPerifericos = 3;
        }
        public Maquina(string nombre):this()
        {
            this.nombre = nombre;
        }

        public int CantidadMaximaPerifericos
        {
            get
            {
                return this.cantidadMaxPerifericos;
            }
            set
            {
                if(value < 1)
                {
                    this.cantidadMaxPerifericos = 1;
                }
                else if(value > 4)
                {
                    this.cantidadMaxPerifericos = 4;
                }
                else
                {
                    this.cantidadMaxPerifericos = value;
                }
            }
        }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

        public string SystemInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.Nombre);
                foreach (Periferico p in this.perifericos)
                {
                    sb.AppendLine(p.ExponerDatos());
                    sb.AppendLine();
                }
                return sb.ToString();
            }
        }

        public static bool operator ==(Maquina m, Periferico p)
        {
            foreach(Periferico p2 in m.perifericos)
            {
                if(p2 == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);
        }
        public static string operator +(Maquina m, Periferico p)
        {
            if(m != p && m.perifericos.Count < m.CantidadMaximaPerifericos)
            {
                m.perifericos.Add(p);
                return "Periferico conectado";
            }
            return "No se puede conectar el dispositivo";
        }
        public static string operator -(Maquina m, Periferico p)
        {
            for(int i = 0; i<= m.perifericos.Count; i++)
            {
                if (m.perifericos[i] == p)
                {
                    m.perifericos.RemoveAt(i);
                    return "Periferico desconectado!";
                }
            }
            return "No se puede desconectar el dispositivo";
        }

    }
}
