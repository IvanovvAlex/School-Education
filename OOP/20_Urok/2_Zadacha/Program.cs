﻿using System;

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
        public byte[] elements; // задаваме, че класа "setCharV" има публично пропърти което е масив от байтове и пропъртито е кръстено elements
        public int size; // задаваме, че класа има публично пропърти което е int (цяло число), пази в себе си размера на масива от първото пропърти
                         // и е кръстено size
        public setCharV()
        {
            size = 0;                      //създаваме празен конструктор, при чиято употреба size-a автоматично ще е равен на 0, а elements ще се създаде
            elements = new byte[256];      // с максималният размер, за байт, който е 256
        }
        public setCharV(byte[] e, int s) //създаваме конструктор, който приема два параметъра, първия е масив от байтове, а втория
        {                       //е размера на масива
            {
                this.size = s;
                this.elements = new byte[256];
                if (this.size != 0) //ако размера е различен от 0 се изпълнява
                {
                    for (int i = 0; i < s; i++)
                    {
                        this.elements[e[i]] = 1; // присвояваме стойностите от подадения масив на настоящия обект, който сме създали
                    }
                }
            }
        }
        public setCharV(setCharV m) //създаваме конструктор, който приема като параметър обект от същия клас и му присвоява стойностите
        {
            this.size = m.size;
            this.elements = new byte[256];
            if (this.size != 0) //ако размера е различен от 0 се изпълнява
            {
                for (int i = 0; i < 256; i++)
                {
                    this.elements[i] = m.elements[i]; // присвоява стойностите от масива "m", Към този който сега сме създали като минава по всеки един елемент от
                }                                    // настоящия масив и го прави равен на съответния му от масива в обект 'm'
            }
        }
        public setCharV Union(setCharV b) //създаваме конструктор, който приема като параметър обект от същия клас, съюзява го с настоящия и връща трети обект 
        {                                 // който е смесица между двата по даден критерий
            setCharV c = new setCharV(); // създаваме обекта 'c'
            for (int i = 0; i < 256; i++)
            {
                if (this.elements[i] == 1 || b.elements[i] == 1) // ако елемента от настояшия масив ИЛИ елемента от масив 'b' е равен на 1
                {
                    c.elements[i] = 1; // присвоява на елемента в масива на обекта 'c' стойност 1, на позиция i
                    c.size++; // size = size + 1 на обект 'c'
                }
            }
            return c; //връща обекта 'c'
        }
        public setCharV Intersection(setCharV b) //създаваме конструктор, който приема като параметър обект от същия клас, съюзява го с настоящия и връща трети обект
        {                                        // който е смесица между двата по даден критерий
            setCharV c = new setCharV();        // създаваме обекта 'c'
            for (int i = 0; i < 256; i++)
            {
                if (this.elements[i] == 1 && b.elements[i] == 1) // ако елемента от настояшия масив И елемента от масив 'b' е равен на 1
                {
                    c.elements[i] = 1; // присвоява на елемента в масива на обекта 'c' стойност 1, на позиция i
                    c.size++; // size = size + 1 на обект 'c'
                }
            }
            return c; //връща обекта 'c'
        }
        public void Print()
        {
            Console.Write("{ ");
            if (size != 0) //ако размера е различен от 0 се изпълнява
            {
                int i = 0;
                while (this.elements[i] == 0) // докато стойността на елемента на позиция i е = 0
                {
                    i++; // i = i + 1
                } 
                Console.Write("{0}", i); //изписваме на същия ред i
                i++;
                for (; i < 256; i++)
                {
                    if (this.elements[i] == 1)
                    {
                        Console.Write(", {0}", i); //изписваме на същия ред i, но със запетая и интервал преди i
                    }
                }
            }
            Console.WriteLine(" }");
        }
    }
}
