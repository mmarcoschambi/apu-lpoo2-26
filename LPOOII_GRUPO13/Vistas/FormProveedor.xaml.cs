using System;
using System.Windows;
using ClasesBase;

namespace Vistas
{
    public partial class FormProveedor : Window
    {
        private Proveedor oProveedor;

        public FormProveedor()
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
            txtCUIT.IsEnabled = habilitado;
            txtRazonSocial.IsEnabled = habilitado;
            txtDomicilio.IsEnabled = habilitado;
            txtTelefono.IsEnabled = habilitado;
        }

        private void LimpiarCampos()
        {
            txtCUIT.Clear();
            txtRazonSocial.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
        }

        private void SetNavegacionHabilitada(bool habilitada)
        {
            btnPrimero.IsEnabled = habilitada;
            btnAnterior.IsEnabled = habilitada;
            btnSiguiente.IsEnabled = habilitada;
            btnUltimo.IsEnabled = habilitada;
        }

        // 7) Evento Nuevo
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

            txtCUIT.Focus();
        }

        // 7) Evento Guardar
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCUIT.Text) || string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios (CUIT y Razón Social).",
                    "Validación de Datos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Mensaje de confirmación previo (Punto 6)
            MessageBoxResult confirmacion = MessageBox.Show("¿Desea confirmar el alta del Proveedor?",
                "Confirmación de Guardado", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (confirmacion == MessageBoxResult.Yes)
            {
                // Almacenar en las propiedades del objeto oProveedor
                oProveedor = new Proveedor();
                oProveedor.CUIT = txtCUIT.Text.Trim();
                oProveedor.RazonSocial = txtRazonSocial.Text.Trim();
                oProveedor.Domicilio = txtDomicilio.Text.Trim();
                oProveedor.Telefono = txtTelefono.Text.Trim();

                // Imprimir los valores de las propiedades en un MessageBox para verificar
                string mensaje = string.Format("Proveedor almacenado exitosamente en objeto oProveedor:\n\n" +
                                               "• CUIT: {0}\n" +
                                               "• Razón Social: {1}\n" +
                                               "• Domicilio: {2}\n" +
                                               "• Teléfono: {3}",
                                               oProveedor.CUIT, oProveedor.RazonSocial, oProveedor.Domicilio, oProveedor.Telefono);

                MessageBox.Show(mensaje, "Datos Guardados en Memoria", MessageBoxButton.OK, MessageBoxImage.Information);

                // Actualizar estado de controles
                SetCamposHabilitados(false);
                btnGuardar.IsEnabled = false;
                btnCancelar.IsEnabled = false;
                btnNuevo.IsEnabled = true;
                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                SetNavegacionHabilitada(true);
            }
        }

        // 7) Evento Cancelar
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

        // 7) Evento Salir
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
