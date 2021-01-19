﻿using System;
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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btQuitter(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListeMenuClick(object sender, RoutedEventArgs e)
        {
            frmMedicament frmMedic = new frmMedicament();
            contentControl.Content = frmMedic;
            contentControl.DataContext = frmMedic;
        }
        private void FermerMDI()
        {
            
        }
    }
}