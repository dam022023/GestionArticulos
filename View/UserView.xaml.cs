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
using System.Windows.Shapes;

namespace GestionArticulos.View
{
    /// <summary>
    /// Lógica de interacción para UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
        public UserView()
        {
            InitializeComponent();
        }
        private void AbrirVentana_Click(object sender, RoutedEventArgs e)
        {
            NuevaVentana nuevaVentana = new NuevaVentana();
            nuevaVentana.Show();
        }

        private void DarDeBaja(object sender, RoutedEventArgs e)
        {
            DarDeBaja darDeBaja = new DarDeBaja();
            darDeBaja.Show();
        }

    }
}
