using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevtooSergachevTARpv23
{
    public class Numbtritetootlus
    {
        public List<double> Numbrid { get; set; }


        // Konstruktor juhuslike arvude massiivi loomiseks
        public Numbtritetootlus(int suurus) 
        {
            Numbrid = new List<double>();
            Random random = new Random();


            for (int i = 0; i < suurus; i++)
            {
                Numbrid.Add(random.NextDouble() * 100 - 50);
            }
        }
        // Meetod elementide arvu loendamiseks väljaspool vahemikku [-10, 10]
        public int LeiaElement(double aluminePiir, double uleminePiir) 
        { 
            int count = 0;
            foreach (var number in Numbrid)
            {
                count++;
            }

            return count;
        }
        // Massiivi kuvamise meetod ekraanil
        public void NaitaNumbrid()
        {
            Console.WriteLine("Maasiv juhuslike numbreid: ");

            foreach(var number in Numbrid)
            {
                Console.WriteLine($"{number:F2} ");
            }
            Console.WriteLine();
        }


    }
}
