using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    public class Personne
    {
        public Personne(string Id, string Nom, string Prenom, string Adresse)
        {
            id = Id;
            nom = Nom;
            adresse = Adresse;
            prenom = Prenom;
        }
        private string id;
        private string nom;
        private string adresse;
        private string prenom;

        public string Adresse { get => adresse; set => adresse = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Id { get => id; set => id = value; }

        public override string ToString()
        {
            return Id + " - " + prenom + " " + Nom.ToUpper();
        }
    }
}
