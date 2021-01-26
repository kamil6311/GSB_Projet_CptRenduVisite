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
            ListRapports.ItemsSource = null;
        }

        private void VisiteurRechercherClick(object sender, RoutedEventArgs e)
        {
            Visiteur v = ListeVisiteurs.SelectedItem as Visiteur;

            ListRapports.ItemsSource = Manager.ChargerLesIdsRapport(v.Id);
        }

        private void SelectionRapport(object sender, SelectionChangedEventArgs e)
        {
            if (ListRapports.SelectedItem == null) return;

            int idRapport = (int)ListRapports.SelectedItem;
            Rapport rapport = Manager.GetRapport(idRapport);
            Visiteur visiteur = Passerelle.GetVisiteur(rapport.IdVisiteur);

            NomVisiteur.Text = visiteur.Nom;
            PrenomVisiteur.Text = visiteur.Prenom;
            MotifVisite.Text = rapport.Motif;
            DateVisite.SelectedDate = rapport.Date;
            BilanVisite.Text = rapport.Bilan;

            //while(Manager.GetLesEchantillonsOfferts(rapport.id) != null)
            //{
            //    string
            //    ListViewMedics.Items.Add()
            //}
            //ListViewMedics.ItemsSource = Manager.GetLesEchantillonsOfferts(rapport.Id);
        }
    }
}
