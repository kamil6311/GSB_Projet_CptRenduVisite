using gsb_CRvisite.Classes;
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
    /// Logique d'interaction pour frmAjoutMedicament.xaml
    /// </summary>
    public partial class frmAjoutMedicament : UserControl
    {
        public frmAjoutMedicament()
        {
            InitializeComponent();
            listeFamille.ItemsSource = Manager.ChargerLesFamilles();
        }

        private void CreerMedic(object sender, RoutedEventArgs e)
        {
            Famille f = (Famille)listeFamille.SelectedItem;
            Medicament m = new Medicament(newId.Text, newNomC.Text, newComposition.Text, newEffets.Text, newContreIndications.Text, f);

            bool res = Manager.AjouterMedicament(m);
            if(res == true)
            {
                MessageBox.Show("Le médicament " + m.Id + " a été créé");
            }
            else
            {
                MessageBox.Show("erreur", "erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
