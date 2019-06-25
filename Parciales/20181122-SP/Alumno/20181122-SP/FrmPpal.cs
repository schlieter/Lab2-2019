using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> listaDeHilos;
        

        public FrmPpal()
        {
            InitializeComponent();
            this.cola = new Queue<Patente>();
            this.listaDeHilos = new List<Thread>();
        }


        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<Queue<Patente>> xml = new Xml<Queue<Patente>>();
            xml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), out cola);
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto txt = new Texto();
            txt.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), out cola);
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            sql.Leer("patentes", out cola);
        }

        private void FinalizarSimulacion()
        {
            foreach(Thread t in listaDeHilos)
            {
                t.Abort();
            }
        }
    }
}
