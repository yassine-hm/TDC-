using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN
{

    class Comptes
    {
        private static int numcmpt =1;
        private  MAD plafond ;  // 
        private int num;
        private Client Cl;
        private MAD solde;

        public Comptes(MAD solde,Client cl,MAD pl)
        {
            this.num = numcmpt++;
            this.Cl = cl;
            this.solde = solde;
            this.plafond = pl;
        }

         public bool  Debiter(MAD somme)
        {
            if (this.solde > somme){
                this.solde = this.solde - somme;
                return true;
            }
            else
            {
                Console.WriteLine("solde insufissant");

            }
            return false;
            
        } 
        public bool Crediter(MAD somme)
        {
                this.solde = this.solde + somme;
                return true;
           
        }
        public bool Verser(Comptes C, MAD somme) {

           if( this.Debiter(somme) && C.Crediter(somme))return true;
            return false;
        
        }
        public void Consulter()
        {
            Console.WriteLine("Numero de Compte " + num + "\n" + Cl.ClientToString() + "\n" + "le solde est : ");
            solde.Print();
        }
       
    }
}
