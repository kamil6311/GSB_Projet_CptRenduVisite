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
    /// Logique d'interaction pour frmSuprimerMedicament.xaml
    /// </summary>
    public partial class frmSuprimerMedicament : UserControl
    {

        public frmSuprimerMedicament()
        {
            InitializeComponent();
            ListeMedics.ItemsSource = Manager.ChargerMedicaments();
        }

        private void SupprimerClick(object sender, RoutedEventArgs e)
        {
            bool res = false;

            MessageBoxResult result = MessageBox.Show("Êtes vous sûr de vouloir supprimer ce médicament ?", "Supprimer ?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Medicament m = ListeMedics.SelectedItem as Medicament;
                //ListeMedics.Items.RemoveAt(ListeMedics.SelectedIndex);
                res = Manager.SupprimerMedicament(m.Id);
                if (res == true)
                {
                    ListeMedics.ItemsSource = Manager.ChargerMedicaments();
                    Snackbar.MessageQueue.Enqueue("Le médcament " + m.NomCommercial + " à été supprimé");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du médicament " + m.NomCommercial);
                }
            }
            else return;
        }
    }
}
