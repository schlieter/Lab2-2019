using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19_Serializacion
{
  public class Persona
  {
    public string nombre;
    public string apellido;
    public int dni;

    public Persona() { }

    public Persona(string nombre, string apellido, int dni)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = dni;
    }
    public override string ToString()
    {
      return "Nombre: " + this.nombre + " Apellido: " + this.apellido + " DNI: " + this.dni.ToString();
    }
  }
}
