using System;

namespace Estacionamento
{
    class program
    {
        static void Main(string[] args)
        {
            Park garagem = new Park();

            List<Car> cars = new List<Car>()
            {
                new Car("Cleiton", "Ford", "Yellow", "AWX2070"),
                new Car("Francisca", "Fiat", "Silver", "BYA8807"),
                new Car("Roberval", "Uno", "Black", "UYY0069"),
                new Car("Cloud", "Fenrir", "Black", "SOL6137"),
                new Car("Mario", "Kart", "White", "ITS84710"),
            };

            foreach (Car car in cars)
            {
                garagem.AddCar(car);
            }

            foreach (Car car in garagem.Veiculos)
            {
                Console.WriteLine(car);
            }



        }
    }
}