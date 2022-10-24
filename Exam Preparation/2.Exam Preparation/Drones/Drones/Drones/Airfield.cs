using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Drones = new List<Drone>();
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
        }

        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public int Count { get { return Drones.Count; } }

        public string AddDrone(Drone drone)
        {
            if (Drones.Count == Capacity)
            {
                return "Airfield is full.";
            }

            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            if (Drones.Any(d => d.Name == name))
            {
                Drones.Remove(Drones.Find(d => d.Name == name));
                return true;
            }

            return false;
        }

        public int RemoveDroneByBrand(string brand)
        {
            if (Drones.Any(d => d.Brand == brand))
            {
                int removedDrones = Drones.Count;
                Drones.RemoveAll(d => d.Brand == brand);

                return removedDrones - Drones.Count;
            }

            return 0;
        }

        public Drone FlyDrone(string name)
        {
            if (Drones.Any(d => d.Name == name))
            {
                Drones.Find(d => d.Name == name).Available = false;
                return Drones.Find(d => d.Name == name);
            }

            return null;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> flyDrones = new List<Drone>(Drones.Where(d => d.Range >= range));

            foreach (var drone in flyDrones)
            {
                drone.Available = false;
            }

            return flyDrones;
        }

        public string Report()
        {
            var dronesNotInFlight = new List<Drone>(Drones.Where(d => d.Available == true));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");

            foreach (Drone drone in dronesNotInFlight)
            {
                sb.AppendLine(drone.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
