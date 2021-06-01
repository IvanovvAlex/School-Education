using System;

namespace _1_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class SetByte
    {
        public byte[] elements;
        public int size;

        public SetByte()
        {
            this.size = 0;
            this.elements = new byte[256];
        }
        public SetByte(byte[] arr, int length)
        {
            this.size = length;
            this.elements = new byte[256];
            if (this.size != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    this.elements[i] = arr[i];
                }
            }
            Array.Sort(this.elements, 0, length);
        }
        public SetByte(SetByte setByte)
        {
            this.size = setByte.size;
            this.elements = new byte[256];
            if (size != 0)
            {
                for (int i = 0; i < setByte.size; i++)
                {
                    this.elements[i] = setByte.elements[i];
                }
            }
        }
        public SetByte Union(SetByte b)
        {
            SetByte c = new SetByte();
            int n1 = 0;
            int n2 = 0;
            int n = -1;
            int i;

            while (n1 < this.size && n2 < b.size)
            {
                if (this.elements[n1] <= b.elements[n2]) 
                {
                    c.elements[++n] = this.elements[n1++];
                }
                else
                {
                    c.elements[++n] = b.elements[n2++];
                }
                if (this.elements[n1] == b.elements[n2])
                {
                    n2++;
                }
            }
            if (n1 == this.size)
            {
                for ( i = n2; i < b.size; i++)
                {
                    c.elements[++n] = b.elements[i];
                }
            }
            else
            {
                for ( i = n1; i < this.size; i++)
                {
                    c.elements[++n] = this.elements[i];
                }
            }
            c.size = (byte)(n + 1);
            return c;
        }
        public SetByte Intersection(SetByte b)
        {
            SetByte c = new SetByte();
            int n1 = 0;
            int n2 = 0;
            int n = -1;
            int i;
            while (n1 < this.size && n2 < b.size)
            {
                if (this.elements[n1] < b.elements[n2])
                {
                    n1++;
                }
                else if (this.elements[n1] > b.elements[n2])
                {
                    n2++;
                }
                else
                {
                    c.elements[++n] = this.elements[n1++];
                    n2++;
                }
            }
            c.size = (byte)(n + 1);
            return c;
        }
        public void Print()
        {
            Console.Write("{ ");
            if (this.size != 0)
            {
                for (int i = 0; i < this.size; i++)
                {
                    Console.Write("{0}, ", this.elements[i]);
                }
                Console.Write("{0} ", this.elements[size-1]);
            }
            Console.WriteLine("}");
        }
    }
}
