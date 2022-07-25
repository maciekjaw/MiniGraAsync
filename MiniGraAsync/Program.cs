using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniGraAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();

            Player p1 = new Player("M", "J");
            Player p2 = new Player("A", "B");
            Player p3 = new Player("T", "D");
            Player p4 = new Player("G", "K");
            Player p5 = new Player("V", "O");
            Player p6 = new Player("G", "S");
            Player p7 = new Player("P", "Z");
            Player p8 = new Player("U", "D");
            Player p9 = new Player("Y", "T");

            var dateTime = DateTime.UtcNow;
            DateTime t = new DateTime();
            var sec = t.Second;
            var mil = t.Millisecond;
            var time = dateTime;

            var start = DateTime.UtcNow;

            Console.WriteLine("Start Time is {0}", start + "" + mil);


            var end = DateTime.UtcNow;
            Console.WriteLine("EndTime is {0}", end + "" + mil);

            Parallel.Invoke(() =>
            {
                Console.WriteLine(dateTime);
                g.ReceiveRandomLeter(p1);
                Console.WriteLine(dateTime);
            },

            () =>
            {
                Console.WriteLine(dateTime);
                g.ReceiveRandomLeter(p2);
                Console.WriteLine(dateTime);
            },

            () =>

            {
                Console.WriteLine(dateTime);
                g.ReceiveRandomLeter(p3);
                Console.WriteLine(dateTime);
            },

            () =>

            {
                Console.WriteLine(dateTime);
                g.ReceiveRandomLeter(p4);
                Console.WriteLine(dateTime);
            },

            () =>
            {
                Console.WriteLine(dateTime);
                g.ReceiveRandomLeter(p5);
                Console.WriteLine(dateTime);
            },

            () =>
            {
                Console.WriteLine(dateTime);
                g.ReceiveRandomLeter(p6);
                Console.WriteLine(dateTime);
            },

            () =>
            {
                Console.WriteLine(dateTime);
                g.ReceiveRandomLeter(p7);
                Console.WriteLine(dateTime);
            },

            () =>
            {
                Console.WriteLine(dateTime);
                g.ReceiveRandomLeter(p8);
                Console.WriteLine(dateTime);
            }

            );
            Console.ReadKey();
        }
    }
}

