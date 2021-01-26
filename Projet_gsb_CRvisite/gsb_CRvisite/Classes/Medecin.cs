using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    public class Medecin : Personne
    {
        public Medecin(string Id, string Nom, string Prenom, string Adresse, string Tel, int Departement, Specialite LaSpecialite)
            : base(Id, Nom, Prenom, Adresse)
        {
            tel = Tel;
            departement = Departement;
            specialite = Specialite;
        }
        public Medecin(string Id, string Nom, string Prenom, string Adresse, string Tel, int Departement)
            : base(Id, Nom, Prenom, Adresse)
        {
            tel = Tel;
            departement = Departement;
        }
        private string tel;
        private int departement;
        private Specialite specialite;

        public int Departement { get => departement; set => departement = value; }
        public Specialite Specialite { get => specialite; set => specialite = value; }
        public string Tel { get => tel; set => tel = value; }

        public override string ToString()
        {
            return Id + " - " + Nom.ToUpper() + " " + Prenom;
        }
    }
}
