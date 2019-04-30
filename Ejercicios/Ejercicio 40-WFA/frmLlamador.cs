using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_40;

namespace Ejercicio_40_WFA
{
  public partial class frmLlamador : Form
  {
    Centralita centralitaLlamador;
    public frmLlamador(Centralita c)
    {
      this.centralitaLlamador = c;
      InitializeComponent();
      cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
      this.cmbFranja.Enabled = false;
    }
    public Centralita CentralitaLlamador { get { return this.centralitaLlamador; } }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Marcar("1");
    }

    private void Marcar(string numero)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(txtDestino.Text);
      sb.Append(numero);
      txtDestino.Text = sb.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Marcar("2");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Marcar("3");
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Marcar("4");
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.Marcar("5");
    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.Marcar("6");
    }

    private void button7_Click(object sender, EventArgs e)
    {
      this.Marcar("7");
    }

    private void button8_Click(object sender, EventArgs e)
    {
      this.Marcar("8");
    }

    private void button9_Click(object sender, EventArgs e)
    {
      this.Marcar("9");
    }

    private void button0_Click(object sender, EventArgs e)
    {
      this.Marcar("0");
    }

    private void buttonAST_Click(object sender, EventArgs e)
    {
      if(txtDestino.Text == "")
      {
        this.Marcar("*");
      }
    }

    private void buttonNum_Click(object sender, EventArgs e)
    {
      
      if(txtDestino.Text == "")
      {
        this.Marcar("#");
        this.cmbFranja.Enabled = true;
      }

    }

    private void button14_Click(object sender, EventArgs e)
    {
      this.txtDestino.Clear();
      this.cmbFranja.Enabled = false;
    }
  }
}
