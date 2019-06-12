using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        Thread horaActualizada;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.HoraFija();
            this.HiloHoraActualizada();
        }
        private void HoraFija()
        {
            int i = 0;
            while (true)
            {
                this.lblHoraFija.Text = DateTime.Now.ToString();
                Thread.Sleep(50);
                if (i == 10)
                {
                    break;
                }
                i++;
            }
        }
        private void HoraActualizada()
        {
            while (true)
            {
                if (this.lblHoraActualizada.InvokeRequired)
                {
                    this.lblHoraActualizada.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHoraActualizada.Text = DateTime.Now.ToString();
                    });
                }
                else
                {
                    this.lblHoraActualizada.Text = DateTime.Now.ToString();
                }
                Thread.Sleep(500);
            }
        }
        private void HiloHoraActualizada()
        {
            horaActualizada = new Thread(this.HoraActualizada);
            horaActualizada.Start();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.horaActualizada.Abort();
        }

    }
}
