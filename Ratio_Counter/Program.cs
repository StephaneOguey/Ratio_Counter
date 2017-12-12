using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratio_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            char cChoixProg;

            Console.WriteLine("Pour calculer votre ratio Kill / Mort, tapez [1] !");
            Console.WriteLine("Pour calculer votre ratio de Partie Gagnée / Partie Perdu, tapez [2] ");

            cChoixProg = Console.ReadKey().KeyChar;

            switch (cChoixProg)
            {
                case '1':
                    Ratio_Kill_Mort();
                    break;

                case '2':

                    break;

                default:
                    
                    break;
            }
        }
        static double Ratio_Kill_Mort()
        {
            char cNouvPartie;


            Console.WriteLine("Entrez votre Pseudo :");
            string strPseudo = Console.ReadLine();

            Console.WriteLine("Avez-vous jouez une nouvelle partie [o/n]");
            cNouvPartie = Console.ReadKey().KeyChar;

            if (cNouvPartie == 'o')
            {
                Console.WriteLine("Combien de kill avez-vous fait ???");
                string strNbKillMatch = Console.ReadLine();
                double dblNbKillMatch = Convert.ToDouble(strNbKillMatch);


            }
            return ();
        }
    }
}
