using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    public class Famille
    {
        public Famille(string Id, string Libelle)
        {
            id = Id;
            libelle = Libelle;
        }

        

        public string Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        private string id;
        private string libelle;

        public override string ToString()
        {
            return libelle;
        }
    }
}
