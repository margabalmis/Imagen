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

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image imagenStartWars = new Image ();
        public MainWindow()
        {
            InitializeComponent();
            imagenStartWars = ImagenSW;

        }
        private void AltaOpa_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenStartWars.Opacity = 1;
        }

        private void MediaOpa_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenStartWars.Opacity = 0.6;
        }

        private void BajaOpa_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenStartWars.Opacity = 0.3;
        }

        private void FillAjuste_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenStartWars.Stretch = Stretch.Fill;
        }

        private void UniformAjuste_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenStartWars.Stretch = Stretch.Uniform;
        }

        private void UniformFillAjuste_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenStartWars.Stretch = Stretch.UniformToFill;
        }

        private void SinAjuste_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenStartWars.Stretch = Stretch.None;
        }


    }
}
