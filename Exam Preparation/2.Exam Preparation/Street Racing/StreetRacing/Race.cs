using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Participants = new List<Car>();
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }

        public List<Car> Participants { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public int Count { get { return Participants.Count; } }

        public void Add(Car car)
        {
            if (!Participants.Any(p => p.LicensePlate == car.LicensePlate) && Participants.Count < Capacity && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car);
            }
        }

        public bool Remove(string licensePlate)
        {
            if (Participants.Any(p => p.LicensePlate == licensePlate))
            {
                Participants.Remove(Participants.Find(p => p.LicensePlate == licensePlate));
                return true;
            }

            return false;
        }

        public Car FindParticipant(string licensePlate)
        {
            if (Participants.Any(p => p.LicensePlate == licensePlate))
            {
                return Participants.Find(p => p.LicensePlate == licensePlate);
            }

            return null;
        }

        public Car GetMostPowerfulCar()
        {
            if (Participants.Any())
            {
                Car mostPowerfulCar = Participants.OrderByDescending(p => p.HorsePower).First();
                return mostPowerfulCar;
            }

            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");

            foreach (Car car in Participants)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
