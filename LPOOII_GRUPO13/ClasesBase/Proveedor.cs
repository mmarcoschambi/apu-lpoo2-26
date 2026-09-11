using System;

namespace ClasesBase
{
    public class Proveedor
    {
        public string CUIT { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }

        public Proveedor()
        {
        }

        public Proveedor(string cuit, string razonSocial, string domicilio, string telefono)
        {
            CUIT = cuit;
            RazonSocial = razonSocial;
            Domicilio = domicilio;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return string.Format("CUIT: {0}\nRazon Social: {1}\nDomicilio: {2}\nTelefono: {3}",
                CUIT, RazonSocial, Domicilio, Telefono);
        }
    }
}
