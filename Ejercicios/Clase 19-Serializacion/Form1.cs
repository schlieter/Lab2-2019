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
  public partial class FrmEjemploSerializacion : Form
  {
    public List<Persona> personas;
    public FrmEjemploSerializacion()
    {
      InitializeComponent();
      personas = new List<Persona>();

    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      FrmNuevo nuevo = new FrmNuevo();
      if(nuevo.ShowDialog() == DialogResult.OK)
      {
        this.personas.Add(nuevo.persona);
      }
    }

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
      listView1.Clear();
      foreach(Persona p in personas)
      {
        listView1.Items.Add(p.ToString());
      }

    }
  }
}
