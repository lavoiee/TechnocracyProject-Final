using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnocracyProject
{
    /// <summary>
    /// static class to hold all npc objects
    /// </summary>
    public static partial class UniverseObjects
    {
        public static List<Npc> Npcs = new List<Npc>()
        {
            new Civilian
            {
                Id = 1,
                Name = "Imperial Secret Police Cmd.",
                SpaceTimeLocationID = 2,
                Description = "A stocky battle scared soldier from the Earth conflict two imperial cycles ago.",
                Messages = new List<string>
                {
                    "Greetings Sir. You know I can have you vaporized for any reason don't you?",
                    "So long as you do as you are told, you will have no problems from us.",
                    "Don't try to get slick though, we are everywhere."
                }
            },

            new Civilian
            {
                Id = 6,
                Name = "Jen Italia",
                SpaceTimeLocationID = 1,
                Description = "Working girl, just trying to get by.",
                Messages = new List<string>
                {
                    "You look like you could use a massage.",
                    "You know, I was trained by the best and I can make all of your worries go away.",
                    "Here is my card. Call me if you would like a break from life."
                }
            },

            new Civilian
            {
                Id = 6,
                Name = "Mark",
                SpaceTimeLocationID = 2,
                Description = "Intelligence operative working for the Rebel Alliance.",
                Messages = new List<string>
                {
                    "We know who you work for.",
                    "We are eventually going to overthrow the corrupt Imperium.",
                    "You should come over to our side. We will pay you well and you will be given your own planet."
                }
            }
        };
    }
}
