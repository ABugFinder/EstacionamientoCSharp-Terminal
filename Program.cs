using System;
using System.Collections.Generic;

namespace Estacionamiento
{
    class Program
    {
        public static List<Empleado> listaEmpleados = new List<Empleado>();
        public static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        public static List<Boleto> listaBoletos = new List<Boleto>();
        public static List<Cliente> listaClientes = new List<Cliente>();
        static void Main(string[] args)
        {
            Vehiculo auto1 = new Vehiculo("ABC-117", "Toyota", "Negro");
            Vehiculo auto2 = new Vehiculo("ABC-140", "Nissan", "Plateado");
            Vehiculo auto3 = new Vehiculo("ABC-031", "Chevrolet", "Rojo");

            Cliente cliente1 = new Cliente("Pepe", "Problemas", 18);
            Cliente cliente2 = new Cliente("Carla", "Pérez", 24);
            Cliente cliente3 = new Cliente("Javier", "Maldonado", 42);

            listaClientes.Add(cliente1);
            listaClientes.Add(cliente3);
            listaClientes.Add(cliente3);

            Empleado empleado1 = new Empleado("John", "Cena", "Caja", 1250.0);

            listaEmpleados.Add(empleado1);

            Estacionamiento estacionamiento = new Estacionamiento(listaEmpleados, listaVehiculos, 10);

            listaVehiculos.Add(auto1);
            listaVehiculos.Add(auto2);
            listaVehiculos.Add(auto3);

            //Console.WriteLine($"{estacionamiento.ListaVehiculos[0].Marca}, {estacionamiento.ListaVehiculos[0].Color}");

            Boleto boleto1 = new Boleto(cliente1, empleado1, auto1);
            Boleto boleto2 = new Boleto(cliente2, empleado1, auto2);
            Boleto boleto3 = new Boleto(cliente3, empleado1, auto3);

            listaBoletos.Add(boleto1);
            listaBoletos.Add(boleto2);
            listaBoletos.Add(boleto3);

            MenuPrincipal();

        }

        public static void MenuPrincipal()
        {
            bool isActivo = true;
            while (isActivo)
            {
                Console.WriteLine("Estacionamiento\n 1->Boletos\n 2->Empleados\n 3->Vehículos\n 4->Salir");

                int numero;
                String res = Console.ReadLine(); //Leyendo la respuesta del usuario

                if (int.TryParse(res, out numero)) // Validando la respuesto como numérica
                {
                    int opcion = Convert.ToInt32(res); // Convirtiendo la respuesta String a Int

                    Console.Clear(); // Limpiando la consola para no saturar la terminal

                    // Comparando la respuesta según la opción del menú
                    if (opcion == 1) { MenuBoletos(); }
                    else if (opcion == 2) { MenuEmpleados(); }
                    else if (opcion == 3) { MenuVehiculos(); }
                    else if (opcion == 4)
                    {
                        Console.WriteLine("Saliendo del sistema...");
                        isActivo = false;
                    }
                    else
                    {
                        Console.WriteLine("Error. Ingresa una opción entre 1 y 4");
                    }
                }
            }
        }

        public static void MenuBoletos() // Imprime el menú para el crud de Boletos
        {
            bool isActivo = true;
            while (isActivo)
            {
                Console.WriteLine("Boletos\n 1->Registrar\n 2->Consultar\n 3->Actualizar\n 4->Borrar\n 5->Volver");
                int numero;
                String res = Console.ReadLine(); //Leyendo la respuesta del usuario

                if (int.TryParse(res, out numero)) // Validando la respuesto como numérica
                {
                    int opcion = Convert.ToInt32(res); // Convirtiendo la respuesta String a Int

                    Console.Clear(); // Limpiando la consola para no saturar la terminal

                    // Comparando la respuesta según la opción del menú
                    if (opcion == 1) { RegistrarBoleto(); }
                    else if (opcion == 2) { ImprimirBoletos(); }
                    else if (opcion == 3) { EditarBoleto(); }
                    else if (opcion == 4) { BorrarBoleto(); }
                    else if (opcion == 5)
                    {
                        Console.WriteLine("Saliendo del sistema...");
                        isActivo = false;
                    }
                    else
                    {
                        Console.WriteLine("Error. Ingresa una opción entre 1 y 4");
                    }
                }
            }
        }

        public static void MenuEmpleados() // Imprime el menú para el crud de Empleados
        {
            Console.WriteLine("Empleados\n 1->Registrar\n 2->Consultar\n 3->Actualizar\n 4->Borrar\n 5->Volver");
            int numero;
            String res = Console.ReadLine(); //Leyendo la respuesta del usuario

            if (int.TryParse(res, out numero)) // Validando la respuesto como numérica
            {
                int opcion = Convert.ToInt32(res); // Convirtiendo la respuesta String a Int

                Console.Clear(); // Limpiando la consola para no saturar la terminal

                // Comparando la respuesta según la opción del menú
                if (opcion == 1) { RegistrarEmpleado(); }
                else if (opcion == 2) { ImprimirEmpleados(); }
                else if (opcion == 3) { /*EditarEmpleado();*/ }
                else if (opcion == 4) { /*BorrarEmpleado();*/ }
                else if (opcion == 5)
                {
                    Console.WriteLine("Saliendo del sistema...");
                }
                else
                {
                    Console.WriteLine("Error. Ingresa una opción entre 1 y 5");
                }
            }
        }

        public static void MenuVehiculos() // Imprime el menú para el crud de Vehículos
        {
            Console.WriteLine("Vehículos\n 1->Registrar\n 2->Consultar\n 3->Actualizar\n 4->Borrar\n 5->Volver");
        }

        public static void RegistrarBoleto()
        {
            int numero;
            Console.Clear();
            Console.WriteLine("Selecciona el cliente:");
            ImprimirClientes();
            string res = Console.ReadLine();
            if (int.TryParse(res, out numero))
            {
                int nResCliente = Convert.ToInt32(res);
                if (nResCliente >= 0 && nResCliente < listaClientes.Count) // Validando si el cliente ingresado existe (Si retorna true si existe)
                {
                    nResCliente = Convert.ToInt32(res);
                    Console.Clear();
                    Console.WriteLine($"Selecciona el empleado: ");
                    ImprimirEmpleados();
                    res = Console.ReadLine();
                    if (int.TryParse(res, out numero))
                    {
                        int nResEmpleado = Convert.ToInt32(res);
                        if (nResEmpleado >= 0 && nResEmpleado < listaEmpleados.Count) // Validando si el empleado ingresado existe (Si retorna true si existe)
                        {
                            nResEmpleado = Convert.ToInt32(res);

                            Console.Clear();
                            Console.WriteLine($"Selecciona el vehículo: ");
                            ImprimirVehiculos();
                            res = Console.ReadLine();
                            if (int.TryParse(res, out numero))
                            {
                                int nResVehiculo = Convert.ToInt32(res);
                                if (nResVehiculo >= 0 && nResVehiculo < listaVehiculos.Count) // Validando si el vehiculo ingresado existe (Si retorna true si existe)
                                {

                                    Boleto b = new Boleto(listaClientes[nResCliente], listaEmpleados[nResEmpleado], listaVehiculos[nResVehiculo]);
                                    listaBoletos.Add(b);
                                    Console.Clear();
                                    Console.WriteLine($"Se ha registrado el boleto para {b.Cliente.Nombre} {b.Cliente.Apellidos}" +
                                        $"\nCon el vehículo: {b.Vehiculo.Marca} {b.Vehiculo.Color} {b.Vehiculo.Placas}");
                                }
                                else
                                {
                                    Console.WriteLine("Vehiculo no encontrado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingresar solo Números.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Empleado no encontrado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingresar solo Números.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ingresar solo Números.");
            }
        }

        public static void EditarBoleto()
        {

        }

        public static void ImprimirBoleto(int numeroBoleto)
        {

            if (numeroBoleto >= 0 && numeroBoleto < listaBoletos.Count)
            {
                Console.WriteLine($"Cliente: {listaBoletos[numeroBoleto].Cliente.Nombre}" +
                $"\nAtendido por: {listaBoletos[numeroBoleto].Empleado.Nombre}" +
                $"\nVehículo: {listaBoletos[numeroBoleto].Vehiculo.Marca} {listaBoletos[numeroBoleto].Vehiculo.Color}" +
                $"\nHora de entrada: {listaBoletos[numeroBoleto].Fecha}\nPrecio: ${listaBoletos[numeroBoleto].Precio} pesos");
            }
            else
            {
                Console.WriteLine("No existe ese boleto");
            }
        }

        public static void ImprimirBoletos()
        {
            int cont = 1;
            foreach (Boleto boleto in listaBoletos)
            {
                Console.WriteLine($"Boleto: {cont}");
                Console.WriteLine($"Cliente: {boleto.Cliente.Nombre} {boleto.Cliente.Apellidos}" +
                    $"\nAtendido por: {boleto.Empleado.Nombre} {boleto.Empleado.Apellidos}" +
                    $"\nVehículo: {boleto.Vehiculo.Marca} {boleto.Vehiculo.Color}" +
                    $"\nHora de entrada: {boleto.Fecha}\nPrecio: ${boleto.Precio} pesos.\n - - - - - - - - - - - - - - - - - - - - -");
                cont++;
            }
        }

        public static void BorrarBoleto()
        {
            int numero = 10;
            Console.Clear();
            Console.WriteLine("Selecciona el boleto a borrar: ");
            ImprimirBoletos();
            string res = Console.ReadLine();
            if (int.TryParse(res, out numero))
            {
                int numeroBoleto = Convert.ToInt32(res);
                if (numeroBoleto >= 0 && numeroBoleto < listaBoletos.Count)
                {
                    Console.Clear();
                    Console.WriteLine($"El boleto {numeroBoleto}, del cliente {listaBoletos[numeroBoleto].Cliente.Nombre}, ha sido eliminado.");
                    listaBoletos.Remove(listaBoletos[numeroBoleto]);
                } else
                {
                    Console.Clear();
                    Console.WriteLine("No existe ese boleto");
                }

            }
        }

        public static void ImprimirClientes()
        {
            int cont = 0;
            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine($"Cliente: {cont}");
                Console.WriteLine($"{cliente.Nombre} {cliente.Apellidos} {cliente.Edad}");
                cont++;
            }
        }

        public static void RegistrarCliente(String nombre, string apellidos, int edad)
        {
            Cliente c = new Cliente(nombre, apellidos, edad);
            listaClientes.Add(c);
            Console.Clear();
            Console.WriteLine($"Se ha registrado el cliente {c.Nombre} {c.Apellidos}");
        }

        public static void ImprimirVehiculos()
        {
            foreach (Vehiculo v in listaVehiculos)
            {
                Console.WriteLine($" {v.Marca} {v.Color}");
            }
        }

        public static void RegistrarVehiculo(string placas, string marca, string color)
        {
            Vehiculo v = new Vehiculo(placas, marca, color);
            listaVehiculos.Add(v);
            Console.Clear();
            Console.WriteLine($"Se ha registrado el vehículo {v.Marca} {v.Color} con las placas {v.Placas}");
        }

        public static void RegistrarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Ingresa el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa apellidos: ");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Ingresa el cargo: ");
            string cargo = Console.ReadLine();
            Console.WriteLine("Ingresa el sueldo: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Empleado e = new Empleado(nombre, apellidos, cargo, sueldo);
            listaEmpleados.Add(e);
            Console.Clear();
            Console.WriteLine($"El empleado {e.Nombre} {e.Apellidos} ha sido registrado.");
        }

        public static void ImprimirEmpleados()
        {
            foreach (Empleado e in listaEmpleados)
            {
                Console.WriteLine($"Empleados\n {e.Nombre} {e.Apellidos}");
            }
        }
    }
}
