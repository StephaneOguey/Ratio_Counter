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
            Console.WriteLine("Pour calculer votre ratio de Partie Gagnée / Partie Perdu, tapez [2] !");
            Console.WriteLine("Pour quitter le programme, tapez [3] !");

            cChoixProg = Console.ReadKey().KeyChar;

            switch (cChoixProg)
            {
                case '1':
                    Ratio_Kill_Mort();
                    break;

                case '2':

                    break;

                case '3':
                    
                    break;
            }
            Console.Clear();
        }
        static double Ratio_Kill_Mort()
        {
            char cNouvPartie;
            char cQuitteProg = 'n';
            double dblRatio_Kill_Mort = 0;
            double dblNbKill = 0;
            double dblNbMort = 0;

            Console.WriteLine("\nEntrez votre Pseudo :");
            string strPseudo = Console.ReadLine();

            Console.WriteLine("Avez-vous jouez une nouvelle partie [o/n]");
            cNouvPartie = Console.ReadKey().KeyChar;

            if (cNouvPartie == 'o')
            {
                Console.WriteLine("\nCombien de kill avez-vous fait ???");
                string strNbKillMatch = Console.ReadLine();
                double dblNbKillMatch = Convert.ToDouble(strNbKillMatch);
                dblNbKill += dblNbKillMatch;

                Console.WriteLine("\nCombien de mort avez-vous fait ???");
                string strNbMortMatch = Console.ReadLine();
                double dblNbMortMatch = Convert.ToDouble(strNbMortMatch);
                dblNbMort += dblNbMortMatch;

                dblRatio_Kill_Mort = dblNbKill / dblNbMort;

                Console.Clear();
            }
            do
            {
                Console.WriteLine("Votre Ratio de la journée est de {0}",dblRatio_Kill_Mort);
                Console.WriteLine("\nPressez une touche pour continuer...");
                Console.ReadKey();

                Console.WriteLine("Avez-vous jouez une nouvelle partie [o/n]");
                cNouvPartie = Console.ReadKey().KeyChar;

                if (cNouvPartie == 'o')
                {
                    Console.WriteLine("\nCombien de kill avez-vous fait ???");
                    string strNbKillMatch = Console.ReadLine();
                    double dblNbKillMatch = Convert.ToDouble(strNbKillMatch);
                    dblNbKill += dblNbKillMatch;

                    Console.WriteLine("\nCombien de mort avez-vous fait ???");
                    string strNbMortMatch = Console.ReadLine();
                    double dblNbMortMatch = Convert.ToDouble(strNbMortMatch);
                    dblNbMort += dblNbMortMatch;

                    dblRatio_Kill_Mort = dblNbKill / dblNbMort;

                    Console.Clear();
                }
                if (cNouvPartie == 'n')
                {
                    Console.WriteLine("Voulez-vous quitter le programme de calcul de Ratio Kill/Mort [o/n] ???");
                    cQuitteProg = Console.ReadKey().KeyChar;
                }
            }
            while (!(cQuitteProg == 'o'));

            return dblRatio_Kill_Mort;
        }
    }
}
