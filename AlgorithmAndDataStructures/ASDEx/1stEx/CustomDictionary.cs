using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stEx
{
    public class CustomDictionary<K, V>
    {
        static readonly int size = 100;
        internal List<CustomDictionary<K, V>>[] data;

        public CustomDictionary()
        {
            data = new List<CustomDictionary<K, V>>[size];
        }

        public void Add(K key, V value)
        {
            int hash = key.GetHashCode();
            int index = hash % size;

            if (data[index] == null)
            {
                data[index] = new List<CustomDictionary<K, V>>();
                data[index].Add(new Element<K, V>(key, value));
            }
            else
            {
                bool dupe = data[index].Select(item => item.Key).Contains(key);
                if (dupe)
                {
                    throw new InvalidOperationException("Key already exists!");
                }
                else
                {
                    data[index].Add(new Element<K, V>(key, value));
                }
            }
        }

        public V Remove(K key)
        {
            int hash = key.GetHashCode();
            int index = hash % size;

            if (data[index] == null)
            {
                throw new KeyNotFoundException("No such element!");
            }
            else
            {
                bool exists = data[index].Select(item => item.Key).Contains(key);
                if (exists)
                {
                    var pair = data[index].Where(item => item.Key.Equals(key)).FirstOrDefault();
                    data[index].Remove(pair);
                    return pair.Value;
                }
                else
                {
                    throw new KeyNotFoundException("No such element!");
                }
            }
        }

        private CustomDictionary<K, V> Find(K key)
        {
            int hash = key.GetHashCode();
            int index = hash % size;

            if (Contains(key))
            {
                return data[index].Where(item => item.Key.Equals(key)).FirstOrDefault();
            }
            else
            {
                throw new KeyNotFoundException("No such element!");
            }
        }

        public void Change(K key, V value)
        {
            var pair = Find(key);
            pair.Value = value;
        }

        public bool Contains(K key)
        {
            int hash = key.GetHashCode();
            int index = hash % size;

            if (data[index] == null)
            {
                return false;
            }
            else
            {
                return data[index].Select(item => item.Key).Contains(key);
            }
        }

        public V this[K key]
        {
            get { return Find(key).Value; }
            set { Change(key, value); }
        }
    }
}
