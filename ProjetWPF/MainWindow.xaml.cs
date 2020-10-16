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
using ProjetMetier;

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestionnaireDeCaves gst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // A vous de jouer
        }

        private void lvCaves_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // A vous de jouer
        }

        private void lvBouteilles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // A vous de jouer
        }
    }
}
