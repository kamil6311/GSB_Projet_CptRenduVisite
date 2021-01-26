using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace gsb_CRvisite
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frmAccueil UCacceuil = new frmAccueil();
            contentControl.Content = UCacceuil;
            
        }

        private void btQuitter(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListeMenuClick(object sender, RoutedEventArgs e)
        {
            FermerMed();

            frmMedicament frmMedic = new frmMedicament();
            contentControl.Content = frmMedic;
        }
        private void FermerMed()
        {
            string UC = this.contentControl.Content.ToString();
            if(UC != "frmAccueil")
            {
                frmAccueil UCaccueil = new frmAccueil();
                this.contentControl.Content = UCaccueil;
            }
        }
        private void RendVisible(bool val)
        {

        }

        private void RechercherMedecinClick(object sender, RoutedEventArgs e)
        {
            FermerMed();

            frmMedecin frmMedecin = new frmMedecin();
            contentControl.Content = frmMedecin;
        }

        private void ClickGereMedicament(object sender, RoutedEventArgs e)
        {
            FermerMed();
            frmAjoutMedicament ajouterMed = new frmAjoutMedicament();
            contentControl.Content = ajouterMed;
        }

        private void ClickChercherRapport(object sender, RoutedEventArgs e)
        {
            FermerMed();
            frmRapport rapport = new frmRapport();
            contentControl.Content = rapport;
        }

        private void AcceuilClick(object sender, RoutedEventArgs e)
        {
            FermerMed();
            frmAccueil accueil = new frmAccueil();
            contentControl.Content = accueil;
        }
    }
}
