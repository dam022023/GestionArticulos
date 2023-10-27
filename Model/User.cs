using System.ComponentModel;

namespace GestionArticulos.Model
{
    public class User : INotifyPropertyChanged
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private string foto;
        private double precioCoste;
        private string tipo;
        private double precioVenta;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
                OnPropertyChanged("Codigo");
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
                OnPropertyChanged("Descripcion");
            }
        }
        public string Foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
                OnPropertyChanged("Foto");
            }
        }
        public double PrecioCoste
        {
            get
            {
                return precioCoste;
            }
            set
            {
                precioCoste = value;
                OnPropertyChanged("Precio Coste");
            }
        }
        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
                OnPropertyChanged("Tipo");
            }
        }
        public double PrecioVenta
        {
            get
            {
                return precioVenta;
            }
            set
            {
                precioVenta = value;
                OnPropertyChanged("Precio Venta");
            }
        }


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
