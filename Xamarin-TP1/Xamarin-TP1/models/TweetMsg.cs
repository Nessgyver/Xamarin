using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_TP1.models
{
    public class TweetMsg
    {
        private int identifiant;
        private DateTime dateDeCreation;
        private string texte;
        private string nomUtilisateur;
        private string identifiantUtilisateur;
        private string pseudoUtilisateur;

        public int Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }
        public DateTime DateDeCreation
        {
            get { return dateDeCreation; }
            set { dateDeCreation = value; }
        }
        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }
        public string NomUtilisateur
        {
            get { return nomUtilisateur; }
            set { nomUtilisateur = value; }
        }
        public string IdentifiantUtilisateur
        {
            get { return identifiantUtilisateur; }
            set { identifiantUtilisateur = value; }
        }
        public string PseudoUtilisateur
        {
            get { return pseudoUtilisateur; }
            set { pseudoUtilisateur = value; }
        }
    }
}
