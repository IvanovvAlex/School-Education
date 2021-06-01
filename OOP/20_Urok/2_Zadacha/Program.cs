using System;

namespace _2_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class setCharV
    {
        public byte[] elements; 
        public int size; 
                         
        public setCharV()
        {
            size = 0;                      
            elements = new byte[256];      
        }
        public setCharV(byte[] e, int s) 
        {                      
            {
                this.size = s;
                this.elements = new byte[256];
                if (this.size != 0) 
                {
                    for (int i = 0; i < s; i++)
                    {
                        this.elements[e[i]] = 1; 
                    }
                }
            }
        }
        public setCharV(setCharV m)
        {
            this.size = m.size;
            this.elements = new byte[256];
            if (this.size != 0) 
            {
                for (int i = 0; i < 256; i++)
                {
                    this.elements[i] = m.elements[i];
                }                                    
            }
        }
        public setCharV Union(setCharV b) 
        {                                
            setCharV c = new setCharV(); 
            for (int i = 0; i < 256; i++)
            {
                if (this.elements[i] == 1 || b.elements[i] == 1)
                {
                    c.elements[i] = 1;
                    c.size++; 
                }
            }
            return c; 
        }
        public setCharV Intersection(setCharV b)
        {                                       
            setCharV c = new setCharV();        
            for (int i = 0; i < 256; i++)
            {
                if (this.elements[i] == 1 && b.elements[i] == 1) 
                {
                    c.elements[i] = 1;
                    c.size++; 
                }
            }
            return c; 
        }
        public void Print()
        {
            Console.Write("{ ");
            if (size != 0) 
            {
                int i = 0;
                while (this.elements[i] == 0) 
                {
                    i++; 
                } 
                Console.Write("{0}", i); 
                i++;
                for (; i < 256; i++)
                {
                    if (this.elements[i] == 1)
                    {
                        Console.Write(", {0}", i); 
                    }
                }
            }
            Console.WriteLine(" }");
        }
    }
}
