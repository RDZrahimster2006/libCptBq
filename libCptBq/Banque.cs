﻿using System;
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
        private List<Type_> mesTypes;
        public List<Compte>Comptes 
        {
        get { return comptes; } 
        set { comptes = value; }
        }

        public List<Type_> MesTypes
        {
            get { return mesTypes; }
            set { mesTypes = value; }
        }

        public Banque()
        {
            comptes = new List<Compte>();
            mesTypes = new List<Type_>();
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

        public void AjouterType(string code, string libelle, char sens)
        {
            this.mesTypes.Add(new Type_(code, libelle, sens));
        }
        public void AjouterType(Type_ unType)
        {
            this.mesTypes.Add(unType);
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
        public Compte RendCompte(int numero)
        {
            foreach (var compte in comptes)
            {
                if (compte.Numero == numero)
                {
                    return compte;
                }
            }
             return null;          
        }
       public string GetTypes(string libelle)
       {   string str = "";
            foreach (var type in mesTypes)
            {
                if (type.Libelle == libelle)
                {
                    str += type.ToString() + "\n";
                }
            }
            return str;
       }
    }
}
