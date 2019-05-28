using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19_Serializacion
{
  [Serializable]
  //EN CASO DE QUE PERSONA HEREDE DE OTRA CLASE HAY QUE AGREGAR OTRA ETIQUETA
  public class Persona
  {
    public string nombre;
    public string apellido;
    public int dni;
    private int numeroTarjeta;

    public Persona() { }

    public Persona(string nombre, string apellido, int dni, int numeroTarjeta)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = dni;
      this.numeroTarjeta = numeroTarjeta;
    }
    public override string ToString()
    {
      return "Nombre: " + this.nombre + " Apellido: " + this.apellido + " DNI: " + this.dni.ToString() + " Nº Tarjeta: " + this.numeroTarjeta;
    }
  }
}
