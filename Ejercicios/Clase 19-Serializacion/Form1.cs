using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Clase_19_Serializacion
{
  public partial class FrmEjemploSerializacion : Form
  {
    public List<Persona> personas;
    
    public FrmEjemploSerializacion()
    {
      InitializeComponent();
      personas = new List<Persona>();
      this.CargarBinario();//PONER TRY CATCH PARA QUE NO ROMPA CUANDO EL BINARIO NO EXISTE
      this.Refrescar();

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
      this.Refrescar();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.GuardarXML();
      this.GuardarBinario();
    }
    private void Refrescar()
    {
      foreach (Persona p in personas)
      {
        listView1.Items.Add(p.ToString());
      }
    }
    private void CargarXML()
    {
      XmlTextReader reader = new XmlTextReader(@"C:\Users\alumno\Desktop\Nueva carpeta\Lab2-2019\Ejercicios\Clase 19-Serializacion\Serializacion.xml");
      XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
      this.personas = (List<Persona>)serializer.Deserialize(reader);
      reader.Close();
    }
    private void CargarBinario()
    {
      FileStream fs = new FileStream(@"C:\Users\alumno\Desktop\Nueva carpeta\Lab2-2019\Ejercicios\Clase 19-Serializacion\Serializacion", FileMode.Open);
      BinaryFormatter ser = new BinaryFormatter();
      this.personas = (List<Persona>)ser.Deserialize(fs);
      fs.Close();
    }
    private void GuardarBinario()
    {
      FileStream fs = new FileStream(@"C:\Users\alumno\Desktop\Nueva carpeta\Lab2-2019\Ejercicios\Clase 19-Serializacion\Serializacion", FileMode.Create);
      BinaryFormatter ser = new BinaryFormatter();
      ser.Serialize(fs, personas);
      fs.Close();
    }
    private void GuardarXML()
    {
      //XmlTextWriter writer = new XmlTextWriter(@"Clase_19_Serializacion.xml",Encoding.UTF8);    DE ESTA MANERA LO GUARDA EN ----> C:\Users\alumno\Desktop\Nueva carpeta\Lab2-2019\Ejercicios\Clase 19-Serializacion\bin\Debug
      XmlTextWriter writer = new XmlTextWriter(@"C:\Users\alumno\Desktop\Nueva carpeta\Lab2-2019\Ejercicios\Clase 19-Serializacion\Serializacion.xml", Encoding.UTF8);
      XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));

      serializer.Serialize(writer, personas);

      writer.Close();
    }
  }
}
