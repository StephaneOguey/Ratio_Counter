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
            char cQuitteProg = 'n';
            do
            {
                Console.WriteLine("Pour calculer votre ratio Kill / Mort, tapez [1] !");
                Console.WriteLine("Pour calculer votre ratio de Partie Gagnée / Partie Perdu, tapez [2] !");
                Console.WriteLine("Pour voir le récapitulatif, tapez [3] !");
                Console.WriteLine("Pour quitter le programme, tapez [4] !");

                cChoixProg = Console.ReadKey().KeyChar;

                switch (cChoixProg)
                {
                    case '1':
                        Ratio_Kill_Mort();
                        break;

                    case '2':
                        Ratio_Manche_Gagnée_Perdue();
                        break;

                    case '3':
                        Recap();
                        break;
                    case '4':
                        Console.WriteLine("\nVoulez-vous vraiment quitter le programme [o/n] ???");
                        cQuitteProg = Console.ReadKey().KeyChar;

                        if (cQuitteProg == 'o')
                        {
                            Console.WriteLine("\nAurevoir...");
                            System.Threading.Thread.Sleep(5000);
                            Environment.Exit(0);
                        }
                        Console.Clear();
                        break;
                }
            }
            while (!(cQuitteProg == 0));
        }
        static double Ratio_Kill_Mort()
        {
            char cNouvPartie;
            char cQuitteFonc = 'n';
            double dblRatio_Kill_Mort = 0;
            double dblNbKill = 0;
            double dblNbMort = 0;

            Console.WriteLine("\nEntrez votre Pseudo :");
            string strPseudo = Console.ReadLine();

            Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
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
                Console.WriteLine("\nVotre Ratio de la journée est de {0}", dblRatio_Kill_Mort);
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
                    Console.WriteLine("\nVoulez-vous quitter le programme de calcul de Ratio Kill/Mort [o/n] ???");
                    cQuitteFonc = Console.ReadKey().KeyChar;
                }
                Console.Clear();
            }
            while (!(cQuitteFonc == 'o'));

            return dblRatio_Kill_Mort;
        }
        static double Ratio_Manche_Gagnée_Perdue()
        {
            char cNouvPartie;
            char cQuitteFonc = 'n';
            double dblRatio_Gagnée_Perdue = 0;
            double dblNbGagnée = 0;
            double dblNbPerdue = 0;

            Console.WriteLine("\nEntrez votre Pseudo :");
            string strPseudo = Console.ReadLine();

            Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
            cNouvPartie = Console.ReadKey().KeyChar;

            if (cNouvPartie == 'o')
            {
                Console.WriteLine("\nCombien de Manche Gagnée avez-vous fait ???");
                string strNbGagnéeMatch = Console.ReadLine();
                double dblNbGagnéeMatch = Convert.ToDouble(strNbGagnéeMatch);
                dblNbGagnée += dblNbGagnéeMatch;

                Console.WriteLine("\nCombien de Manche Perdue avez-vous fait ???");
                string strNbPerdueMatch = Console.ReadLine();
                double dblNbPerdueMatch = Convert.ToDouble(strNbPerdueMatch);
                dblNbPerdue += dblNbPerdueMatch;

                dblRatio_Gagnée_Perdue = dblNbGagnée / dblNbPerdue;

                Console.Clear();
            }
            do
            {
                Console.WriteLine("\nVotre Ratio de la journée est de {0}", dblRatio_Gagnée_Perdue);
                Console.WriteLine("\nPressez une touche pour continuer...");
                Console.ReadKey();

                Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
                cNouvPartie = Console.ReadKey().KeyChar;

                if (cNouvPartie == 'o')
                {
                    Console.WriteLine("\nCombien de Manche Gagnée avez-vous fait ???");
                    string strNbGagnéeMatch = Console.ReadLine();
                    double dblNbGagnéeMatch = Convert.ToDouble(strNbGagnéeMatch);
                    dblNbGagnée += dblNbGagnéeMatch;

                    Console.WriteLine("\nCombien de Manche Perdue avez-vous fait ???");
                    string strNbPerdueMatch = Console.ReadLine();
                    double dblNbPerdueMatch = Convert.ToDouble(strNbPerdueMatch);
                    dblNbPerdue += dblNbPerdueMatch;

                    dblRatio_Gagnée_Perdue = dblNbGagnée / dblNbPerdue;

                    Console.Clear();
                }
                if (cNouvPartie == 'n')
                {
                    Console.WriteLine("\nVoulez-vous quitter le programme de calcul de Ratio Gagnée/Perdue [o/n] ???");
                    cQuitteFonc = Console.ReadKey().KeyChar;
                }
                Console.Clear();
            }
            while (!(cQuitteFonc == 'o'));
            return dblRatio_Gagnée_Perdue;
        }
        static double Recap()
        {
            Console.WriteLine("\n============================0==========================");
            Console.WriteLine("Votre Ratio de Kill / Mort est de {0}",Ratio_Kill_Mort());
            Console.WriteLine("=======================================================");
            Console.WriteLine("Votre Ratio Manche Gagnée / Manche Perdue est de {0}",Ratio_Manche_Gagnée_Perdue());
            Console.WriteLine("=======================================================");
            Console.WriteLine("\nPressez une touche pour continuer...");
            Console.ReadKey();
            Console.Clear();

            return (0);
        }
    }
}
