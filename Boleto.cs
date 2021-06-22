using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamiento
{
    class Boleto
    {
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado  { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public Boleto( Cliente cliente, Empleado empleado, Vehiculo vehiculo)
        {
            this.Fecha = DateTime.Now;
            this.Precio = 15;
            this.Cliente = cliente;
            this.Empleado = empleado;
            this.Vehiculo = vehiculo;
        }
    }
}
