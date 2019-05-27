using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PlacaVideo:Periferico
    {
        private int ramMB;

        public PlacaVideo(string marca, string modelo, int ramMB):base(marca,modelo,EConector.PCIExpress)
        {
            this.ramMB = ramMB;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Placa de Video");
            sb.AppendLine((string)this);
            sb.AppendLine("Memoria: " + this.ramMB.ToString());
            return sb.ToString();
        }

    }
}
