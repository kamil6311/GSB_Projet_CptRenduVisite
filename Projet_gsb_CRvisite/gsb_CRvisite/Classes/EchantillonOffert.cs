using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    public class EchantillonOffert
    {
        public EchantillonOffert(Medicament LeMedicament, int Quantite)
        {
            quantite = Quantite;
            leMedicament = LeMedicament;
        }
        private int quantite;
        private Medicament leMedicament;

        public Medicament LeMedicament { get => leMedicament; set => leMedicament = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        public override string ToString()
        {
            return LeMedicament.NomCommercial + " " + quantite;
        }
    }
}
