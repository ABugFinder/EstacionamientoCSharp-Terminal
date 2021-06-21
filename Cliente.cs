using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamiento
{
    class Cliente : Persona
    {
        public Vehiculo Vehiculo { get; set; }
        public Cliente(string nombre, string apellidos, Vehiculo vehiculo) : base(nombre, apellidos)
        {
            this.Vehiculo = vehiculo;
        }
    }
}
