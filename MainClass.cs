using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevtooSergachevTARpv23
{
    public class MainClass
    {
        public static void Main(string[] args)
        
        {
            // ------------------ Ülessane #3 Elanikud ------------------

            /*

            List<Elanikud> elanikud = new List<Elanikud>()
            {
                new Elanikud ("Sergachev", "Bogdan", "Olegovich", "Pushkina 8", new DateTime(2005, 10, 25)),
                new Elanikud ("Tsarev", "Vsevolod", "Dmitrievich", "Pushkina 8", new DateTime (2007, 9, 11)),
                new Elanikud("Sats", "Kirill", "Ivanovich", "UusLinn 21", new DateTime(2007, 7, 25)),
                new Elanikud("Sidorov", "Aleksei", "Aleksejevitš", "Lenini tn 5", new DateTime(1995, 3, 20)),
                new Elanikud("Fedorov", "Fjodor", "Fjodorovitš", "Pushkina tn 12", new DateTime(2000, 9, 30))

            };

            string sihtAadress = "Pushkina 8";

            List<Elanikud> valimisOiguslikudElanikud = elanikud
            .Where(e => e.Aadress == sihtAadress && e.SaadaVanus() >= 18)
            .OrderBy(e => e.Perekonnanimi)
            .ThenBy(e => e.Nimi)
            .ThenBy(e => e.Isanimi)
            .ToList();

            Console.WriteLine($"Valijad aadressil {sihtAadress}:");

            foreach (var elanik in valimisOiguslikudElanikud)
            {
                Console.WriteLine(elanik);
            }

            */

            // ------------------ Ülessane #1 Numbrite jarkestuste kontrollija ------------------

            List<int> numbrid = new List<int>() {5, 4, 3, 2, 1};

            NumbriteJarjestuseKontrollija kontrollija = new NumbriteJarjestuseKontrollija(numbrid);

            kontrollija.KontrolliJarjekorda();


            // ------------------ Ülessane #2 Numbrite töötlus ------------------

            

            int N = 20;

            Numbtritetootlus numbtritetootlus = new Numbtritetootlus(N);

            // Kuvab massiivi arvud
            numbtritetootlus.NaitaNumbrid();

            // Elementide arvu loendamine väljaspool vahemikku [-10, 10]
            int valjaPoolDiapasooni = numbtritetootlus.LeiaElement(-10, 10);


            // Kuvab resultaat
            Console.WriteLine($"\nElementide arv väljaspool vahemikku [-10, 10]: {valjaPoolDiapasooni}");








        }

    }
}
