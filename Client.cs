using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN
{
    class Client
    {
        private static int id = 0;
        private int numeroClient; 
        private string nom; 
        private string prenom;
        private string adresse;

        public Client(string nom,string prenom,string adresse)
        {
            this.numeroClient = ++id;
            this.nom = nom;
            this.prenom= prenom;
            this.adresse = adresse;
        }
        public string ClientToString()
        {
            return "Infos client:\n" + numeroClient + "  " + nom + "  " + prenom + "  " + adresse;
        }

    }
}
