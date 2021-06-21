using System;
using System.Collections.Generic;

namespace Estacionamiento
{
    class Program
    {
        public static List<Empleado> listaEmpleados = new List<Empleado>();
        public static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        public static List<Boleto> listaBoletos = new List<Boleto>();
        static void Main(string[] args)
        {
            Vehiculo auto1 = new Vehiculo(4.5, 4, "ABC-117", "Toyota", "Negro");
            Vehiculo auto2 = new Vehiculo(3.5, 6, "ABC-140", "Nissan", "Plateado");
            Vehiculo auto3 = new Vehiculo(9.2, 8, "ABC-031", "Chevrolet", "Rojo");

            Cliente cliente1 = new Cliente("Pepe", "Problemas", auto1);
            Cliente cliente2 = new Cliente("Carla", "Pérez", auto2);
            Cliente cliente3 = new Cliente("Javier", "Maldonado", auto3);
            //Console.WriteLine($"{cliente1.Nombre} {cliente1.Apellidos} {cliente1.Vehiculo.Marca}");

            Empleado empleado1 = new Empleado("John", "Cena", "Caja", 1250.0);

            listaEmpleados.Add(empleado1);

            Estacionamiento estacionamiento = new Estacionamiento(listaEmpleados, listaVehiculos, 10);

            listaVehiculos.Add(auto1);
            listaVehiculos.Add(auto2);
            listaVehiculos.Add(auto3);

            //Console.WriteLine($"{estacionamiento.ListaVehiculos[0].Marca}, {estacionamiento.ListaVehiculos[0].Color}");

            DateTime tiempo = DateTime.Now;


            Boleto boleto1 = new Boleto(tiempo, cliente1, empleado1);
            Boleto boleto2 = new Boleto(tiempo, cliente2, empleado1);
            Boleto boleto3 = new Boleto(tiempo, cliente3, empleado1);

            listaBoletos.Add(boleto1);
            listaBoletos.Add(boleto2);
            listaBoletos.Add(boleto3);

            //ImprimirBoleto(boleto1);
            ImprimirBoletos();

        }

        public static void ImprimirBoleto(Boleto boleto)
        {
            Console.WriteLine($"Cliente: {boleto.Cliente.Nombre}\nAtendido por: {boleto.Empleado.Nombre}" +
                $"\nVehículo: {boleto.Cliente.Vehiculo.Marca} {boleto.Cliente.Vehiculo.Color}" +
                $"\nHora de entrada: {boleto.Fecha}\nPrecio: ${boleto.Precio} pesos");
        }

        public static void ImprimirBoletos()
        {
            int cont = 1;
            foreach(Boleto boleto in listaBoletos)
            {
                Console.WriteLine($"Boleto: {cont}");
                Console.WriteLine($"Cliente: {boleto.Cliente.Nombre} {boleto.Cliente.Apellidos}" +
                    $"\nAtendido por: {boleto.Empleado.Nombre} {boleto.Empleado.Apellidos}" +
                    $"\nVehículo: {boleto.Cliente.Vehiculo.Marca} {boleto.Cliente.Vehiculo.Color}" +
                    $"\nHora de entrada: {boleto.Fecha}\nPrecio: ${boleto.Precio} pesos.\n - - - - - - - - - - - - - - - - - - - - -");
                cont++;
            }
        }
    }
}
