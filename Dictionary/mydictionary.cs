using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class mydictionary<T, V>
    {
        V[] value;
        T[] keys;
        public mydictionary()
        {
            value = new V[0];
            keys = new T[0];
        }
        // 2 Değiştirilen yerler
        //V[] temp_value;
        //T[] temp_keys;

        public void Add(V val, T ke)
        {
            // 3 Değiştirilen yerler
          V[]  temp_value = this.value;
          T[]  temp_keys = keys;

            keys = new T[keys.Length + 1];
           this.value = new V[this.value.Length + 1];
            //value yerine temp_keys yazılması gerek
            for (int i = 0; i < temp_keys.Length; i++)
            {
                
                    this.value[i] = temp_value[i];
                    keys[i] = temp_keys[i];
                
            }

            this.value[value.Length - 1] = val;
            keys[keys.Length - 1] = ke;
        }

        //
        public int Count
        {
            get { return keys.Length; }
        }

    }
}