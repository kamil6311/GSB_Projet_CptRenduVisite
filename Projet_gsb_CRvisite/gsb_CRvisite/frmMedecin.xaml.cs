using gsb_CRvisite.Classes;
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

namespace gsb_CRvisite
{
    /// <summary>
    /// Logique d'interaction pour frmMedecin.xaml
    /// </summary>
    public partial class frmMedecin : UserControl
    {
        public frmMedecin()
        {
            InitializeComponent();
            listeMedecin.ItemsSource = Manager.ChargerMedecins();
        }

        private void SelectMedecin(object sender, SelectionChangedEventArgs e)
        {
            Medecin m = Manager.GetMedecin(listeMedecin.SelectedIndex);
            Specialite s = Manager.GetSpecialiteDuMedecin(m);

            AfficherId.Text = m.Id.ToString();
            AfficherSpe.Text = s.Spe.ToString();
            AfficherNom.Text = m.Nom;
            AfficherPrenom.Text = m.Prenom;
            AfficherAdresse.Text = m.Adresse;
            AfficherDepartement.Text = m.Departement.ToString();
            AfficherTel.Text = m.Tel;
        }
    }
}
