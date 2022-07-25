using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGraAsync
{
    public static class Sets
    {
        public static void SetOne()
        {
            List<int> set1 = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var item in set1)
            {
                Console.WriteLine("Number {0} from {1}", item, nameof(set1));
            }
        }

        public static void SetTwo()
        {
            List<int> set2 = new List<int> { 6, 7, 8, 9, 10 };

            foreach (var item in set2)
            {
                Console.WriteLine("Number {0} from {1}", item, nameof(set2));
            }
        }

        public static void SetThree()
        {
            List<int> set3 = new List<int> { 11, 12, 13, 14, 15 };

            foreach (var item in set3)
            {
                Console.WriteLine("Number {0} from {1}", item, nameof(set3));
            }
        }
        public static void RunAllSetsParallel()
        {
            Parallel.Invoke(

                () =>
                {
                    SetThree();
                },

                () =>
                {
                    SetTwo();
                },
                () =>
                {
                    SetOne();
                }
                );
        }
    }
}
