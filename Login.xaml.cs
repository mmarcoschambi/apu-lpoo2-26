using System;
using System.Windows;

namespace Vistas
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Password;

            if (usuario == "admin" && password == "admin123")
            {
                MessageBox.Show("Bienvenido Administrador", "Acceso Correcto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (usuario == "vendedor" && password == "vend123")
            {
                MessageBox.Show("Bienvenido Vendedor", "Acceso Correcto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButton.OK, MessageBoxImage.Error);
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