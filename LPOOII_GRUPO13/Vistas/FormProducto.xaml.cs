using System;
using System.Globalization;
using System.Windows;
using ClasesBase;

namespace Vistas
{
    public partial class FormProducto : Window
    {
        private Producto oProducto;

        public FormProducto()
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
            txtCodigo.IsEnabled = habilitado;
            txtDescripcion.IsEnabled = habilitado;
            txtCategoria.IsEnabled = habilitado;
            txtColor.IsEnabled = habilitado;
            txtPrecio.IsEnabled = habilitado;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtCategoria.Clear();
            txtColor.Clear();
            txtPrecio.Clear();
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

            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor complete Código y Descripción.",
                    "Validación de Datos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            decimal precio = 0;
            if (!string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                if (!decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out precio) &&
                    !decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out precio))
                {
                    MessageBox.Show("El precio ingresado no es un número decimal válido.",
                        "Error de Formato", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtPrecio.Focus();
                    return;
                }
            }

            MessageBoxResult confirmacion = MessageBox.Show("¿Desea confirmar el alta del Producto?",
                "Confirmación de Guardado", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (confirmacion == MessageBoxResult.Yes)
            {
                oProducto = new Producto();
                oProducto.CodProducto = txtCodigo.Text.Trim();
                oProducto.Descripcion = txtDescripcion.Text.Trim();
                oProducto.Categoria = txtCategoria.Text.Trim();
                oProducto.Color = txtColor.Text.Trim();
                oProducto.Precio = precio;

                string mensaje = string.Format("Producto almacenado exitosamente en objeto oProducto:\n\n" +
                                               "• Código: {0}\n" +
                                               "• Descripción: {1}\n" +
                                               "• Categoría: {2}\n" +
                                               "• Color: {3}\n" +
                                               "• Precio: {4:C}",
                                               oProducto.CodProducto, oProducto.Descripcion, oProducto.Categoria, oProducto.Color, oProducto.Precio);

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
