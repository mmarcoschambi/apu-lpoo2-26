using System;
using System.Windows;

namespace Vistas
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string rol = "Admin";
            string usuario = "Carlos";

            lblTitulo.Text = "Bienvenido, " + usuario;
            lblRol.Text = "Rol actual: " + rol;

            AplicarPermisos(rol);
        }

        private void AplicarPermisos(string rol)
        {
            if (rol == "Admin")
            {
                btn_Proveedores.IsEnabled = true;
                btn_Clientes.IsEnabled = true;
                btn_Productos.IsEnabled = true;
                btn_Vendedores.IsEnabled = true;
            }
            else if (rol == "Vendedor")
            {
                btn_Vendedores.IsEnabled = false;
            }
        }

        private void btnProveedores_Click(object sender, RoutedEventArgs e)
        {
            ProveedorWindow ventana = new ProveedorWindow();
            ventana.ShowDialog();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            ClienteWindow ventana = new ClienteWindow();
            ventana.ShowDialog();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            ProductoWindow ventana = new ProductoWindow();
            ventana.ShowDialog();
        }

        private void btnVendedores_Click(object sender, RoutedEventArgs e)
        {
            VendedorWindow ventana = new VendedorWindow();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "Confirmar salida",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (respuesta == MessageBoxResult.Yes)
                Close();
        }
    }
}
