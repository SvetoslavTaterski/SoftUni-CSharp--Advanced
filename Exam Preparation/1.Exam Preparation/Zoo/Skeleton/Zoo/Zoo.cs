using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> animals;
        private string name;
        private int capacity;

        public Zoo(string name, int capacity)
        {
            animals = new List<Animal>();
            Name = name;
            Capacity = capacity;
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }

            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }

            if (animals.Count >= Capacity)
            {
                return "The zoo is full.";
            }

            animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int countOfRemovedAnimals = animals.Count;

            animals.RemoveAll(a => a.Species == species);

            countOfRemovedAnimals -= animals.Count;

            return countOfRemovedAnimals;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            var listByDiet = new List<Animal>(animals.Where(a => a.Diet == diet));

            return listByDiet;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            Animal firstAnimalFount = animals.FirstOrDefault(a => a.Weight == weight);

            return firstAnimalFount;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;

            foreach (Animal animal in animals)
            {
                if (animal.Length >= minimumLength && animal.Length <= maximumLength)
                {
                    count++;
                }
            }

            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
