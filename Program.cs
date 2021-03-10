using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Client cl1 = new Client("hammoucha", "yassine", "Hay Manar");
            Client cl2 = new Client("hammoucha", "hamza", "Hay Manar");
        
            Comptes C = new Comptes(new MAD(6500), cl1, new MAD(10000));
            Comptes C2 = new Comptes(new MAD(6430) , cl2, new MAD(1200));

            C.Consulter();
            C2.Consulter();

            C.Verser(C2, new MAD(2100));
            Console.WriteLine("\n         Apres les virement:\n");
           
            C.Consulter();
            C2.Consulter();

            Console.ReadKey();

        }
    }
}
