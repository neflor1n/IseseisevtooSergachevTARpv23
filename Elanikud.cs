using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevtooSergachevTARpv23
{
    public class Elanikud
    {
        public string Perekonnanimi { get; set; }
        public string Nimi { get; set; }
        public string Isanimi { get; set; }
        public string Aadress { get; set; }
        public DateTime Sunnikuupaev { get; set; }

        public Elanikud (string perekonnanimi, string nimi, string isanimi, string aadress, DateTime sunnikuupaev)
        {
            Perekonnanimi = perekonnanimi;
            Nimi = nimi;
            Isanimi = isanimi;
            Aadress = aadress;
            Sunnikuupaev = sunnikuupaev;
        }

        public int SaadaVanus()
        {
            return DateTime.Now.Year - Sunnikuupaev.Year - (DateTime.Now.DayOfYear < Sunnikuupaev.DayOfYear ? 1 : 0); 

        }
        // override применяется для переопределения виртуальных методов 
        // override’i kasutatakse virtuaalsete meetodite alistamiseks
        public override string ToString() 
        {
            return $"{Perekonnanimi} {Nimi} {Isanimi}, {Aadress}, {Sunnikuupaev.ToShortDateString()}"; // ToShortDateString () преобразовывает datetime в короткую строковую дату
                                                                                                       // ToShortDateString() teisendab kuupäeva ja kellaaja lühikeseks kuupäevastringiks
        }


    }
}
