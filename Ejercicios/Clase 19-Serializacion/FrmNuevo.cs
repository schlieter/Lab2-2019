using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_19_Serializacion
{
  public partial class FrmNuevo : Form
  {
    public Persona persona;
    public FrmNuevo()
    {
      InitializeComponent();
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      if (txtBoxNombre.Text != "" && txtBoxApellido.Text != "" && txtBoxDNI.Text != "" && txtBoxNumeroTarjeta.Text != "")
      {
        persona = new Persona(txtBoxNombre.Text, txtBoxApellido.Text, int.Parse(txtBoxDNI.Text), int.Parse(txtBoxNumeroTarjeta.Text));
        this.DialogResult = DialogResult.OK;
      }
      else
      {
        MessageBox.Show("ERROR, ingrese todos los datos");
      }

    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}
