using System;
using System.Collections.Generic;

namespace Sjuan___kortspel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, string> > Kortlek = new List<Tuple<int, string> >();

            string colour = "hjärter";
            int colourcount = 1;

            for (int i = 2; i < 15; i++)
            {
                Kortlek.Add(new Tuple<int, string>(i, colour));
                if (i == 14 && Kortlek.Count < 14)
                {
                    i = 1;
                }
            }

            Kortlek.Sort();
            
            for(int i = 0; i < Kortlek.Count; i++)
            {
                Console.WriteLine(Kortlek[i]);
            }

            Console.ReadKey();
           }
    }
}
