using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamiento
{
    class Estacionamiento
    {
        public List<Vehiculo> ListaVehiculos { get; set; }
        public int Lugares { get; set; }
        public List<Empleado> ListaEmpleados { get; set; }
        public Estacionamiento(List<Empleado> listaEmpleados, List<Vehiculo> listaVehiculos, int lugares)
        {
            this.ListaEmpleados = listaEmpleados;
            this.ListaVehiculos = listaVehiculos;
            this.Lugares = lugares;
        }
    }
}
