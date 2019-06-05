using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_50
{
    public class GuardarTexto<T,V>:IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }
        public V Leer()
        {
            V v = (V)Convert.ChangeType("Texto leido",typeof(V));
            return v;
        }
    }
}
