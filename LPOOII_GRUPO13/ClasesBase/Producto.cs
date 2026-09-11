using System;

namespace ClasesBase
{
    public class Producto
    {
        public string CodProducto { get; set; }
        public string Categoria { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Producto()
        {
        }

        public Producto(string codProducto, string categoria, string color, string descripcion, decimal precio)
        {
            CodProducto = codProducto;
            Categoria = categoria;
            Color = color;
            Descripcion = descripcion;
            Precio = precio;
        }

        public override string ToString()
        {
            return string.Format("Codigo: {0}\nCategoria: {1}\nColor: {2}\nDescripcion: {3}\nPrecio: {4:C}",
                CodProducto, Categoria, Color, Descripcion, Precio);
        }
    }
}
