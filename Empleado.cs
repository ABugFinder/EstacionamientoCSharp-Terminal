using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamiento
{
    class Empleado : Persona
    {
        public string Cargo { get; set; }
        public double Sueldo { get; set; }
        public Empleado(string nombre, string apellidos, string cargo, double sueldo) : base(nombre, apellidos)
        {
            this.Cargo = cargo;
            this.Sueldo = sueldo;
        }
    }
}
