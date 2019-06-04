using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Clase21DB
{
  public partial class Form1 : Form
  {
    private List<Provincia> provincias;
    public Form1()
    {
      InitializeComponent();
      
    }

    private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    private void CargarProvincias()
    {
      SqlConnection miConexion = new SqlConnection(Properties.Settings.Default.SQLEjemplo);

      SqlCommand comando = new SqlCommand();
      comando.CommandType = System.Data.CommandType.Text;
      comando.Connection = miConexion;
      comando.CommandText = "select * from provincias";
      miConexion.Open();

      SqlDataReader dataReaderObject = comando.ExecuteReader();

      provincias = new List<Provincia>();
      
      while (dataReaderObject.Read())
      {
        int id = (int)(decimal)dataReaderObject["id"];
        string nombre = dataReaderObject["nombre"].ToString();
        provincias.Add(new Provincia(id, nombre));
      }
      cmbProvincias.DataSource = provincias;
      
      miConexion.Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.CargarProvincias();
    }
  }
}
