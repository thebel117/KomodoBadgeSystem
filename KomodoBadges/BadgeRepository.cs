using System;
using System.Collections.Generic;
using System.Linq;

namespace KomodoBadgeData
{
public class BadgeRepository
    {
        private Dictionary<int, List<string>> _badges; // Dictionary to store badges

        // Constructor to initialize the dictionary
        public BadgeRepository()
        {
            _badges = new Dictionary<int, List<string>>();
            InitializeBadges();
        }

        private void InitializeBadges()
        {
            AddBadge(101, new List<string> { "A1", "A2", "A3" }, "Henry Hing");
            AddBadge(102, new List<string> { "B1", "B2" }, "Doris Dooring");
            AddBadge(103, new List<string> { "C1", "C2", "C3", "C4" }, "Earl Enterman");
        }


        // Method to add a new badge
        public void AddBadge(int badgeID, List<string> doorNames, string badgeOwner)
        {
            _badges.Add(badgeID, doorNames);
        }

        // Method to update doors on an existing badge
        public void UpdateBadge(int badgeID, List<string> updatedDoorNames, string badgeOwner)
        {
            if (_badges.ContainsKey(badgeID))
            {
                _badges[badgeID] = updatedDoorNames;
            }
            else
            {
                Console.WriteLine($"Badge with ID {badgeID} not found.");
            }
        }

        // Method to delete all doors from an existing badge
        public void DeleteAllDoors(int badgeID)
        {
            if (_badges.ContainsKey(badgeID))
            {
                _badges[badgeID].Clear();
            }
            else
            {
                Console.WriteLine($"Badge with ID {badgeID} not found.");
            }
        }

        // Method to show a list with all badge numbers and door access
        public void ShowAllBadges()
        {
            Console.WriteLine("Badge #\tDoor Access");
            foreach (var badge in _badges)
            {
                Console.WriteLine($"{badge.Key}\t{string.Join(", ", badge.Value)}");
            }
        }
    }
};