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

        public Boleto(DateTime fecha, Cliente cliente, Empleado empleado)
        {
            this.Fecha = fecha;
            this.Precio = 15;
            this.Cliente = cliente;
            this.Empleado = empleado;
        }
    }
}
