using System;
using System.Collections.Generic;

namespace _8._Car_Salesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = CreateEngine(engineInfo);
                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(carInfo,engines);

                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static Engine CreateEngine(string[] enginePropeties)
        {
            Engine engine = new Engine(enginePropeties[0], int.Parse(enginePropeties[1]));

            if (enginePropeties.Length > 2)
            {
                int displacement;

                var IsDigit = int.TryParse(enginePropeties[2], out displacement);

                if (IsDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = enginePropeties[2];
                }

                if (enginePropeties.Length > 3)
                {
                    engine.Efficiency = enginePropeties[3];
                }
            }

            return engine;
        }

        public static Car CreateCar(string[] carPropeties, List<Engine> engines)
        {
            Engine engine = engines.Find(x => x.Model == carPropeties[1]);

            Car car = new Car(carPropeties[0], engine);

            if (carPropeties.Length > 2)
            {
                int weight;

                var isDigit = int.TryParse(carPropeties[2], out weight);

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carPropeties[2];
                }

                if (carPropeties.Length > 3)
                {
                    car.Color = carPropeties[3];
                }
            }

            return car;
        }
    }
}
