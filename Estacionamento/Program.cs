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
                new Car("Mario", "Kart", "White", "ITS8471"),
            };

            foreach (Car car in cars)
            {
                garagem.AddCar(car);
            }

            Console.WriteLine("BEM VINDO À GARAGEM DO GABRIEL! SEGUEM ABAIXO OS CARROS CONOSCO HOJE:" + Environment.NewLine);
            foreach (Car car in garagem.Veiculos)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
            char resp;
            do
            {
                Console.WriteLine("Deseja ADICIONAR um carro? ('s' para confirmar) ");
                resp = char.Parse(Console.ReadLine().ToLower());

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
                    Console.WriteLine("ADICIONADO!");
                    Console.WriteLine();
                }

            } while (resp == 's');

            do
            {
                Console.WriteLine("Deseja REMOVER um carro? ('s' para confirmar) ");
                resp = char.Parse(Console.ReadLine().ToLower());

                if (resp == 's')
                {
                    Console.WriteLine("Digite o NÚMERO DA PLACA para encontrarmos seu carro");
                    string placa = Console.ReadLine();
                    if (garagem.SearchCar(placa) != null)
                    {
                        garagem.RemoveCar(garagem.SearchCar(placa));
                        Console.WriteLine("REMOVIDO!");
                    } else
                    {
                        Console.WriteLine("Opa! Essa placa não consta no nosso banco de dados!");
                    }
                    Console.WriteLine();
                }

            } while (resp == 's');

            Console.WriteLine();
            Console.WriteLine("NOSSA GARAGEM HOJE FECHA COM OS SEGUINTES CARROS:" + Environment.NewLine);
            foreach (Car car in garagem.Veiculos)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
            Console.WriteLine("OBRIGADO PELA PRESENÇA E ATÉ AMANHÃ!");

        }
    }
}