﻿/***************************************
 * Nom du Project : Ratio_Counter
 * Auteur : Stéphane Oguey
 * Date 14.12.17
 * Classe : 1M4I1C
 * Version : Visual Studio Pro 2017
 * OS : Win 10 Pro
 * 
 * But : Créer un programme de calcul de Ratio
 ***************************************/
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
            Console.SetWindowSize(150, 50);
            Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
            Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
            Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
            Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
            Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
            Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
            Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
            Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
            Console.WriteLine(@"                                           ░                                                              ");

            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("\nVeuillez entrez votre Pseudo...");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("");
            strPseudo = Console.ReadLine();

            do
            {
                Console.Clear();

                Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                Console.WriteLine(@"                                           ░                                                              ");

                Console.WriteLine("______________________________________________________________________");
                Console.WriteLine("\nPour calculer votre ratio Kill / Mort, tapez [1] !");
                Console.WriteLine("Pour calculer votre ratio de Partie Gagnée / Partie Perdu, tapez [2] !");
                Console.WriteLine("Pour voir le récapitulatif, tapez [3] !");
                Console.WriteLine("Pour quitter le programme, tapez [4] !");
                Console.WriteLine("______________________________________________________________________");

                cChoixProg = Console.ReadKey().KeyChar;

                switch (cChoixProg)
                {
                    case '1':
                        char cNouvPartie;
                        char cQuitteFonc = 'n';

                        Console.Clear();

                        Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                        Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                        Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                        Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                        Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                        Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                        Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                        Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                        Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                        Console.WriteLine(@"                                           ░                                                              ");

                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
                        cNouvPartie = Console.ReadKey().KeyChar;

                        if (cNouvPartie == 'o')
                        {
                            Console.Clear();

                            Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                            Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                            Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                            Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                            Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                            Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                            Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                            Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                            Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                            Console.WriteLine(@"                                           ░                                                              ");

                            Console.WriteLine("_______________________________________________________");
                            Console.WriteLine("\nCombien de kill avez-vous fait ???");
                            string strNbKillMatch = Console.ReadLine();
                            int iNbKillMatch = Convert.ToInt32(strNbKillMatch);
                            iNbKill += iNbKillMatch;

                            Console.WriteLine("_______________________________________________________");
                            Console.WriteLine("\nCombien de mort avez-vous fait ???");
                            string strNbMortMatch = Console.ReadLine();
                            int iNbMortMatch = Convert.ToInt32(strNbMortMatch);
                            iNbMort += iNbMortMatch;

                            dblRatio_Kill_Mort = (double) iNbKill / iNbMort;

                            Console.Clear();
                        }
                        do
                        {
                            Console.Clear();

                            Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                            Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                            Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                            Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                            Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                            Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                            Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                            Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                            Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                            Console.WriteLine(@"                                           ░                                                              ");

                            Console.WriteLine("_______________________________________________________");
                            Console.WriteLine("\nVotre ratio Kill / Mort est de {0}", Math.Round(dblRatio_Kill_Mort * 100) / 100);
                            Console.WriteLine("\nPressez une touche pour continuer...");
                            Console.ReadKey();

                            Console.Clear();

                            Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                            Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                            Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                            Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                            Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                            Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                            Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                            Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                            Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                            Console.WriteLine(@"                                           ░                                                              ");

                            Console.WriteLine("_______________________________________________________");
                            Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
                            cNouvPartie = Console.ReadKey().KeyChar;

                            if (cNouvPartie == 'o')
                            {
                                Console.Clear();

                                Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                                Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                                Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                                Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                                Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                                Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                                Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                                Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                                Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                                Console.WriteLine(@"                                           ░                                                              ");

                                Console.WriteLine("_______________________________________________________");
                                Console.WriteLine("\nCombien de kill avez-vous fait ???");
                                string strNbKillMatch = Console.ReadLine();
                                int iNbKillMatch = Convert.ToInt32(strNbKillMatch);
                                iNbKill += iNbKillMatch;

                                Console.WriteLine("_______________________________________________________");
                                Console.WriteLine("\nCombien de mort avez-vous fait ???");
                                string strNbMortMatch = Console.ReadLine();
                                int iNbMortMatch = Convert.ToInt32(strNbMortMatch);
                                iNbMort += iNbMortMatch;

                                dblRatio_Kill_Mort = (double) iNbKill / iNbMort;

                                Console.Clear();
                            }
                            if (cNouvPartie == 'n')
                            {
                                Console.Clear();

                                Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                                Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                                Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                                Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                                Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                                Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                                Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                                Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                                Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                                Console.WriteLine(@"                                           ░                                                              ");

                                Console.WriteLine("_______________________________________________________");
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

                        Console.Clear();

                        Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                        Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                        Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                        Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                        Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                        Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                        Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                        Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                        Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                        Console.WriteLine(@"                                           ░                                                              ");

                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
                        cNouvPartie = Console.ReadKey().KeyChar;

                        if (cNouvPartie == 'o')
                        {
                            Console.Clear();

                            Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                            Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                            Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                            Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                            Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                            Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                            Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                            Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                            Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                            Console.WriteLine(@"                                           ░                                                              ");

                            Console.WriteLine("_______________________________________________________");
                            Console.WriteLine("\nCombien de Manche Gagnée avez-vous fait ???");
                            string strNbGagnéeMatch = Console.ReadLine();
                            int iNbGagnéeMatch = Convert.ToInt32(strNbGagnéeMatch);
                            iNbGagnée += iNbGagnéeMatch;

                            Console.WriteLine("_______________________________________________________");
                            Console.WriteLine("\nCombien de Manche Perdue avez-vous fait ???");
                            string strNbPerdueMatch = Console.ReadLine();
                            int iNbPerdueMatch = Convert.ToInt32(strNbPerdueMatch);
                            iNbPerdue += iNbPerdueMatch;

                            dblRatio_Gagnée_Perdue = (double) iNbGagnée / iNbPerdue;

                            Console.Clear();
                        }
                        do
                        {
                            Console.Clear();

                            Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                            Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                            Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                            Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                            Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                            Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                            Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                            Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                            Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                            Console.WriteLine(@"                                           ░                                                              ");

                            Console.WriteLine("_______________________________________________________");
                            Console.WriteLine("\nVotre ratio Manche Gagnée / Manche Perdue est de {0}", Math.Round(dblRatio_Gagnée_Perdue * 100) / 100);
                            Console.WriteLine("\nPressez une touche pour continuer...");
                            Console.ReadKey();

                            Console.Clear();

                            Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                            Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                            Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                            Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                            Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                            Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                            Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                            Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                            Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                            Console.WriteLine(@"                                           ░                                                              ");

                            Console.WriteLine("_______________________________________________________");
                            Console.WriteLine("\nAvez-vous jouez une nouvelle partie [o/n]");
                            cNouvPartie = Console.ReadKey().KeyChar;

                            if (cNouvPartie == 'o')
                            {
                                Console.Clear();

                                Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                                Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                                Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                                Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                                Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                                Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                                Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                                Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                                Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                                Console.WriteLine(@"                                           ░                                                              ");

                                Console.WriteLine("_______________________________________________________");
                                Console.WriteLine("\nCombien de Manche Gagnée avez-vous fait ???");
                                string strNbGagnéeMatch = Console.ReadLine();
                                int iNbGagnéeMatch = Convert.ToInt32(strNbGagnéeMatch);
                                iNbGagnée += iNbGagnéeMatch;

                                Console.WriteLine("_______________________________________________________");
                                Console.WriteLine("\nCombien de Manche Perdue avez-vous fait ???");
                                string strNbPerdueMatch = Console.ReadLine();
                                int iNbPerdueMatch = Convert.ToInt32(strNbPerdueMatch);
                                iNbPerdue += iNbPerdueMatch;

                                dblRatio_Gagnée_Perdue = (double)iNbGagnée / iNbPerdue;

                                Console.Clear();
                            }
                            if (cNouvPartie == 'n')
                            {
                                Console.Clear();

                                Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                                Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                                Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                                Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                                Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                                Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                                Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                                Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                                Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                                Console.WriteLine(@"                                           ░                                                              ");

                                Console.WriteLine("_______________________________________________________");
                                Console.WriteLine("\nVoulez-vous quitter le programme de calcul de Ratio Gagnée/Perdue [o/n] ???");
                                cQuitteFonc = Console.ReadKey().KeyChar;
                            }
                            Console.Clear();
                        }
                        while (!(cQuitteFonc == 'o'));
                        break;

                    case '3':
                        Console.Clear();

                        Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                        Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                        Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                        Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                        Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                        Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                        Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                        Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                        Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                        Console.WriteLine(@"                                           ░                                                              ");

                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("{0},",strPseudo);
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("Nombre de Kill : {0}", iNbKill);
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Nombre de Mort : {0}", iNbMort);
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Nombre de Manche Gagnée : {0}", iNbGagnée);
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Nombre de Manche Perdue : {0}", iNbPerdue);
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("Votre Ratio de Kill / Mort est de {0}", Math.Round(dblRatio_Kill_Mort*100)/100);
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Votre Ratio Manche Gagnée / Manche Perdue est de {0}", Math.Round(dblRatio_Gagnée_Perdue*100)/100);
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine("\nPressez une touche pour continuer...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '4':
                        Console.Clear();

                        Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                        Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                        Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                        Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                        Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                        Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                        Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                        Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                        Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                        Console.WriteLine(@"                                           ░                                                              ");

                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("\nVoulez-vous vraiment quitter le programme [o/n] ???");
                        cQuitteProg = Console.ReadKey().KeyChar;

                        if (cQuitteProg == 'o')
                        {
                            Console.Clear();

                            Console.WriteLine(@" ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████      ▄████▄   ▒█████   █    ██  ███▄    █ ▄▄▄█████▓▓█████  ██▀███  ");
                            Console.WriteLine(@"▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒   ▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                            Console.WriteLine(@"▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒   ▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                            Console.WriteLine(@"▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░   ▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                            Console.WriteLine(@"░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░   ▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                            Console.WriteLine(@"░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                            Console.WriteLine(@"  ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░      ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░  ░▒ ░ ▒░");
                            Console.WriteLine(@"  ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░        ░ ░ ░ ▒   ░░░ ░ ░    ░   ░ ░   ░         ░     ░░   ░ ");
                            Console.WriteLine(@"   ░           ░  ░         ░      ░ ░     ░ ░          ░ ░     ░              ░             ░  ░   ░     ");
                            Console.WriteLine(@"                                           ░                                                              ");

                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("\n_________________Aurevoir..._______________");
                            Console.WriteLine("\n___________________________________________");
                            System.Threading.Thread.Sleep(2000);
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
