using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    public class Visiteur : Personne
    {
        public Visiteur(string Id, string Nom, string Prenom, string Login, string Mdp, string Adresse, string Cp, string Ville, DateTime DateEmbauche)
            :base(Id, Nom, Prenom, Adresse)
        {
            login = Login;
            mdp = Mdp;
            cp = Cp;
            ville = Ville;
            dateEmbauche = DateEmbauche;
        }
        private string login;
        private string mdp;
        private string cp;
        private string ville;
        private DateTime dateEmbauche;

        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }

        public override string ToString()
        {
            return Id + " - " + Prenom + " " + Nom.ToUpper();
        }
    }
}
