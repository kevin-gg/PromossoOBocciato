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

namespace PromossoOBocciato
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtVoto1.Text == "" || txtVoto2.Text == "" || txtVoto3.Text == "" || txtVoto4.Text == "")
            {
                MessageBox.Show("Inserire tutti i voti", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            try
            {
                double voto1 = double.Parse(txtVoto1.Text);
                double voto2 = double.Parse(txtVoto2.Text);
                double voto3 = double.Parse(txtVoto3.Text);
                double voto4 = double.Parse(txtVoto4.Text);
                if (voto1 > 1 && voto1 < 11 && voto2 > 1  && voto2 < 11 && voto3 > 1 && voto3 < 11 && voto4 > 1 && voto4 < 11)
                {
                    double somma = voto1 + voto2 + voto3 + voto4;
                    double media = somma / 4;
                    lblMedia.Content = media;
                    double min1 = Math.Min(voto1, voto2);
                    double min2 = Math.Min(voto3, voto4);
                    double min = Math.Min(min1, min2);
                    double max1 = Math.Max(voto1, voto2);
                    double max2 = Math.Max(voto3, voto4);
                    double max = Math.Max(max1, max2);
                    lblMinimo.Content = min;
                    lblMassimo.Content = max;
                    if (media > 5)
                        lblEsito.Content = " Promosso";
                    else
                        lblEsito.Content = " Bocciato";
                }
                else
                {
                    MessageBox.Show("Voto non valido (da 2 a 10)", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"{ex.Message}", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
