using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Entidades;

namespace Archivos
{
  public class Texto
  {
    public void Guardar(string archivo, Queue<Patente> datos)
    {
      using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ \+ archivo))
      {
        foreach(Patente p in datos)
        {
          sw.WriteLine(p.CodigoPatente.ToString());
        }
      } 
    }
    public void Leer(string archivo, out Queue<Patente> datos)
    {
      StreamReader sr = new StreamReader(@"C:\Users\alumno\Desktop\" + archivo);
      while (!sr.EndOfStream)
      {
        datos.Enqueue(sr.ReadLine)//UNA VEZ QUE TENGAMOS LOS METODOS DE EXTENSION SE ENCARGARAN DE DEVOLVER EL TIPO
      } 
      
    }
  }
}
