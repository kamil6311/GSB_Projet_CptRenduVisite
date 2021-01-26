using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    public class Rapport
    {
        public Rapport(int Id, DateTime Date, string Motif, String Bilan, string IdVisiteur, string IdMedecin)
        {
            id = Id;
            date = Date;
            motif = Motif;
            bilan = Bilan;
            idVisiteur = IdVisiteur;
            idMedecin = IdMedecin;
        }
        public Rapport(int Id, DateTime Date, string Motif, String Bilan, Visiteur Visiteur, Medecin Medecin)
        {
            id = Id;
            date = Date;
            motif = Motif;
            bilan = Bilan;
            visiteur = Visiteur;
            medecin = Medecin;
        }

        private int id;
        private DateTime date;
        private string motif;
        private string bilan;
        private string idVisiteur;
        private string idMedecin;

        private Visiteur visiteur;
        private Medecin medecin;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Bilan { get => bilan; set => bilan = value; }
        public string IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public string IdMedecin { get => idMedecin; set => idMedecin = value; }
        public Visiteur Visiteur { get => visiteur; set => visiteur = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
    }
}
