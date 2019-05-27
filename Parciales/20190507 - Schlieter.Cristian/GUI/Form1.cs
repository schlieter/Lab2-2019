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

namespace GUI
{
    public partial class FrmPC : Form
    {
        Maquina maquina;
        public FrmPC()
        {
            InitializeComponent();
            maquina = new Maquina("LAB01PC03");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maquina + new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value));
            this.Limpiar();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtModelo.Text == "")
            {
                MessageBox.Show("Ingrese los datos del producto que quiera sacar");
            }
            else
            {
                MessageBox.Show(maquina - new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value));
                this.Limpiar();
            }

        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            rtxtSystemInfo.Text = maquina.SystemInfo;
        }
        private void Limpiar()
        {
            nudMemoria.Value = 0;
            txtMarca.Text = "";
            txtModelo.Text = "";
        }
    }
}
