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

            for (int i = 1; i < 14; i++)
            {
                Kortlek.Add(new Tuple<int, string>(i, colour));
                if (i == 13 && Kortlek.Count < 26)
                {
                    colour = "spader";
                    i = 0;
                }
                if (i == 13 && Kortlek.Count < 38)
                {
                    colour = "ruter";
                    i = 0;
                }
                if (i == 13 && Kortlek.Count < 52)
                {
                    colour = "klöver";
                    i = 0;
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
