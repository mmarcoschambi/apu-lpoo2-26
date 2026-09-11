using System;
using System.Windows;

namespace Vistas
{
    public partial class MenuPrincipal : Window
    {
        private string rolUsuario;

        public MenuPrincipal() : this("Admin")
        {
        }

        public MenuPrincipal(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;
            ConfigurarSegunRol();
        }

        private void ConfigurarSegunRol()
        {
            lblInfoRol.Text = string.Format("Sesión activa: Rol {0}", rolUsuario);
            lblStatusBar.Text = string.Format("Usuario conectado | Rol: {0} | Mueblería UNJu", rolUsuario);

            // Requerimiento 5: Solo el usuario Admin tendrá habilitada las funciones de gestión de Vendedores
            bool esAdmin = rolUsuario.Equals("Admin", StringComparison.OrdinalIgnoreCase);

            btnVendedores.IsEnabled = esAdmin;
            btnCardVendedores.IsEnabled = esAdmin;

            if (!esAdmin)
            {
                btnVendedores.ToolTip = "Acceso restringido únicamente a usuarios Administradores";
                btnCardVendedores.ToolTip = "Acceso restringido únicamente a usuarios Administradores";
                btnCardVendedores.Opacity = 0.5;
            }
        }

        private void btnProveedores_Click(object sender, RoutedEventArgs e)
        {
            FormProveedor form = new FormProveedor();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            FormCliente form = new FormCliente();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            FormProducto form = new FormProducto();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnVendedores_Click(object sender, RoutedEventArgs e)
        {
            if (!rolUsuario.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("No posee los privilegios necesarios para gestionar Vendedores.",
                    "Acceso Denegado", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            FormVendedor form = new FormVendedor();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult respuesta = MessageBox.Show("¿Está seguro de que desea cerrar la sesión actual?",
                "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (respuesta == MessageBoxResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }
    }
}
