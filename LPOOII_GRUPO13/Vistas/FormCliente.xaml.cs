using System;
using System.Windows;
using ClasesBase;

namespace Vistas
{
    public partial class FormCliente : Window
    {
        private Cliente oCliente;

        public FormCliente()
        {
            InitializeComponent();
            ConfigurarEstadoInicial();
        }

        private void ConfigurarEstadoInicial()
        {
            SetCamposHabilitados(false);
            btnNuevo.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            SetNavegacionHabilitada(true);
        }

        private void SetCamposHabilitados(bool habilitado)
        {
            txtDNI.IsEnabled = habilitado;
            txtApellido.IsEnabled = habilitado;
            txtNombre.IsEnabled = habilitado;
            txtDireccion.IsEnabled = habilitado;
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
        }

        private void SetNavegacionHabilitada(bool habilitada)
        {
            btnPrimero.IsEnabled = habilitada;
            btnAnterior.IsEnabled = habilitada;
            btnSiguiente.IsEnabled = habilitada;
            btnUltimo.IsEnabled = habilitada;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCampos();
            SetCamposHabilitados(true);

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;

            btnNuevo.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            SetNavegacionHabilitada(false);

            txtDNI.Focus();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios (DNI, Apellido y Nombre).",
                    "Validación de Datos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult confirmacion = MessageBox.Show("¿Desea confirmar el alta del Cliente?",
                "Confirmación de Guardado", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (confirmacion == MessageBoxResult.Yes)
            {
                oCliente = new Cliente();
                oCliente.DNI = txtDNI.Text.Trim();
                oCliente.Apellido = txtApellido.Text.Trim();
                oCliente.Nombre = txtNombre.Text.Trim();
                oCliente.Direccion = txtDireccion.Text.Trim();

                string mensaje = string.Format("Cliente almacenado exitosamente en objeto oCliente:\n\n" +
                                               "• DNI: {0}\n" +
                                               "• Apellido: {1}\n" +
                                               "• Nombre: {2}\n" +
                                               "• Dirección: {3}",
                                               oCliente.DNI, oCliente.Apellido, oCliente.Nombre, oCliente.Direccion);

                MessageBox.Show(mensaje, "Datos Guardados en Memoria", MessageBoxButton.OK, MessageBoxImage.Information);

                SetCamposHabilitados(false);
                btnGuardar.IsEnabled = false;
                btnCancelar.IsEnabled = false;
                btnNuevo.IsEnabled = true;
                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                SetNavegacionHabilitada(true);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCampos();
            SetCamposHabilitados(false);

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnNuevo.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            SetNavegacionHabilitada(true);
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
