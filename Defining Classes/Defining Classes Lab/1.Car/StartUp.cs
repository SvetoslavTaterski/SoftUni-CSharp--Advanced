using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tireList = new List<Tire[]>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "No more tires")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int year = int.Parse(tokens[0]);
                double pressure = double.Parse(tokens[1]);
                int year2 = int.Parse(tokens[2]);
                double pressure2 = double.Parse(tokens[3]);
                int year3 = int.Parse(tokens[4]);
                double pressure3 = double.Parse(tokens[5]);
                int year4 = int.Parse(tokens[6]);
                double pressure4 = double.Parse(tokens[7]);

                Tire[] carTires = new Tire[4]
                {
                    new Tire(year,pressure),
                    new Tire(year2,pressure2),
                    new Tire(year3,pressure3),
                    new Tire(year4,pressure4)
                };

                tireList.Add(carTires);
            }

            List<Engine> listOfEngines = new List<Engine>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Engines done")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                listOfEngines.Add(new Engine(horsePower, cubicCapacity));
            }

            List<Car> listOfCars = new List<Car>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Show special")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption,
                    listOfEngines[engineIndex], tireList[tiresIndex]);
                listOfCars.Add(car);
            }

            foreach (Car car in listOfCars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330)
                {
                    double tirePressureSum = 0;
                    foreach (Tire tire in car.Tires)
                    {
                        tirePressureSum += tire.Pressure;
                    }
                    if (tirePressureSum >= 9 && tirePressureSum <= 10)
                    {
                        car.Drive(20);
                        Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
                    }
                }
            }
        }
    }
}
