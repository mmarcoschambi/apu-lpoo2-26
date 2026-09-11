using System;

namespace ClasesBase
{
    public class Cliente
    {
        public string DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Cliente()
        {
        }

        public Cliente(string dni, string apellido, string nombre, string direccion)
        {
            DNI = dni;
            Apellido = apellido;
            Nombre = nombre;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return string.Format("DNI: {0}\nApellido: {1}\nNombre: {2}\nDireccion: {3}",
                DNI, Apellido, Nombre, Direccion);
        }
    }
}
