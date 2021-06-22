using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamiento
{
    class Cliente : Persona
    {
        public int Edad { get; set; }
        public Cliente(string nombre, string apellidos, int edad) : base(nombre, apellidos)
        {
            this.Edad = edad;
        }
    }
}
