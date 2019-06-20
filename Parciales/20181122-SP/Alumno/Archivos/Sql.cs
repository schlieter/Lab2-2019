using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
  public class Sql : IArchivo<Queue<Patente>>
  {
    private SqlCommand comando;
    private SqlConnection conexion;

    public Sql()
    {
      this.comando = new SqlCommand();
      this.conexion = new SqlConnection(Properties.Settings.Default.patentesDB);
    }
    public void Leer(string tabla, out Queue<Patente> datos)
    {
      this.comando.CommandType = System.Data.CommandType.Text;
      this.comando.Connection = this.conexion;
      this.comando.CommandText = "select * from "+ tabla;
      this.conexion.Open();
      SqlDataReader dataReaderObj = comando.ExecuteReader();
      datos = new Queue<Patente>();

      while (dataReaderObj.Read())
      {
        string patente = dataReaderObj["patente"].ToString();
        Patente.Tipo tipo = (Patente.Tipo)dataReaderObj["tipo"];
        datos.Enqueue(new Patente(patente, tipo));
      }
      conexion.Close();
    }

    public void Guardar(string tabla, Queue<Patente> datos)
    {

      ;
      this.comando.CommandType = System.Data.CommandType.Text;
      this.comando.Connection = this.conexion;
      foreach (Patente p in datos)
      {
        string consulta = "Insert into "+tabla+" values('" + p.CodigoPatente.ToString() + "','" + p.TipoCodigo.ToString() + "')";
        this.comando.CommandText = consulta;
        this.conexion.Open();
        comando.ExecuteNonQuery();
      }
      conexion.Close();

    }
  }
}
