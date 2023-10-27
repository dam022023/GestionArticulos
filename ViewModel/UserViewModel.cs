using GestionArticulos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GestionArticulos.ViewModel
{
    class UserViewModel
    {
        private IList<User> listaArticulos;

        public UserViewModel()
        {
            listaArticulos = new List<User>
            {
                new User{Codigo = 1, Nombre="Artículo 1", Descripcion="Lorem ipsum", PrecioCoste=1.0, Tipo="General", PrecioVenta=2.0},
                new User{Codigo = 2, Nombre="Artículo 2", Descripcion="Donec ornare", PrecioCoste=2.0, Tipo="Reducido", PrecioVenta=4.0},
                new User{Codigo = 3, Nombre="Artículo 3", Descripcion="Vivamus porta", PrecioCoste=3.0, Tipo="Superreducido", PrecioVenta=6.0},
                new User{Codigo = 4, Nombre="Artículo 4", Descripcion="Morbi rhoncus", PrecioCoste=4.0, Tipo="General", PrecioVenta=8.0},
                new User{Codigo = 5, Nombre="Artículo 5", Descripcion="In ac felis", PrecioCoste=5.0, Tipo="Reducido", PrecioVenta=10.0},
                new User{Codigo = 6, Nombre="Artículo 6", Descripcion="Aliquam", PrecioCoste=6.0, Tipo="Superreducido", PrecioVenta=12.0},
                new User{Codigo = 7, Nombre="Artículo 7", Descripcion="Maecenas", PrecioCoste=7.0, Tipo="General", PrecioVenta=14.0},
                new User{Codigo = 8, Nombre="Artículo 8", Descripcion="Sed porta", PrecioCoste=8.0, Tipo="Reducido", PrecioVenta=16.0}               
            };
        }

        public IList<User> Users
        {
            get { return listaArticulos; }
            set { listaArticulos = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private void darDeAlta(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.ShowDialog();
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
            
            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
