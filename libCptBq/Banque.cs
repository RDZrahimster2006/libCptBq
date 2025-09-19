using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace libCptBq
{
    public class Banque
    {

        private List<Compte> comptes;
        public List<Compte>Comptes 
        {
        get { return comptes; } 
        set { comptes = value; }
        }

        public Banque()
        {
            comptes = new List<Compte>();
        }
        public void AjouteCompte(Compte c)
        {
            comptes.Add(c);
        }
        public void AjouteCompte(int numero, string nom, decimal solde, decimal decouvertAutorise)
        {
            Compte nouveauCompte = new Compte(numero, nom, solde, decouvertAutorise);
            comptes.Add(nouveauCompte);
        }
        public Compte compteMax()
        {
            if (comptes.Count == 0)
            {
                return null; 
            }
            Compte compteMax = comptes[0];
            foreach (var compte in comptes)
            {
                if (compte.Solde > compteMax.Solde)
                {
                    compteMax = compte;
                }
            }
            return compteMax;
        }
        public override string ToString()
        { 
            string str = "";
            foreach (var Compte in comptes)
            {
                str += Compte.ToString() ;
            }
            return str;
        }
       
    }
}
