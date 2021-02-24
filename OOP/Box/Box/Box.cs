using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Box
{
    public class Box<T>
    {
        public List<T> box;
        public Box()
        {
            this.box = new List<T>();
        }
        public void Add(T item)
        {
            box.Add(item);
        }
        public void Remove()
        {
            box.RemoveAt(box.Count-1);
        }
    }
}
