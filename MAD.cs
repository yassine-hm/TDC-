using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN
{
    class MAD
    {
        private  double valeur;
        

        public MAD(double v)
        {
            this.valeur = v;
        }

        public void Print()
        {
            Console.WriteLine(this.valeur+" MAD");
        }

       
        public static bool operator >(MAD a, MAD b)
        {
            if (a.valeur > b.valeur) return true;

            return false;
        }

        public static bool operator <(MAD a, MAD b)
        {
            if (a.valeur < b.valeur) return true;

            return false;
        }
        public static MAD operator -(MAD a, MAD b)
        {
            return new MAD(a.valeur - b.valeur);
        }
        public static MAD operator +(MAD a, MAD b)
        {
            return  new MAD(a.valeur + b.valeur);
        }

    }
}
