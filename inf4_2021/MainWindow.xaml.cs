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

namespace inf4_2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int []tt = new int[22];
          

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           string email1 = email.Text;
            string haslo_b = haslo1.Password;
            string haslo_a = haslo.Password;

            int n = email1.Length;
            bool czy_email=false;

            for (int i = 0; i < n; i++)
            {
                if (email1[i] == '@') {
                    czy_email = true;
                }
            }

           // email1.Contains("@");


            if (!czy_email) {
                wynik.Content = "Email niepoprawny";
            }
            else
            {
                if (haslo_a.Equals(haslo_b))
                {
                    wynik.Content = "Witaj " + email1;

                }
                else{
                    wynik.Content = "Hasła się różnią";

                }
                
                
               
            }

           // wynik.Content = wynik.Content + haslo_a;
            
            
            // wynik.Content = email1;
        }
    }
}
