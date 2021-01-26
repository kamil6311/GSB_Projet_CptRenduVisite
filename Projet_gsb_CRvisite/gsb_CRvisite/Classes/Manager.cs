using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_CRvisite.Classes
{
    
    
    class Manager
    {

        
        //Liste des médicaments
        private static List<Medicament> lesMedicaments;

        //Liste des médecins
        private static List<Medecin> lesMedecins;

        //Liste des familles
        private static List<Famille> lesFamilles;

        //Liste des Visiteurs
        private static List<Visiteur> lesVisiteurs;

        //Liste des Visiteurs
        private static List<Int32> lesId;

        public Manager()
        {
        }

        /// <summary>
        /// Charge la liste des médicaments à partir de la base de données
        /// en utilisant la classe Passerelle.cs
        /// </summary>
        /// <returns>la liste des médicaments</returns>
        public static List<Medicament> ChargerMedicaments()
        {
            lesMedicaments = Passerelle.GetLesMedicament();
            return lesMedicaments;
        }

        /// <summary>
        /// Accesseur en lecture pour un médicament
        /// </summary>
        /// <param name="index">l'indice du médicament voulu</param>
        /// <returns>médicament situé à l'indice 'index'</returns>
        public static Medicament GetMedicament(int index)
        {
            return lesMedicaments[index];
        }


        /// <summary>
        /// Accesseur en lecture pour une famille de médicament
        /// </summary>
        /// <param name="medicament">medicament de la famille voulu</param>
        /// <returns>la famille correspondant au médicament</returns>
        public static Famille GetFamilleDuMedicament(Medicament medicament)
        {
            Famille laFamille = Passerelle.GetFamilleMedicament(medicament.Id);
            medicament.Famille = laFamille;
            return laFamille;
        }
        
        public static Medecin GetMedecin(int index)
        {
            return lesMedecins[index];
        }

        public static List<Medecin> ChargerMedecins()
        {
            lesMedecins = Passerelle.GetLesMedecins();
            return lesMedecins;
        }
        public static Specialite GetSpecialiteDuMedecin(Medecin med)
        {
            Specialite spe = Passerelle.GetSpeMedecin(med.Id);
            med.Specialite = spe;
            return spe;
        }

        public static bool AjouterMedicament(Medicament med)
        {
            bool res = Passerelle.AddMedicament(med);
            return res;
        }
        public static List<Famille> ChargerLesFamilles()
        {
            return lesFamilles = Passerelle.ChargerFamilles();
        }

        public static List<Visiteur> ChargerLesVisiteurs()
        {
            return lesVisiteurs = Passerelle.GetLesVisiteurs();
        }
        public static List<Int32> ChargerLesIdsRapportVisiteur(string idVisiteur)
        {
            return lesId = Passerelle.GetIdsRapportsVisiteur(idVisiteur);
        }
        public static List<Int32> ChargerLesIdsRapportMedecin(string idMedecin)
        {
            return lesId = Passerelle.GetIdsRapportsMedecin(idMedecin);
        }
        public static Rapport GetRapport(int idRapport)
        {
            Rapport rapport = Passerelle.GetRapportFromId(idRapport);
            
            rapport.Visiteur = Passerelle.GetVisiteur(rapport.IdVisiteur);
            rapport.Medecin = Passerelle.GetMedecin(rapport.IdMedecin);

            return rapport;
        }
        public static List<EchantillonOffert> GetLesEchantillonsOfferts(int idRapport)
        {
            return Passerelle.GetLesEchantillonsOfferts(idRapport);
        }
        public static Visiteur GetVisiteur(string idVisiteur)
        {
            return Passerelle.GetVisiteur(idVisiteur);
        }
    }
}
