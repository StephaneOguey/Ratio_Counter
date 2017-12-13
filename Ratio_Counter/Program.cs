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
            string strPseudo = "Anonyme";
            double dblRatio_Gagnée_Perdue = 0;
            int iNbGagnée = 0;
            int iNbPerdue = 0;
            double dblRatio_Kill_Mort = 0;
            int iNbKill = 0;
            int iNbMort = 0;
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
                        char cNouvPartie;
                        char cQuitteFonc = 'n';

                        Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
                        cNouvPartie = Console.ReadKey().KeyChar;

                        if (cNouvPartie == 'o')
                        {
                            Console.WriteLine("\nCombien de kill avez-vous fait ???");
                            string strNbKillMatch = Console.ReadLine();
                            int iNbKillMatch = Convert.ToInt32(strNbKillMatch);
                            iNbKill += iNbKillMatch;

                            Console.WriteLine("\nCombien de mort avez-vous fait ???");
                            string strNbMortMatch = Console.ReadLine();
                            int iNbMortMatch = Convert.ToInt32(strNbMortMatch);
                            iNbMort += iNbMortMatch;

                            dblRatio_Kill_Mort = (double) iNbKill / iNbMort;

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
                                int iNbKillMatch = Convert.ToInt32(strNbKillMatch);
                                iNbKill += iNbKillMatch;

                                Console.WriteLine("\nCombien de mort avez-vous fait ???");
                                string strNbMortMatch = Console.ReadLine();
                                int iNbMortMatch = Convert.ToInt32(strNbMortMatch);
                                iNbMort += iNbMortMatch;

                                dblRatio_Kill_Mort = (double) iNbKill / iNbMort;

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
                        break;



                    case '2':
                        cNouvPartie = 'n';
                        cQuitteFonc = 'n';


                        Console.WriteLine("\nEntrez votre Pseudo :");
                        strPseudo = Console.ReadLine();

                        Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
                        cNouvPartie = Console.ReadKey().KeyChar;

                        if (cNouvPartie == 'o')
                        {
                            Console.WriteLine("\nCombien de Manche Gagnée avez-vous fait ???");
                            string strNbGagnéeMatch = Console.ReadLine();
                            int iNbGagnéeMatch = Convert.ToInt32(strNbGagnéeMatch);
                            iNbGagnée += iNbGagnéeMatch;

                            Console.WriteLine("\nCombien de Manche Perdue avez-vous fait ???");
                            string strNbPerdueMatch = Console.ReadLine();
                            int iNbPerdueMatch = Convert.ToInt32(strNbPerdueMatch);
                            iNbPerdue += iNbPerdueMatch;

                            dblRatio_Gagnée_Perdue = (double) iNbGagnée / iNbPerdue;

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
                                int iNbGagnéeMatch = Convert.ToInt32(strNbGagnéeMatch);
                                iNbGagnée += iNbGagnéeMatch;

                                Console.WriteLine("\nCombien de Manche Perdue avez-vous fait ???");
                                string strNbPerdueMatch = Console.ReadLine();
                                int iNbPerdueMatch = Convert.ToInt32(strNbPerdueMatch);
                                iNbPerdue += iNbPerdueMatch;

                                dblRatio_Gagnée_Perdue = (double)iNbGagnée / iNbPerdue;

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
                        break;

                    case '3':
                        Console.WriteLine("\n=======================================================");
                        Console.WriteLine("Votre Ratio de Kill / Mort est de {0}", dblRatio_Kill_Mort);
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Votre Ratio Manche Gagnée / Manche Perdue est de {0}", dblRatio_Gagnée_Perdue);
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("\nPressez une touche pour continuer...");
                        Console.ReadKey();
                        Console.Clear();
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

    }
}
