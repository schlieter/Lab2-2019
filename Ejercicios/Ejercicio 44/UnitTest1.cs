using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_40;
using Ejercicio_41;

namespace Ejercicio_44
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestListaDeLlamadas()
    {
      Centralita c1 = new Centralita();
      //Assert.AreNotEqual(null, c1.Llamadas);//EQUIVALE A LO DE ABAJO
      if (c1.Llamadas == null)
      {
        Assert.Fail();
      }
    }

    [TestMethod]
    [ExpectedException(typeof(CentralitaException))]
    public void TestCentralitaException()
    {
      /*try
      {
        Centralita c1 = new Centralita("Telefonica");
        Provincial p1 = new Provincial("UTN", Provincial.Franja.Franja_1, 0.9f, "Mendoza");
        Provincial p2 = new Provincial("UTN", Provincial.Franja.Franja_2, 0.8f, "Mendoza");
        c1 += p1;
        c1 += p2;
        Assert.Fail();
      }
      catch (CentralitaException e) { }
      catch(Exception) { Assert.Fail(); }*/
      /////////////////////////////////////////
      
        Centralita c1 = new Centralita("Telefonica");
        Provincial p1 = new Provincial("UTN", Provincial.Franja.Franja_1, 0.9f, "Mendoza");
        Provincial p2 = new Provincial("UTN", Provincial.Franja.Franja_2, 0.8f, "Mendoza");
        c1 += p1;
        c1 += p2;
       
     


    }
  }
}
