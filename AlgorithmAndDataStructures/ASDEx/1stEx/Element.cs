using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stEx
{
    public class Element<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

        public Element(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
