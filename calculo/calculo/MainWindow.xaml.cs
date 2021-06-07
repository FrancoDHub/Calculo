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

namespace calculo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string lope = "Addition";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonResultat_Click(object sender, RoutedEventArgs e)
        {

            //int chiffre1 = Convert.ToInt32(TbxChiffre1.Text);
            //int chiffre2 = Convert.ToInt32(TbxChiffre2.Text);


            int chiffre1 = 0;
            int chiffre2 = 0;


            int.TryParse(TbxChiffre1.Text, out chiffre1); // essaye de convertir et la sortie dans chiffre1
            int.TryParse(TbxChiffre2.Text, out chiffre2);

            string resultat = string.Empty;   // Convert.ToString(chiffre1 + chiffre2);

            switch(lope)
            {
                case "Addition":
                    resultat = Convert.ToString(chiffre1 + chiffre2);
                    break;

                case "Multiplication":
                    resultat = Convert.ToString(chiffre1 * chiffre2);
                    break;

                case "Division":
                    if (chiffre2 > 0) // boucles imbriques a cause de cette imbrication on passe le dernier case avec le if

                { 
                   resultat = Convert.ToString(chiffre1 / chiffre2); // convertir chiffres en chaines de caracteres
                }
               else
                {
                    MessageBox.Show("impossible de diviser par zero","OUPS!!!",MessageBoxButton.OK,MessageBoxImage.Information);
                        TbxChiffre1.Text = "0";
                        TbxChiffre2.Text = "0";      // remet tout a zero
                        TblockResultat.Text = "0";

                    }
                    break;
            }

            // On peut le faire de deux mamieres IF ou CASE

            //if(lope == "Addition")

            //{
            //   resultat = Convert.ToString(chiffre1 + chiffre2);
            //}

            //if (lope == "Multiplication")

            //{
            //    resultat = Convert.ToString(chiffre1 * chiffre2);
            //}

            //if (lope == "Division")

            //{
            //    if(chiffre2 > 0) // boucles imbriques

            //    { 
            //        resultat = Convert.ToString(chiffre1 / chiffre2); // convertir chiffres en chaines de caracteres
            //    }
            //    else
            //    {
            //        MessageBox.Show("impossible de diviser par zero","OUPS!!!",MessageBoxButton.OK,MessageBoxImage.Information);
            //    }
            //}

            if (Convert.ToString(chiffre1) != TbxChiffre1.Text || Convert.ToString(chiffre2) !=TbxChiffre2.Text)

            {
                MessageBox.Show(" vs devez entrer un chiffre ", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);

                TbxChiffre1.Text = "0";
                TbxChiffre2.Text = "0";      // remet tout a zero
                TblockResultat.Text = "0";
            }
            else
            {
                TblockResultat.Text = resultat;

               

            }

       


            


      


        }

        private void RadioButtonAddition_Checked(object sender, RoutedEventArgs e)

        {
            labelOperation.Content = "+";
            lope = "Addition";
        }

        private void RadioButtonMultiplication_Checked(object sender, RoutedEventArgs e)
        {
            labelOperation.Content = "*";
            lope = "Multiplication";
        }

        private void RadioButtonDivision_Checked(object sender, RoutedEventArgs e)
        {
            labelOperation.Content = "/ ";
            lope = "Division";
        }
    }
}
