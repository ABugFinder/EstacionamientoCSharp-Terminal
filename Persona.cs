using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamiento
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

    }
}
