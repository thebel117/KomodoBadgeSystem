using System;
using KomodoBadgeData;

namespace BadgeApp
{
    public class ProgramUI
    {
        private BadgeRepository _badgeRepository = new BadgeRepository(); //  instance of BadgeRepository

        public void Run()
        {
            Console.WriteLine("Welcome to the Komodo Employee Badge System!");

            while (true) // Looping forever..!
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Add a new badge");
                Console.WriteLine("2. Update doors on an existing badge");
                Console.WriteLine("3. Delete all doors from an existing badge");
                Console.WriteLine("4. Show a list with all badge numbers and their door access");
                Console.WriteLine("5. Exit Badge System");

                // Asking user for input
                Console.Write("\nEnter your choice: ");
                string? choice = Console.ReadLine(); 
                Console.Clear(); 

                switch (choice)
                {
                    case "1":
                        AddNewBadge();
                        break;
                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        DeleteAllDoors();
                        break;
                    case "4":
                        ShowAllBadges();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return; //
                    default:
                        Console.WriteLine("Invalid choice. Please enter an option from the list above.");
                        break;
                }
            }
        }

        // Method to add a new badge
        private void AddNewBadge()
        {
            Console.WriteLine("Adding a new badge:");
            // Getting badge ID from user
            Console.Write("Enter the badge number (e.g. 101, 102, 103...): ");
            int badgeID = int.Parse(Console.ReadLine());

            // Getting door names from user
            Console.WriteLine("Enter the accessible door names separated by commas (e.g., A1, B2, C3...): ");
            string? doorNamesString = Console.ReadLine();
            List<string> doorNames = doorNamesString.Split(',').Select(s => s.Trim()).ToList(); // !Split the input string based on commas and create an array of substrings
//                                                                                                 !Trim any leading or trailing whitespace from each substring and convert the array to a list

            // Getting badge owner from user
            Console.Write("Enter the badge owner's name ('LastName, FirstName'): ");
            string? badgeOwner = Console.ReadLine();

            // Adding the badge
            _badgeRepository.AddBadge(badgeID, doorNames, badgeOwner);
            Console.WriteLine("Badge added successfully!"); // Confirming badge addition
        }

        // Method to update doors on an existing badge
        private void UpdateBadge()
        {
            Console.WriteLine("Updating doors on an existing badge:");
            // Getting badge ID from user
            Console.Write("Enter the 3-digit badge number to update: ");
            int badgeID = int.Parse(Console.ReadLine());

            // Getting updated door names from user
            Console.WriteLine("Enter the updated door names separated by commas (e.g., A1, B2, C3): ");
            string? updatedDoorNamesString = Console.ReadLine();
            List<string> updatedDoorNames = updatedDoorNamesString.Split(',').Select(s => s.Trim()).ToList();

            // Getting badge owner from user
            Console.Write("Enter the badge owner's name: ");
            string? badgeOwner = Console.ReadLine();

            // Updating the badge
            _badgeRepository.UpdateBadge(badgeID, updatedDoorNames, badgeOwner);
            Console.WriteLine("Badge updated successfully."); 
        }

        private void DeleteAllDoors()
        {
            Console.WriteLine("Deleting all doors from an existing badge:");
            // Getting badge ID from user
            Console.Write("Enter the badge number to delete doors from: ");
            int badgeID = int.Parse(Console.ReadLine());

            // deletes ALL doors from the badge
            _badgeRepository.DeleteAllDoors(badgeID);
            Console.WriteLine("All doors deleted from the badge successfully."); // Confirming deletion
        }
        private void ShowAllBadges()
        {
            Console.WriteLine("Showing a list with all badge numbers and door access:");
            _badgeRepository.ShowAllBadges(); // Displaying all badges and their door access
        }
    }
}
