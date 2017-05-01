using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnocracyProject
{
    public static class ActionMenu
    {
        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, AdamaAction>()
                    {
                        { ' ', AdamaAction.None }
                    }
        };

        public enum CurrentMenu
        {
            MissionIntro,
            InitializeMission,
            MainMenu,
            ObjectMenu,
            NpcMenu,
            TravelerMenu,
            AdminMenu
        };

        public static CurrentMenu currentMenu = CurrentMenu.MainMenu;

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, AdamaAction>()
                {
                    { '1', AdamaAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, AdamaAction>()
                {
                    { '1', AdamaAction.LookAround },
                    { '2', AdamaAction.Travel },
                    { '3', AdamaAction.ObjectMenu },
                    { '4', AdamaAction.NonplayerCharacterMenu},
                    { '5', AdamaAction.TravelerMenu},
                    { '6', AdamaAction.AdminMenu },
                    { '0', AdamaAction.Exit }
                }
        };

        public static Menu AdminMenu = new Menu()
        {
            MenuName = "AdminMenu",
            MenuTitle = "Admin Menu",
            MenuChoices = new Dictionary<char, AdamaAction>()
                {
                    { '1', AdamaAction.ListSpaceTimeLocations },
                    { '2', AdamaAction.ListGameObjects},
                    { '3', AdamaAction.ListNonPlayerCharacters},
                    { '0', AdamaAction.ReturnToMainMenu }
                }
        };

        public static Menu TravelerMenu = new Menu()
        {
            MenuName = "TravelerMenu",
            MenuTitle = "Traveler Menu",
            MenuChoices = new Dictionary<char, AdamaAction>()
                {
                    { '1', AdamaAction.AdamaInfo },
                    { '2', AdamaAction.Inventory},
                    { '3', AdamaAction.AdamaLocationsVisited},
                    { '0', AdamaAction.ReturnToMainMenu }
                }
        };

        public static Menu ObjectMenu = new Menu()
        {
            MenuName = "ObjectMenu",
            MenuTitle = "Object Menu",
            MenuChoices = new Dictionary<char, AdamaAction>()
                {
                    { '1', AdamaAction.LookAt },
                    { '2', AdamaAction.PickUp},
                    { '3', AdamaAction.PutDown},
                    { '0', AdamaAction.ReturnToMainMenu }
                }
        };

        public static Menu NpcMenu = new Menu()
        {
            MenuName = "NpcMenu",
            MenuTitle = "NPC Menu",
            MenuChoices = new Dictionary<char, AdamaAction>()
                {
                    { '1', AdamaAction.TalkTo},
                    { '0', AdamaAction.ReturnToMainMenu }
                }
        };

        //public static Menu ManageTraveler = new Menu()
        //{
        //    MenuName = "ManageTraveler",
        //    MenuTitle = "Manage Adama",
        //    MenuChoices = new Dictionary<char, AdamaAction>()
        //            {
        //                AdamaAction.MissionSetup,
        //                AdamaAction.AdamaInfo,
        //                AdamaAction.Exit
        //            }
        //};
    }
}
