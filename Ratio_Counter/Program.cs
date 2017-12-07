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
        }
    }
}
