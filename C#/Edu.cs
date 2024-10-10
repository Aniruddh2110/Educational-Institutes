// Author : Aniruddh Abhisheki
// Roll No : 7
// Title : Displaying the institutions details
// Start Date : 17/07/2024
// Modified Date : 24/07/2024
// Description : Finding Classes, Objects and Relation between the institutions

using System;
using System.Collections.Generic;

public class Institution
{
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Act { get; set; }
    public string Ministry { get; set; }
}

class Program
{
    static void DisplayInstitution(Institution inst)
    {
        Console.WriteLine("Name : " + inst.Name);
        Console.WriteLine("City : " + inst.City);
        Console.WriteLine("State : " + inst.State);
        Console.WriteLine("Act : " + inst.Act);
        Console.WriteLine("Ministry : " + inst.Ministry);
        Console.WriteLine("----------------------------------");
    }

    static void SearchByCity(List<Institution> institutions, string city)
    {
        bool found = false;
        foreach (var inst in institutions)
        {
            if (inst.City.Equals(city, StringComparison.OrdinalIgnoreCase))
            {
                DisplayInstitution(inst);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No institutions found in " + city);
        }
    }

    static void SearchByState(List<Institution> institutions, string state)
    {
        bool found = false;
        foreach (var inst in institutions)
        {
            if (inst.State.Equals(state, StringComparison.OrdinalIgnoreCase))
            {
                DisplayInstitution(inst);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No institutions found in " + state);
        }
    }

    static void Main(string[] args)
    {
        List<Institution> institutions = new List<Institution>
        {
            new Institution { Name = "Aligarh Muslim University", City = "Aligarh", State = "Uttar Pradesh", Act = "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", Ministry = "Ministry of Education" },
            new Institution { Name = "Banaras Hindu University", City = "Varanasi", State = "Uttar Pradesh", Act = "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", Ministry = "Ministry of Education" },
            new Institution { Name = "University of Delhi", City = "Delhi", State = "Delhi", Act = "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", Ministry = "Ministry of Education" }
        };

        int choice;
        string searchCity, searchState;

        do
        {
            Console.WriteLine("========== Institutions ==========");
            Console.WriteLine("1. Search by city");
            Console.WriteLine("2. Search by state");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice! Please enter again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter city to search: ");
                    searchCity = Console.ReadLine();
                    SearchByCity(institutions, searchCity);
                    break;
                case 2:
                    Console.Write("Enter state to search: ");
                    searchState = Console.ReadLine();
                    SearchByState(institutions, searchState);
                    break;
                case 3:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter again.");
                    break;
            }
        } while (choice != 3);
    }
}
