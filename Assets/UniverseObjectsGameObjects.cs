using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnocracyProject.Assets
{
    public static partial class UniverseObjectsGameObjects
    {
        public static List<GameObject> gameObjects = new List<GameObject>()
        {
            new TravelerObject
            {
                Id = 1,
                Name = "IR-4 Rifle.",
                SpaceTimeLocationID = 2,
                Description = "Standard Imperial Issue phaser rifle.",
                Type = TravelerObjectType.Weapon,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 2,
                Name = "I-Com Radio",
                SpaceTimeLocationID = 3,
                Description = "Standard Imperial communication device.",
                Type = TravelerObjectType.Electronics,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 3,
                Name = "CG-3 Canister",
                SpaceTimeLocationID = 3,
                Description = "Gaseous chemical weapon's canister.",
                Type = TravelerObjectType.Weapon,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 4,
                Name = "Imperial Identification",
                SpaceTimeLocationID = 2,
                Description = 
                    "Name: Agent X" + "\n" +
                    "Security Clearance: Cosmic" + "\n" +
                    "\n" +
                    "Holder of this card not subject to the laws of the Imperium.",
                Type = TravelerObjectType.Information,
                Value = 100,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 8,
                Name = "Cyanide Capsule",
                SpaceTimeLocationID = 0,
                Description =
                    "Capsule of Last Resort.",
                Type = TravelerObjectType.Medicine,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 9,
                Name = "IX-42 Anti-matter charge.",
                SpaceTimeLocationID = 0,
                Description =
                    "Planetary demolition charge.",
                Type = TravelerObjectType.Weapon,
                Value = 500,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 10,
                Name = "I-Com Encryption Device",
                SpaceTimeLocationID = 0,
                Description =
                    "Quantum encryption plugin for I-Com Radio.",
                Type = TravelerObjectType.Food,
                Value = 200,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            }

        };
    }
}
