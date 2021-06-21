using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamiento
{
    class Vehiculo
    {

        public double TamMotor { get; set; }
        public int CantCilindros { get; set; }
        public string Placas { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }

        public Vehiculo(double tamMotor, int cantCilindros, string placas, string marca, string color)
        {
            this.TamMotor = tamMotor;
            this.CantCilindros = cantCilindros;
            this.Placas = placas;
            this.Marca = marca;
            this.Color = color;
        }

    }
}
