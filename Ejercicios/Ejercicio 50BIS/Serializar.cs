using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_50
{
    public class Serializar<S,V>: IGuardar<S,V>
    {
        public bool Guardar(S obj)
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
