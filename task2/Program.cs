using System;

namespace task2
{
    class Program
    {
        public static int[] CountSheeps(string[] sheeps)
        {
            int totalTrue = 0;
            int totalFalse = 0;
            int totalUnknown = 0;

            foreach (var sheep in sheeps)
            {
                if (sheep == "true")
                    totalTrue++;
                else if (sheep == "false")
                    totalFalse++;
                else
                    totalUnknown++;

            }
            int[] total = { totalTrue, totalFalse, totalUnknown };
            return total;
        }
        static void Main(string[] args)
        {
            string[] sheeps = new string[6];
            int j;
            Console.WriteLine("Enter 6 sheeps presence true/false");

            for (j = 0; j < 6; j++)
            {
                Console.Write($"Sheep {j + 1}: ");
                sheeps[j] = Console.ReadLine();
            }

            var count = CountSheeps(sheeps);
            Console.WriteLine("{0} are present", count[0]);
            Console.WriteLine("{0} are absent", count[1]);
            Console.WriteLine("{0} presence unknown", count[2]);
        }
    }
}
