using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameAndAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string fullName = nameAndAdress[0] + " " + nameAndAdress[1];
            string addres = nameAndAdress[2];
            string town = nameAndAdress[3];
            TupleClass<string, string, string> firstTuple = new TupleClass<string, string, string>(fullName, addres, town);
            Console.WriteLine(firstTuple);

            string[] nameAndBeerLiters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = nameAndBeerLiters[0];
            int liters = int.Parse(nameAndBeerLiters[1]);
            string isDrunk = nameAndBeerLiters[2];
            TupleClass<string, int, bool> secondTuple = new TupleClass<string, int, bool>(name, liters, isDrunk == "drunk");
            Console.WriteLine(secondTuple);

            string[] integerAndDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string personName = integerAndDouble[0];
            double _double = double.Parse(integerAndDouble[1]);
            string bankName = integerAndDouble[2];
            TupleClass<string, double, string> thirdTuple = new TupleClass<string, double, string>(personName, _double, bankName);
            Console.WriteLine(thirdTuple);
        }
    }
}
