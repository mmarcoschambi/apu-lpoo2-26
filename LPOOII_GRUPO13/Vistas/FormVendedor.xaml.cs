using System;
using System.Windows;
using ClasesBase;

namespace Vistas
{
    public partial class FormVendedor : Window
    {
        private Vendedor oVendedor;

        public FormVendedor()
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
            txtLegajo.IsEnabled = habilitado;
            txtApellido.IsEnabled = habilitado;
            txtNombre.IsEnabled = habilitado;
        }

        private void LimpiarCampos()
        {
            txtLegajo.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
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

            txtLegajo.Focus();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLegajo.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor complete todos los datos del Vendedor (Legajo, Apellido y Nombre).",
                    "Validación de Datos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult confirmacion = MessageBox.Show("¿Desea confirmar el alta del Vendedor?",
                "Confirmación de Guardado", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (confirmacion == MessageBoxResult.Yes)
            {
                oVendedor = new Vendedor();
                oVendedor.Legajo = txtLegajo.Text.Trim();
                oVendedor.Apellido = txtApellido.Text.Trim();
                oVendedor.Nombre = txtNombre.Text.Trim();

                string mensaje = string.Format("Vendedor almacenado exitosamente en objeto oVendedor:\n\n" +
                                               "• Legajo: {0}\n" +
                                               "• Apellido: {1}\n" +
                                               "• Nombre: {2}",
                                               oVendedor.Legajo, oVendedor.Apellido, oVendedor.Nombre);

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
