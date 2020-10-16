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
            // Les couleurs du vin
            Couleur blanc = new Couleur("Blanc");
            Couleur rose = new Couleur("Rosé");
            Couleur rouge = new Couleur("Rouge");

            // Les cépages du vin 
            Cepage beaujolais = new Cepage("Beaujolais");
            Cepage chardonnay = new Cepage("Chardonnay");
            Cepage gamay = new Cepage("Gamay");
            Cepage pinotNoir = new Cepage("Pinot noir");
            Cepage sauvignon = new Cepage("Sauvignon");

            // Les vins 
            Vin vin1 = new Vin("Juliénas", 2005, beaujolais, rouge, 13.78);
            Vin vin2 = new Vin("Saint Amour", 2012, beaujolais, blanc, 18);
            Vin vin3 = new Vin("Brouilly", 2018, beaujolais, rouge, 14.5);
            Vin vin4 = new Vin("Morgon", 2015, beaujolais, rose, 21.34);
            Vin vin5 = new Vin("Bourgogne Côte de Beaune", 2002, chardonnay, blanc, 39.5);
            Vin vin6 = new Vin("Aligoté", 2016, chardonnay, blanc, 7.12);
            Vin vin7 = new Vin("Bourgogne Côte de Nuits", 2000, chardonnay, rose, 11.67);
            Vin vin8 = new Vin("Chablis", 2011, chardonnay, blanc, 15.17);
            Vin vin9 = new Vin("Champagne", 2014, chardonnay, blanc, 24.71);
            Vin vin10 = new Vin("La Roche", 2005, gamay, rouge, 12.45);
            Vin vin11 = new Vin("Le Carquelin", 2005, gamay, rouge, 15.98);
            Vin vin12 = new Vin("Morgon Vieilles Vignes", 2005, gamay, rouge, 19.54);
            Vin vin13 = new Vin("Coeurs de terroirs", 2005, gamay, rose, 9.80);
            Vin vin14 = new Vin("Alox Corton", 2005, pinotNoir, rouge, 17.65);
            Vin vin15 = new Vin("Edelzwicker ", 2017, pinotNoir, blanc, 23.81);
            Vin vin16 = new Vin("Romanée Conti", 2009, pinotNoir, rouge, 14.83);
            Vin vin17 = new Vin("Château d'Yguem", 2010, sauvignon, rose, 11.56);
            Vin vin18 = new Vin("Château Guiraud", 2003, sauvignon, rouge, 16.90);
            Vin vin19 = new Vin("Château Coutet", 2017, sauvignon, rouge, 22.74);
            Vin vin20 = new Vin("Château Suduiraut", 2007, sauvignon, rouge, 8.63);

            // Les bouteilles 
            Bouteille b1 = new Bouteille(1, 125, vin1);
            Bouteille b2 = new Bouteille(2, 56, vin2);
            Bouteille b3 = new Bouteille(3, 23, vin3);
            Bouteille b4 = new Bouteille(4, 14, vin4);
            Bouteille b5 = new Bouteille(5, 87, vin5);
            Bouteille b6 = new Bouteille(6, 34, vin6);
            Bouteille b7 = new Bouteille(7, 78, vin7);
            Bouteille b8 = new Bouteille(8, 19, vin8);
            Bouteille b9 = new Bouteille(9, 41, vin9);
            Bouteille b10 = new Bouteille(10, 12, vin10);
            Bouteille b11 = new Bouteille(11, 25, vin11);
            Bouteille b12 = new Bouteille(12, 46, vin12);
            Bouteille b13 = new Bouteille(13, 62, vin13);
            Bouteille b14 = new Bouteille(14, 5, vin14);
            Bouteille b15 = new Bouteille(15, 44, vin15);
            Bouteille b16 = new Bouteille(16, 62, vin16);
            Bouteille b17 = new Bouteille(17, 21, vin17);
            Bouteille b18 = new Bouteille(18, 71, vin18);
            Bouteille b19 = new Bouteille(19, 37, vin19);
            Bouteille b20 = new Bouteille(20, 92, vin20);

            //Liste de bouteilles
            List<Bouteille> boutCav1 = new List<Bouteille>();
            List<Bouteille> boutCav2 = new List<Bouteille>();
            List<Bouteille> boutCav3 = new List<Bouteille>();

            //Ajout bouteilles aux listes bouteilles
            boutCav1.Add(b1);
            boutCav1.Add(b2);
            boutCav1.Add(b3);
            boutCav1.Add(b4);
            boutCav1.Add(b5);
            boutCav1.Add(b6);
            boutCav1.Add(b7);
            boutCav2.Add(b8);
            boutCav2.Add(b9);
            boutCav2.Add(b10);
            boutCav2.Add(b11);
            boutCav1.Add(b12);
            boutCav2.Add(b13);
            boutCav3.Add(b14);
            boutCav3.Add(b15);
            boutCav2.Add(b16);
            boutCav3.Add(b17);
            boutCav3.Add(b18);
            boutCav2.Add(b19);
            boutCav3.Add(b20);

            //Ajout des caves au dico
            gst = new GestionnaireDeCaves();
            gst.AjouterCave("SIO1", boutCav1);
            gst.AjouterCave("SIO2", boutCav2);
            gst.AjouterCave("SIO3", boutCav3);

            //affichage des caves
            lvCaves.ItemsSource = gst.LesCaves.Keys;
        }

        private void lvCaves_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Actualisation de la liste de bouteilles
            if(lvCaves.SelectedItem != null)
            {
                lvBouteilles.ItemsSource = gst.LesCaves[lvCaves.SelectedItem as string];
            }

            //Actualisation des informations de la cave
            txtNbBouteilles.Text = gst.NbBouteilles(lvCaves.SelectedItem as string).ToString();
            txtNbBouteillesDeRouges.Text = gst.NbBouteillesDeRouges(lvCaves.SelectedItem as string).ToString();
            txtValeurDeLaCave.Text= gst.ValeurDeLaCave(lvCaves.SelectedItem as string).ToString();

            //Suppression des information de la bouteille
            txtMillesime.Text = null;
            txtNomCepage.Text = null;
            txtCouleur.Text = null;
            txtPrix.Text = null;
        }

        private void lvBouteilles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvBouteilles.SelectedItem != null)
            {
                //Actualisation des informations du vin
                txtMillesime.Text = (lvBouteilles.SelectedItem as Bouteille).LeVin.MillesimeVin.ToString();
                txtNomCepage.Text = (lvBouteilles.SelectedItem as Bouteille).LeVin.LeCepage.NomCepage;
                txtCouleur.Text = (lvBouteilles.SelectedItem as Bouteille).LeVin.LaCouleur.NomCouleur;
                txtPrix.Text = (lvBouteilles.SelectedItem as Bouteille).LeVin.PrixDuVin.ToString();
            }
        }
    }
}
