using System;
using System.Threading;

namespace _1ex
{
    //Задача 1: Опитайте да премахнете извикането на.Join() метода.Как се променя програмата?
    //  Отговор: Thread.Join() метода служи за изчакване да приключи дадена нишка, преди започването 
    //  на друга => При премахването на метода започват да работят всички нишки едновременно и програмата не 
    //  работи по предназначение и двамата състезатели не изчакват обратния брояч да приключи, а
    //  почват веднага след него да се състезават

    public class Program
    {
        public static void Main(string[] args)
        {
            Thread countdown = new Thread(new ThreadStart(() =>
            {
                new CountingThread().CountDown(10);
            }));
            Thread racerl = new Thread(new ThreadStart(() =>
            {
                RacerThread racerl = new RacerThread();
                racerl.Race(100);
            }));
            Thread racer2 = new Thread(new ThreadStart(() =>
            {
                RacerThread racer2 = new RacerThread();
                racer2.Race(100);
            }));

            countdown.Start();
            //countdown.Join();
            racerl.Start();
            racer2.Start();

                        
        }
    }
}
