using System;

namespace ColorsWithIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ColorsIndexer color = new ColorsIndexer();
                Console.WriteLine("Enter color index");
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine($"  {i} -- {color[i]}");
                }
            }
            //while(ConsoleKeyInfo == ConsoleKey.C)
        }
    }
}
