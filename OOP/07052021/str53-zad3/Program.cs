using System;
using System.Text;

namespace str53_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = Console.ReadLine();
            charArray s = new charArray(tmp);
            Console.Write("Vavedohte niza: ");
            Console.WriteLine(s.el);
            s.Delete(0);
            Console.Write("Iztrih parvata bukva: ");
            Console.WriteLine(s.el);
            s.Insert(0, '@');
            Console.Write("Vmaknah @ v nachaloto: ");
            Console.WriteLine(s.el);
            s.Replace(s.Length - 1, '!');
            Console.Write("Zamenih kraq s !: ");
            Console.WriteLine(s.el);
            Console.Write("Izvadih substringa: ");
            Console.WriteLine(s.SubString(1));
            Console.Write("Izvadih substringa statichno: ");
            Console.WriteLine(charArray.SubString(1, string.Join("", s.el)));
            Console.WriteLine(s.IndexOf("ali"));

        }
    }

    class charArray
    {
        public char[] el;
        public int Length;
        public charArray()
        {
            el = new char[64];
            Length = 0;
        }
        public charArray(int n)
        {
            el = new char[n];
            Length = 0;
        }
        public charArray(string s)
        {

            el = new char[s.Length + 1];
            Length = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                el[i] = s[i];
            }
        }
        public string ToString()
        {
            string res = "";
            for (int i = 0; i < Length; i++)
            {
                res += el[i];
            }
            return res;
        }
        public void Delete(int position)
        {
            if (position < 0 || position > Length || Length == 64)
            {
                throw new Exception("Error");
            }
            for (int i = position; i <= Length - 1; i++)
            {
                el[i] = el[i + 1];
            }
            Length--;
        }
        public void Insert(int position, char item)
        {
            if (position < 0 || position > Length || Length == 64)
            {
                throw new Exception("Error");
            }
            for (int i = Length; i > position; i--)
            {
                el[i] = el[i - 1];
            }
            el[position] = item;
            Length++;

        }
        public void Replace(int position, char item)
        {
            if (position < 0 || position > Length || Length == 64)
            {
                throw new Exception("Error");
            }
            el[position] = item;
        }
        public string SubString(int i)
        {
            StringBuilder sb = new StringBuilder();

            for (int j = i; j < el.Length; j++)
            {
                sb.Append(el[j]);
            }
            return sb.ToString();
        }
        public static string SubString(int i, string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int j = i; j < str.Length; j++)
            {
                sb.Append(str[j]);
            }
            return sb.ToString();
        }
        public int IndexOf(string str)
        {
            int m = str.Length;
            int j;
            for (int i = 0; i <= el.Length - m; i++)
            {
                for ( j = 0; j < m; j++)
                {
                    if (el[i + j] != el[j])
                    {
                        break;
                    }
                }
                    if (j == m)
                    {
                        return i;
                    }
                
            }
            return -1;
        }
    }
}