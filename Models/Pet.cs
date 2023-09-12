﻿using KalahariCollarV13.Areas.Identity.Data;

namespace KalahariCollarV13.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // Add the type property (e.g., "cat" or "dog")
                                         // Add other pet properties
        public string Breed { get; set; }
        public string OwnerId { get; set; }
        public string Location { get; set; } // Add the location property
                                             // Add other pet properties
       
        public ApplicationUser Owner { get; set; } // Navigation property to represent the owner
                                         // Add other pet properties
    }

}