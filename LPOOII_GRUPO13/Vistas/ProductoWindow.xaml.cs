using System;
using System.Windows;
using ClasesBase;

namespace Vistas
{
    public partial class ProductoWindow : Window
    {
        private Producto oProducto;

        public ProductoWindow()
        {
            InitializeComponent();
            ModoConsulta();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCampos(); HabilitarCampos(true); HabilitarBotonesEdicion(true); txtCodProducto.Focus();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodProducto.Text.Trim() == "" || txtCategoria.Text.Trim() == "" ||
                txtColor.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Validación",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            decimal precio;
            if (!Decimal.TryParse(txtPrecio.Text.Trim(), out precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor que cero.", "Validación",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtPrecio.Focus();
                return;
            }

            if (MessageBox.Show("¿Desea guardar los datos?", "Confirmar",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                oProducto = new Producto();
                oProducto.CodProducto = txtCodProducto.Text.Trim();
                oProducto.Categoría = txtCategoria.Text.Trim();
                oProducto.Color = txtColor.Text.Trim();
                oProducto.Descripción = txtDescripcion.Text.Trim();
                oProducto.Precio = precio;

                MessageBox.Show("Código: " + oProducto.CodProducto +
                    "\nCategoría: " + oProducto.Categoría +
                    "\nColor: " + oProducto.Color +
                    "\nDescripción: " + oProducto.Descripción +
                    "\nPrecio: $" + oProducto.Precio.ToString("0.00"),
                    "Datos guardados", MessageBoxButton.OK, MessageBoxImage.Information);

                ModoConsulta();
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCampos(); ModoConsulta();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Close();
        }

        private void LimpiarCampos()
        {
            txtCodProducto.Clear(); txtCategoria.Clear(); txtColor.Clear();
            txtDescripcion.Clear(); txtPrecio.Clear();
        }

        private void HabilitarCampos(bool valor)
        {
            txtCodProducto.IsEnabled = valor; txtCategoria.IsEnabled = valor;
            txtColor.IsEnabled = valor; txtDescripcion.IsEnabled = valor; txtPrecio.IsEnabled = valor;
        }

        private void ModoConsulta()
        {
            HabilitarCampos(false); HabilitarBotonesEdicion(false);
        }

        private void HabilitarBotonesEdicion(bool editando)
        {
            btnGuardar.IsEnabled = editando; btnCancelar.IsEnabled = editando;
            btnNuevo.IsEnabled = !editando; btnModificar.IsEnabled = !editando; btnEliminar.IsEnabled = !editando;
            btnPrimero.IsEnabled = !editando; btnAnterior.IsEnabled = !editando;
            btnSiguiente.IsEnabled = !editando; btnUltimo.IsEnabled = !editando;
        }
    }
}
