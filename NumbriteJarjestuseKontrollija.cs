using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevtooSergachevTARpv23
{
    public class NumbriteJarjestuseKontrollija
    {
        public List<int> Numbrid { get; set; }

        public NumbriteJarjestuseKontrollija(List<int> numbrid) 
        {
            Numbrid = numbrid;
        }

        // проверка того, находится ли последовательность в порядке возрастания
        // kontrollides, kas jada on kasvavas järjekorras

        public bool OnKasvav()
        {
            for (int i = 0; i < Numbrid.Count - 1; i++)
            {
                if (Numbrid[i] > Numbrid[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
        // проверка того, находится ли последовательность в порядке убывания
        // kontrollida, kas jada on kahanevas järjekorras
        public bool OnKahanev()
        {
            for (int i = 0; i < Numbrid.Count - 1; i++)
            {
                if (Numbrid[i] < Numbrid[i + 1])
                {
                    return false;
                }

            }

            return true;

        }


        // установка последовательности
        // seadistusjärjestus
        public void KontrolliJarjekorda()
        {
            if (OnKasvav())
            {
                Console.WriteLine("Massiiv on järjestatud kasvavas järjekorras.");
            }
            else if (OnKahanev())
            {
                Console.WriteLine("Massiiv on järjestatud kahanevas järjekorras.");
            }
            else
            {
                Console.WriteLine("Massiiv ei ole järjestatud.");
            }
        }

    }
}
