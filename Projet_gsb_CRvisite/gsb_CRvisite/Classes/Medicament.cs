using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    /// <summary>
    /// Classe Medicament
    /// </summary>
    public class Medicament
    {
        public Medicament(string Id, string NomCommercial, string Composition, string Effets, string Contreindications)
        {
            id = Id;
            nomCommercial = NomCommercial;
            composition = Composition;
            effets = Effets;
            contreindications = Contreindications;
        }
        public Medicament(string Id, string NomCommercial, string Composition, string Effets, string Contreindications, Famille Famille)
        {
            id = Id;
            nomCommercial = NomCommercial;
            composition = Composition;
            effets = Effets;
            contreindications = Contreindications;
            this.Famille = Famille;
        }

        public string Effets { get => effets; set => effets = value; }
        public string Id { get => id; set => id = value; }
        public string NomCommercial { get => nomCommercial; set => nomCommercial = value; }
        public string Composition { get => composition; set => composition = value; }
        public string Contreindications { get => contreindications; set => contreindications = value; }
        public Famille Famille { get => famille; set => famille = value; }

        private string id;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreindications;

        private Famille famille;

        public override string ToString()
        {
            return id + " - " + nomCommercial; 
        }

    }
}
