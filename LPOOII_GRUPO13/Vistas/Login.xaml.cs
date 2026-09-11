using System;
using System.Windows;

namespace Vistas
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void btnclick_onClick(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Password.Trim();

            // Usuarios hardcoded según requerimiento del práctico (Admin y Vendedor)
            string rol = string.Empty;

            if (usuario.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "admin")
            {
                rol = "Admin";
            }
            else if (usuario.Equals("vendedor", StringComparison.OrdinalIgnoreCase) && password == "vendedor")
            {
                rol = "Vendedor";
            }

            if (!string.IsNullOrEmpty(rol))
            {
                MessageBox.Show(string.Format("Bienvenido al sistema: {0}\nRol asignado: {1}", usuario, rol),
                    "Acceso Concedido", MessageBoxButton.OK, MessageBoxImage.Information);

                MenuPrincipal menu = new MenuPrincipal(rol);
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.\nPruebe con admin/admin o vendedor/vendedor.",
                    "Error de Validación", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
