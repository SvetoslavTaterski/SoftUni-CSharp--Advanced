using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;

        public List<Ski> Data
        {
            get { return data; }
            set { data = value; }
        }


        public SkiRental(string name, int capacity)
        {
            Data = new List<Ski>();
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Data.Count; } }

        public void Add(Ski ski)
        {
            if (Data.Count < Capacity)
            {
                Data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (Data.Any(s => s.Manufacturer == manufacturer && s.Model == model))
            {
                Data.Remove(Data.Find(s => s.Manufacturer == manufacturer && s.Model == model));
                return true;
            }

            return false;
        }

        public Ski GetNewestSki()
        {
            if (Data.Any())
            {
                return Data.OrderByDescending(s => s.Year).First();
            }

            return null;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            if (Data.Any(s => s.Manufacturer == manufacturer && s.Model == model))
            {
                return Data.Find(s => s.Manufacturer == manufacturer && s.Model == model);
            }

            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");

            foreach (Ski ski in Data)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
