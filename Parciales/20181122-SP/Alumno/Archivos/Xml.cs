using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace Archivos
{
  public class Xml<T> : IArchivo<T>
  {
    public void Guardar(string archivo, T datos)
    {
      XmlTextWriter writer = new XmlTextWriter(@"C:\Users\alumno\Desktop\"+archivo, Encoding.UTF8);
      XmlSerializer serializer = new XmlSerializer(typeof(T));
      serializer.Serialize(writer, datos);
      writer.Close();
    }
    public void Leer(string archivo, out T datos)
    {
      XmlTextReader reader = new XmlTextReader(@"C:\Users\alumno\Desktop\"+archivo);
      XmlSerializer serializer = new XmlSerializer(typeof(T));
      datos = (T)serializer.Deserialize(reader);
      reader.Close();
    }
  }
}
