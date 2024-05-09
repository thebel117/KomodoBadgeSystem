using System; // Importing the System namespace which contains fundamental types and classes
using System.Collections.Generic; // Importing the namespace for working with collections
using System.Linq; // Importing the namespace for LINQ extension methods

namespace KomodoBadgeData // Declaring a namespace for the KomodoBadgeData
{
    public class BadgeRepository // Defining a class named BadgeRepository
    {
        private Dictionary<int, List<string>> _badges; // Declaring a private field to store badges as key-value pairs
        
// Key-value pairs are like labeling drawers-- the label (key) tells you  what's inside (value).
// ez way to organize data where each piece of data (value) is associated with a unique identifier (key).

        // Constructor to initialize the dictionary and badges
        public BadgeRepository()
        {
            _badges = new Dictionary<int, List<string>>(); // Initializing the dictionary that stores badges
            InitializeBadges(); // call the method to initialize seed data badges
        }
        private void InitializeBadges()
        {
            // seed data default badges with their IDs, door names, and owners
            AddBadge(101, new List<string> { "A1", "A2", "A3" }, "Hinge, Henry");
            AddBadge(102, new List<string> { "B1", "B2" }, "Dooring, Doris");
            AddBadge(103, new List<string> { "C1", "C2", "C3", "C4" }, "Enterman Earl");
        }

        // Method to add a new badge to the dictionary
        public void AddBadge(int badgeID, List<string> doorNames, string badgeOwner)
        {
            _badges.Add(badgeID, doorNames); // Adding a new badge to the dictionary with its ID and associated door names
        }

        // Method to update doors existing badge
        public void UpdateBadge(int badgeID, List<string> updatedDoorNames, string badgeOwner)
        {
            // ... check if the badge with the given ID exists in the dictionary
            if (_badges.ContainsKey(badgeID))
            {
                _badges[badgeID] = updatedDoorNames; // Updating  door names for the badge with the given ID
            }
            else
            {
                Console.WriteLine($"Badge with ID {badgeID} not found."); //prompt  if the badge is not found
            }
        }

        // Method to delete all doors from an existing badge
        public void DeleteAllDoors(int badgeID)
        {
            // see if the badge with the given ID is in  dictionary
            if (_badges.ContainsKey(badgeID))
            {
                _badges[badgeID].Clear(); // clears all door names associated with that badge
            }
            else
            {
                Console.WriteLine($"Badge with ID {badgeID} not found."); //  prompt  if the badge is not found
            }
        }

        // Method to show a list with all badge numbers and door access
        public void ShowAllBadges()
        {
            Console.WriteLine("Badge #\tDoor Access"); //  header for the list
            foreach (var badge in _badges) // Looping through each badge in the dictionary
            {
                // Displaying the badge number and its associated door names separated by commas, sep tabs
                Console.WriteLine($"{badge.Key}\t{string.Join(", ", badge.Value)}");
            }
        }
    }
}
