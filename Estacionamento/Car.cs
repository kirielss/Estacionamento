using System;

namespace Estacionamento
{
    internal class Car
    {
        public string Owner { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public string License { get; set; }


        public Car(string owner, string brand, string color, string license)
        {
            Owner = owner;
            Brand = brand;
            Color = color;
            License = license;
        }

        public override string ToString()
        {
            return "Dono: " + Owner + " / Marca: " + Brand + " / Cor: " + Color + " / Placa: " + License;
        }

    }
}
