using System;
using System.Threading;

namespace Homework150421
{
    class Program
    {
        static void Main()

        {

            // Размер на масива:

            int size = 20;

            // Създаване на масива:

            char[] symbs = new char[size];

            // Запълване на масива със „звездички”:

            for (int k = 0; k < symbs.Length; k++)

            {

                symbs[k] = '*';

                Console.WriteLine("/" + symbs[k]);

            }

            Console.Write("/");

            // Индекс на първия и последния елемент в масива:

            int first = 0, second = symbs.Length - 1;

            // Обектни променливи за нишките:

            Thread a, b;

            // Създаване на обект за първата нишка:

             a = new Thread(() =>
            {

                // Начален символ за запълване на масива:

                char start = 'Я';

                // Безкраен цикъл:

                while (true)

                {

                    // Ако вторият индекс е по-голям от първия:

                    if (second > first)

                    {

                        // Стойност на елемента:

                        symbs[second] = start;

                        // Нов символ за присвояване:

                        start--;

                        // Нова стойност на индекса:

                        second--;

                        // Задържане изпълнението на нишката:

                        Thread.Sleep(100);

                    }

                    // Ако вторият индекс не е по-голям от първия:

                    else

                    {

                        // Прекратяване изпълнението на нишката:

                        Thread.CurrentThread.Abort();
                        break;

                    }

                }

            });

            // Създаване на обект за втората нишка:

            b = new Thread(() =>
            {

                // Начален символ за запълване на масива:

                char start = 'A';

                // Безкраен цикъл:

                while (true)

                {

                    // Ако първият индекс е по-малък от втория:

                    if (first < second)

                    {

                        // Стойност на елемента:

                        symbs[first] = start;

                        // Нов символ за присвояване:

                        start++;

                        // Нова стойност на индекса:

                        first++;

                        // Задържане изпълнението на нишката:

                        Thread.Sleep(100);

                    }

                    // Ако първият индекс не е по-малък от втория:

                    else

                    {

                        // Прекратяване изпълнението на нишката:

                        Thread.CurrentThread.Abort();
                        break;

                    }

                }

            });

            // Стартиране на първата нишка:

            a.Start();

            // Стартиране на втората нишка:

            b.Start();

            // Изчакване изпълнението на първата нишка:

            if (a.IsAlive) a.Join();

            // Изчакване изпълнението на втората нишка:

            if (b.IsAlive) b.Join();

            // Показване съдържанието на масива:

            for (int k = 0; k < symbs.Length; k++)

            {

                Console.Write("/" + symbs[k]);

            }

            Console.WriteLine("/");

        }
    }
}
