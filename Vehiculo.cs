using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamiento
{
    class Vehiculo
    {

        public string Placas { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }

        public Vehiculo(string placas, string marca, string color)
        {
            this.Placas = placas;
            this.Marca = marca;
            this.Color = color;
        }

    }
}
