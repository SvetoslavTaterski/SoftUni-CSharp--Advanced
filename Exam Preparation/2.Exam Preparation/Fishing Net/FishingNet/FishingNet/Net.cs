using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private readonly List<Fish> fish;
        public List<Fish> Fish { get { return fish; } }
        public string Material { get; set; }
        public int Capacity { get; set; }

        public Net(string material, int capacity)
        {
            fish = new List<Fish>();
            Material = material;
            Capacity = capacity;
        }

        public int Count { get { return fish.Count; } }

        public string AddFish(Fish fish)
        {
            if (Fish.Count == Capacity)
            {
                return "Fishing net is full.";
            }

            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Weight <= 0 || fish.Length <= 0)
            {
                return "Invalid fish.";
            }

            Fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            if (Fish.Any(f => f.Weight == weight))
            {
                Fish.Remove(Fish.Find(f => f.Weight == weight));
                return true;
            }

            return false;
        }

        public Fish GetFish(string fishType)
        {
            return Fish.Find(f => f.FishType == fishType);
        }

        public Fish GetBiggestFish()
        {
            return Fish.OrderByDescending(f => f.Length).First();
        }

        public string Report()
        {
            var orderedFish = new List<Fish>(Fish.OrderByDescending(f => f.Length));
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Into the {Material}:");
            foreach (Fish fish in orderedFish)
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
