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
    /// Logique d'interaction pour frmAccueil.xaml
    /// </summary>
    public partial class frmAccueil : UserControl
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btQuitter(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
            
        }
    }
}
