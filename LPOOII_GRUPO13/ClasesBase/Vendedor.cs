using System;

namespace ClasesBase
{
    public class Vendedor
    {
        public string Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public Vendedor()
        {
        }

        public Vendedor(string legajo, string apellido, string nombre)
        {
            Legajo = legajo;
            Apellido = apellido;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return string.Format("Legajo: {0}\nApellido: {1}\nNombre: {2}",
                Legajo, Apellido, Nombre);
        }
    }
}
