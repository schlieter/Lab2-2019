using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  public class Class1
  {

    public static void DivideByZero()
    {
      throw new DivideByZeroException();
    }
    public Class1() { }


    public Class1(int a)
    {
      try
      {
        Class1.DivideByZero();
      }
      catch (DivideByZeroException e) { throw e; }
    }

    public Class1(int a,int b)
    {
      try
      {
        new Class1(1);
      }
      catch (Exception ex)
      {
        throw new UnaException("La esesionnnn", ex);
      }
    }

    public void PuntoD()
    {
      try { new Class1(1,2); }
      catch (UnaException e)
      {
        throw new MiException("PuntoD", e);
      }
    }

  }
  public class UnaException : Exception
  {
    public UnaException(string message, Exception ex)
      : base(message, ex)
    {

    }
  }

  public class MiException : Exception
  {
    public MiException(string message, Exception ex)
      : base(message, ex)
    {

    }
  }
}
