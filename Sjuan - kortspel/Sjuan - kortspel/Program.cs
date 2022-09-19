using System;
using System.Collections.Generic;
using System.Linq;

namespace Sjuan___kortspel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar Kortlek
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
            
            /*for(int i = 0; i < Kortlek.Count; i++)
            {
                Console.WriteLine(Kortlek[i]);
            }*/

            Console.ReadKey();

            List < Tuple<int, string> > player1 = Sorter(Kortlek);
            List < Tuple<int, string> > player2 = Sorter(Kortlek);
            List < Tuple<int, string> > player3 = Sorter(Kortlek);
            List < Tuple<int, string> > player4 = Sorter(Kortlek);
            for(int i = 0; i < player1.Count; i++)
            {
                Console.WriteLine(player1[i]);
                Console.WriteLine(player2[i]);
            }
            Kortcheck(player1, player2);
            Kortcheck(player1, player3);
            Kortcheck(player1, player4);
            Kortcheck(player2, player3);
            Kortcheck(player2, player4);
            Kortcheck(player3, player4);

            string startingPlayer = "hej";
            if (whoStart(player1) == true) { startingPlayer = "player1"; }
            else if (whoStart(player2) == true) { startingPlayer = "player2"; }
            else if (whoStart(player2) == true) { startingPlayer = "player3"; }
            else if (whoStart(player2) == true) { startingPlayer = "player4"; }
            Console.WriteLine(startingPlayer);
            //spel

        }
        static List<Tuple<int, string>> Sorter(List<Tuple<int, string>> Kortlek)
        {
            List<Tuple<int, string>> Hand = new List<Tuple<int, string>>();

            Random rnd = new Random();
            for (int i = 0; i < 13; i++){
                int rand = rnd.Next(0, Kortlek.Count);
                Hand.Add(Kortlek[rand]);
                Kortlek.Remove(Kortlek[rand]);
            }
            return Hand;
        }

        static bool whoStart(List<Tuple<int, string>>player)
        {
            bool playerstart = false;
            for (int i = 0; i < player.Count; i++)
            {
                Tuple<int, string> hjärter7 = new Tuple<int, string>(7,"hjärter");
                if (player[i] == hjärter7)
                {
                     playerstart = true;
                }
            }
            return playerstart;

        }
        static void Kortcheck(List<Tuple<int, string>>p1, List<Tuple<int, string>>p2)
        {
            int error = 0;
            for(int i = 0; i < p1.Count; i++)
            {
                for(int j = 0; i < p1.Count; i++)
                {
                    if (p1[i] == p2[j])
                    {
                        error++;
                    }
                }
            }
            if(error > 0)
            {
                Console.WriteLine("ERROR COPIES " + error);
            }
            else
            {
                Console.WriteLine("NO COPIES");
            }
        }
            
    }
}
