using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using gsb_CRvisite.Classes;

namespace gsb_CRvisite
{
    /// <summary>
    /// Logique d'interaction pour frmRapport.xaml
    /// </summary>
    public partial class frmRapport : UserControl
    {
        public frmRapport()
        {
            InitializeComponent();
            ListeVisiteurs.ItemsSource = Manager.ChargerLesVisiteurs();
            ListeMedecins.ItemsSource = Manager.ChargerMedecins();
        }

        private void selectVisiteur(object sender, SelectionChangedEventArgs e)
        {
            //ListRapports.ItemsSource = null;
        }

        private void VisiteurRechercherClick(object sender, RoutedEventArgs e)
        {
            if (ListeVisiteurs.SelectedItem == null) return;
            ListRapports.ItemsSource = null;
            Visiteur v = ListeVisiteurs.SelectedItem as Visiteur;
            ListRapports.ItemsSource = Manager.ChargerLesIdsRapportVisiteur(v.Id);
        }
        private void MedecinRechercherClick(object sender, RoutedEventArgs e)
        {
            if (ListeMedecins.SelectedItem == null) return;
            if (ListRapports.Items != null)
            {
                ListRapports.ItemsSource = null;
                Medecin m = ListeMedecins.SelectedItem as Medecin;
                ListRapports.ItemsSource = Manager.ChargerLesIdsRapportMedecin(m.Id);
            }
            else return;
        }
        private void SelectionRapport(object sender, SelectionChangedEventArgs e)
        {
            if (ListRapports.SelectedItem == null) return;

            ListViewMedics.Items.Clear();
            int idRapport = (int)ListRapports.SelectedItem;
            Rapport rapport = Manager.GetRapport(idRapport);
            Visiteur visiteur = Passerelle.GetVisiteur(rapport.IdVisiteur);
            Medecin medecin = Passerelle.GetMedecin(rapport.IdMedecin);

            NomVisiteur.Text = visiteur.Nom;
            PrenomVisiteur.Text = visiteur.Prenom;
            MotifVisite.Text = rapport.Motif;
            DateVisite.SelectedDate = rapport.Date;
            BilanVisite.Text = rapport.Bilan;

            NomMedecin.Text = medecin.Nom;
            AdresseMedecin.Text = medecin.Adresse;
            PrenomMedecin.Text = medecin.Prenom;

            List<EchantillonOffert> lesEchantillonOffert = Manager.GetLesEchantillonsOfferts(rapport.Id);

            foreach(EchantillonOffert eo in lesEchantillonOffert)
            {
                var tab1 = new { Medicament = eo.LeMedicament.NomCommercial, Quantite = eo.Quantite };
                ListViewMedics.Items.Add(tab1);
            }
        }

    }
}
