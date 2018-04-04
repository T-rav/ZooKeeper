using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeper.Animals;

namespace ZooKeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuItem = "0";
            var animals = new List<Critter>();

            while (UserSelectAnimalToCreate(menuItem))
            {
                PrintMenu();
                menuItem = ReadUserSelection();

                if (UserSelectedExit(menuItem))
                {
                    ExitApplication();
                }

                var animalDetails = GetAnimalDetails();
                var animal = CreateAnimal(menuItem, animalDetails);

                PrintNewAnimalDetails(animal);
            }
        }

        private static void ExitApplication()
        {
            Environment.Exit(1);
        }

        private static bool UserSelectedExit(string menuItem)
        {
            return menuItem == "5";
        }

        private static string ReadUserSelection()
        {
            return Console.ReadLine();
        }

        private static Critter CreateAnimal(string selection, AnimalTo animalDetails)
        {
            if (selection == "1")
            {
                return new Frog(animalDetails.Age, animalDetails.Color);
            }
            if (selection == "2")
            {
                return new Zebra(animalDetails.Age, animalDetails.Color);
            }
            if (selection == "3")
            {
                return new Rabbit(animalDetails.Age, animalDetails.Color);
            }

            return new Elephant(animalDetails.Age, animalDetails.Color);
        }

        private static bool UserSelectAnimalToCreate(string selection)
        {
            return selection != "5";
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Which animal would you like to create");
            Console.WriteLine("1. Frog");
            Console.WriteLine("2. Zebra");
            Console.WriteLine("3. Rabbit");
            Console.WriteLine("4. Elephant");
            Console.WriteLine("5. Exit");
            Console.Write("?:");
        }

        private static AnimalTo GetAnimalDetails()
        {
            Console.WriteLine("What age is the animal?");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("What color is the animal?");
            var color = Console.ReadLine();
            return new AnimalTo{Age = age, Color = color};
        }

        private static void PrintNewAnimalDetails(Critter animal)
        {
            Console.WriteLine($"Your animal eats:");
            animal.Eats();
            Console.WriteLine("And moves: ");
            animal.Movement();
            Console.WriteLine();
        }
    }
}
