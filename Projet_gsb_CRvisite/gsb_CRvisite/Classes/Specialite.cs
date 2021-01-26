using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    public class Specialite
    {
        public Specialite(string Id, string Spe)
        {
            id = Id;
            spe = Spe;
        }

        private string id;
        private string spe;

        public string Id { get => id; set => id = value; }
        public string Spe { get => spe; set => spe = value; }
    }
}
