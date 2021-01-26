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
    /// Logique d'interaction pour frmMedicament.xaml
    /// </summary>
    public partial class frmMedicament : UserControl
    {
        public frmMedicament()
        {
            InitializeComponent();
            listeMedicaments.ItemsSource = Manager.ChargerMedicaments();
        }

        private void SelectMedic(object sender, SelectionChangedEventArgs e)
        {
            Medicament m = Manager.GetMedicament(listeMedicaments.SelectedIndex);
            Famille f = Manager.GetFamilleDuMedicament(m);

            AffichId.Text = m.Id.ToString();
            AffichNomC.Text = m.NomCommercial.ToString();
            AffichEffets.Text = m.Effets.ToString();
            AffichCompo.Text = m.Composition.ToString();
            AfficheContreIndic.Text = m.Contreindications.ToString();
            AffichFamille.Text = f.Libelle.ToString();
        }

        
    }
}
