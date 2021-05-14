using System;

namespace Utilidades
{
    public class Persona
    {
        private int numComercial;
        private string nombre;
        private string apellido;
        private string ciudad;
        private int edad;
        private string nombreCompleto;

        public Persona(string nombre, string apellido, string ciudad, int edad, int numComercial)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ciudad = ciudad;
            this.edad = edad;
            this.numComercial = numComercial;
            this.nombreCompleto = nombre + " " + apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public int Edad { get => edad; set => edad = value; }
        public int NumComercial { get => numComercial; set => numComercial = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
    }
}
