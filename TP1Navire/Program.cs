using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Navire
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TesterInstanciations();

            Console.ReadKey();

        }

        public static void TesterInstanciations()
        {
            //déclaration de l'objet unNavirede la classe Navire
            Navire unNavire;

            //Instanciation de l'objet
            unNavire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbure", 156827);
            Affiche(unNavire);

            //déclaration et instanciation d'un autre objet de la classe Navire
            Navire unAutreNavire = new Navire("IMO09839272", "MSc Isabella", "Porte-Conteneurs", 197500);
            Affiche(unAutreNavire);

            // ??
            unAutreNavire = new Navire("IMO8715871", "MSC PILAR");
            Affiche(unAutreNavire);

        }

        static string Affiche(Navire navire)
        {
            return navire.ToString();
        }

    }
}
