using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Teclado: Periferico
    {
        public enum EDistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY
        }
        private EDistribucion distribucion;

        public Teclado(string marca, string modelo, EConector conector):base(marca,modelo,conector)
        {
            this.distribucion = EDistribucion.Dvorak;
        }
        public Teclado(string marca, string modelo, EConector conector, EDistribucion region):base(marca,modelo,conector)
        {
            this.distribucion = region;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Teclado");
            sb.AppendLine((string)this);
            sb.AppendLine("Distribucion: " + this.distribucion.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Teclado t, EDistribucion distribucion)
        {
            return (t.distribucion == distribucion);
        }
        public static bool operator !=(Teclado t, EDistribucion distribucion)
        {
            return !(t == distribucion);
        }

    }
}
