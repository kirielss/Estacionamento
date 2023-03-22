using System;
using System.Globalization;

namespace Estacionamento
{
    internal class Park
    {
        public double Taxa { get; private set; }

        public List<Car> Veiculos { get; private set; }

        public Park()
        {
            Veiculos = new List<Car>();
        }

        public void AddCar(Car carro )
        {
            Veiculos.Add( carro );
        }

        public void RemoveCar(Car carro)
        {
            Veiculos.Remove( carro );
        }

        public Car SearchCar(string license)
        {
            return Veiculos.Find(x => x.License == license);
        }


    }
}
