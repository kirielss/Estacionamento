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

            char resp;
            do
            {
                Console.WriteLine("Deseja adicionar um carro? s/n");
                resp = char.Parse(Console.ReadLine());

                if (resp == 's')
                {
                    Console.Write("Seu nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Modelo do carro: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Cor do carro: ");
                    string cor = Console.ReadLine();
                    Console.Write("Placa do carro: ");
                    string placa = Console.ReadLine();

                    Car carro = new Car(nome, modelo, cor, placa);
                    garagem.AddCar(carro);
                }

            } while (resp == 's');

            foreach (Car car in garagem.Veiculos)
            {
                Console.WriteLine(car);
            }

        }
    }
}