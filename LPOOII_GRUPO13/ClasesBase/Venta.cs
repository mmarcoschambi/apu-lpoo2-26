using System;

namespace ClasesBase
{
    public class Venta
    {
        public int NroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Legajo { get; set; }
        public string DNI { get; set; }
        public string CodProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }

        public Venta()
        {
            FechaFactura = DateTime.Now;
        }

        public Venta(int nroFactura, DateTime fechaFactura, string legajo, string dni, 
                     string codProducto, decimal precio, int cantidad, decimal importe)
        {
            NroFactura = nroFactura;
            FechaFactura = fechaFactura;
            Legajo = legajo;
            DNI = dni;
            CodProducto = codProducto;
            Precio = precio;
            Cantidad = cantidad;
            Importe = importe;
        }

        public override string ToString()
        {
            return string.Format("Factura Nro: {0}\nFecha: {1:dd/MM/yyyy}\nLegajo: {2}\nDNI: {3}\nCodProducto: {4}\nPrecio: {5:C}\nCantidad: {6}\nImporte: {7:C}",
                NroFactura, FechaFactura, Legajo, DNI, CodProducto, Precio, Cantidad, Importe);
        }
    }
}
