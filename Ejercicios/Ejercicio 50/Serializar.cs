using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_50
{
    public class Serializar<T,V>: IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }
        public V Leer()
        {
            V v = (V)Convert.ChangeType("Objeto leido", typeof(V));
            return v;
        }
    }
}
