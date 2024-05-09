using System;
using System.Collections.Generic;
using System.Linq;

namespace KomodoBadgeData
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; } // List to hold door names
        public string BadgeHolderName { get; set; }

        // Constructor to initialize the properties
        public Badge(int badgeID, List<string> doorNames, string badgeHolderName)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
            BadgeHolderName = badgeHolderName;
        }
    }
};