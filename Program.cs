using System;

namespace ConsoleSet
{
    class Program
    {
        private static Random rng = new Random();
        static void Main(string[] args)
        {
            Test1();
        }

        private static void Test1()
        {
            MySet<int> ms1 = new MySet<int>();
            MySet<int> ms2 = new MySet<int>();

            for (int i = 0; i < 50; i++)
            {
                ms1.Add(rng.Next(20, 51));
                ms2.Add(rng.Next(20, 51));
            }

            PrintList(ms1);
            PrintList(ms2);

            MySet<int> wpjdaw = new MySet<int>();
            wpjdaw.AddRange(ms1.Intersect(ms2));
            PrintList(wpjdaw);
            
        }

        private static void PrintList(MySet<int> nogetandet)
        {
            nogetandet.Sort(); //BROKE
            foreach (var item in nogetandet)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}
