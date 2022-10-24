using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;

        public Catalog(string name, int neededRenovators, string project)
        {
            renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public string Project
        {
            get { return project; }
            set { project = value; }
        }


        public int NeededRenovators
        {
            get { return neededRenovators; }
            set { neededRenovators = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Renovator> Renovators
        {
            get { return renovators; }
            set { renovators = value; }
        }

        public int Count { get { return Renovators.Count; } }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }

            if (Renovators.Count >= NeededRenovators)
            {
                return "Renovators are no more needed.";
            }

            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            Renovators.Add(renovator);

            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            if (Renovators.Any(r => r.Name == name))
            {
                Renovators.RemoveAt(Renovators.FindIndex(r => r.Name == name));
                return true;
            }

            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int removedRenovators = Renovators.Count;

            if (Renovators.Any(r => r.Type == type))
            {
                Renovators.RemoveAll(r => r.Type == type);
                removedRenovators -= Renovators.Count;
                return removedRenovators;
            }

            return 0;
        }

        public Renovator HireRenovator(string name)
        {
            if (Renovators.Any(r => r.Name == name))
            {
                Renovators.Find(r => r.Name == name).Hired = true;
                return Renovators.Find(r => r.Name == name);
            }

            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> workingRenovators = Renovators.Where(r => r.Days >= days).ToList();
            return workingRenovators;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {project}:");

            foreach (var item in Renovators.Where(r => r.Hired == false))
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
