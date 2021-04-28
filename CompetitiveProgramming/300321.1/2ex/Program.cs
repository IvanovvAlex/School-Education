using System;
using System.Threading;

namespace _1ex
{
    //Задача 2: Какво е предназначението на програмата от примера ?
    //  Отговор: Задачата е нещо като малка игра... Стартира се нишка обратен брояч, след приключването и
    //  започват двама състезателя (две нишки) да се "състезават", коя първа ще "мине" дистанцията от 
    //  100 (метра сигурно)
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
            countdown.Join();
            racerl.Start();
            racer2.Start();                      
        }
    }
}
