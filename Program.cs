using BusSimulator;
using System;

// class menu
class Menu
{
    public static void Main(string[] args)
    {
        var myBus = new Bus();
        myBus.Run();

        int menu = 0;

        do
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Bus Simulator Menu:");
            Console.WriteLine("1. Add passengers");
            Console.WriteLine("2. Print bus passengers");
            Console.WriteLine("3. Calculate total age of passengers");
            Console.WriteLine("4. Calculate average age of passengers");
            Console.WriteLine("5. Find the oldest passenger");
            Console.WriteLine("6. Find a specific age");
            Console.WriteLine("7. Sort passengers by age");
            Console.WriteLine("0. Exit the program");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Enter your choice (0-7):");
            menu = int.Parse(Console.ReadLine()); // Read the user's choice from the console

            switch (menu)
            {
                case 1:
                    myBus.AddPassenger(); // Invoke the AddPassenger method to add passengers
                    break;
                case 2:
                    myBus.PrintBus(); // Invoke the PrintBus method to print the passengers' ages
                    break;
                case 3:
                    myBus.CalculateTotalAge(); // Invoke the CalculateTotalAge method to calculate the total age of passengers
                    break;
                case 4:
                    myBus.CalculateAverageAge(); // Invoke the CalculateAverageAge method to calculate the average age of passengers
                    break;
                case 5:
                    myBus.FindOldestPassengerAge(); // Invoke the FindOldestPassengerAge method to find the oldest passenger's age
                    break;
                case 6:
                    Console.WriteLine("Enter an age to search for:");
                    int searchAge = int.Parse(Console.ReadLine());
                    myBus.FindAge(searchAge); // Invoke the FindAge method to search for a specific age among passengers
                    break;
                case 7:
                    myBus.SortPassengers(); // Invoke the SortPassengers method to sort the passengers' ages
                    break;
                case 0:
                    Console.WriteLine("Exiting the program..."); // Exit the program
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again."); // Handle invalid choices
                    break;
            }

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(true); // Wait for user input before displaying the menu again
        } while (menu != 0); // Continue the loop until the user chooses to exit the program
    }
}
namespace BusSimulator
{
    // Class representing a bus
    class Bus
    {
        public int[] passengers; // Array to store passenger ages
        public int passengerCount; // Number of passengers

        // Method to run the bus simulator
        public void Run()
        {
            Console.WriteLine("Welcome to the Bus Simulator");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(true);
        }

        // Method to add passengers to the bus
        public void AddPassenger()
        {
            Console.WriteLine("How many passengers do you want to add?");
            int size = int.Parse(Console.ReadLine());

            passengers = new int[size];

            // Loop to input age for each passenger
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the age of passenger " + (i + 1) + ":");
                int age = int.Parse(Console.ReadLine());
                passengers[i] = age;
            }

            passengerCount += size;
        }

        // Method to print the ages of the bus passengers
        public void PrintBus()
        {
            Console.WriteLine("Ages of the bus passengers:");
            for (int i = 0; i < passengerCount; i++)
            {
                Console.WriteLine("Passenger " + (i + 1) + ": " + passengers[i] + " years old");
            }
        }

        // Method to calculate the total age of the passengers
        public int CalculateTotalAge()
        {
            int sum = 0;
            for (int i = 0; i < passengerCount; i++)
            {
                sum += passengers[i];
            }
            Console.WriteLine("Total age of passengers: " + sum);
            return sum;
        }

        // Method to calculate the average age of the passengers
        public double CalculateAverageAge()
        {
            int totalAge = CalculateTotalAge();
            double averageAge = (double)totalAge / passengerCount;
            Console.WriteLine("Average age of passengers: " + averageAge);
            return averageAge;
        }

        // Method to find the maximum age among the passengers
        public int FindOldestPassengerAge()
        {
            int maxValue = passengers[0];
            for (int i = 1; i < passengerCount; i++)
            {
                if (passengers[i] > maxValue)
                {
                    maxValue = passengers[i];
                }
            }
            Console.WriteLine("Oldest passenger age: " + maxValue);
            return maxValue;
        }

        // Method to find a specific age among the passengers
        public void FindAge(int age)
        {
            bool found = false;
            for (int i = 0; i < passengerCount; i++)
            {
                if (passengers[i] == age)
                {
                    Console.WriteLine("Age " + age + " found in passengers.");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Age " + age + " not found in passengers.");
            }
        }

        // Method to sort the passengers by age
        public void SortPassengers()
        {
            Array.Sort(passengers);
            Console.WriteLine("Passengers sorted by age:");
            PrintBus();
        }
    }


}