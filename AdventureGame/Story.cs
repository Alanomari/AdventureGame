using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AdventureGame
{
    class Story
    {
        //skapar ny instans av spelaren här så att varje gång vi vill kalla på spelaren användar vi oss utav denna instansen
        public static Player player = new Player();
        
        public static void storyStart()
        {
            clean();
            Console.ForegroundColor = ConsoleColor.White;
            Game.Print("What is your name?");
            player.name = Console.ReadLine();

            Console.Clear();
            Game.Print("You awake and everything is dark......");
            Story.pressToContinue();
            clean();
            Game.Print("You start fumbling around in the darkness to try and find out where you are");
            Game.Print("After awhile you start adapting to the darkness and you realize you're in a room, you start to survey your surroundings");
            Game.Print("The room is completely empty except for a sword and a backpack, but there's something written on the wall");
            Game.Print("On the wall you notice the numbers 01");
            Game.Print("You pick up the sword and backpack and go towards the door");
            pressToContinue();
            clean();


        }
        public static void storyFightOne()
        {
            Game.Print("You open the door and before you stands another person with a sword in hand!");
            Game.Print("Before you manage to say anything the stranger lunges towards you with the sword ");
            Story.pressToContinue();
            Console.Clear();
            Game.Print("You barely manage to pull your sword up in time to block his strike!");
            Game.Print("I have to defeat you in order to proceed to the next room! the stranger says as he tries to lunge at you again!");
            Story.pressToContinue();
            Console.Clear();
            Game.Print("You tell the stranger that you dont want to hurt him but that you will defend yourself at all costs");
            Game.Print("Only one of us can exit this room alive! The stranger says");
            Story.pressToContinue();
            Console.Clear();
            Game.Print("You notice that the number 02 is on the wall of this room indicating you have progressed one room");
            Game.Print("It seems the only way out of this place is to progress through the rooms");
            Game.Print("As your thinking about where you are and how you should proceed the stranger charges at you again!");
            Story.pressToContinue();
            Console.Clear();
        }
        public static void storyBossOne()
        {
            Console.Clear();
            Game.Print("You go to the door and open it to progress to the next room...");
            Game.Print("Upon entering the room you see a man in a chair with his back turned towards you, hearing the door creak open he turns around and says");
            Game.Print("Umpa Dumpa, I am The Krarumpa");
            Console.WriteLine("");
            Game.Print("Before you manage to process what he just said he gets up from the chair");
            Console.ForegroundColor = ConsoleColor.Red;
            Game.Print("He yells: NOOT NOOT MOTHERFUCKER! as he comes charging towards you!");
            Console.ForegroundColor = ConsoleColor.White;
            Story.pressToContinue();
        }

        public static void storyBossTwo()
        {
            Console.Clear();
            Game.Print("You go to the door and open it to progress to the next room...");
            Game.Print("Upon entering the room you see a man with regular clothes on but with a wizard hat");
            Game.Print("He says: Hello I am Krillo the 99 magic mage!");
            Game.Print("He continues: You can only pass this point if you got 99 magic on runescape!");
            Game.Print("The man seems friendly so you decide to talk rather than attack......");
            Console.WriteLine("");
            Game.Print("After some idle talk you inform the man that you don't have 99 magic on runescape and it's been years since you last played");
            Game.Print("You try to politely ask him if you can pass to the next room");
            Game.Print("The man starts chanting something that you don't understand");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Game.Print("All of a sudden he yells: 99 MAGE ICE BARRAGE AGS SPEC DEAD!");
            Console.ForegroundColor = ConsoleColor.White;
            Story.pressToContinue();
        }
        public static void storyBossThree()
        {
            Console.Clear();
            Game.Print("You go to the door and open it to progress to the next room...");
            Game.Print("Upon entering the room you see a naked man just standing there looking around for something with a smile on his face");
            Game.Print("The man asks: Do you have any lube?");
            Console.WriteLine("");
            Game.Print("Do you want to answer 'yes' or 'no'?");
            String answer = Console.ReadLine();
            // om spelaren skriver in 'yes'
            if (answer.ToLower() == "yes")
            {
                Console.Clear();
                Game.Print("You tell the man that you got some lube");
                Game.Print("The mans smile grows even bigger as he says: Well give it to me then");
                Game.Print("You search your backpack.......");
                Console.WriteLine("");
                Game.Print("it quickly becomes obvious that you don't have any lube whatsoever");
                Game.Print("After searching for a long time you have to tell the man that you do as a matter of fact not have any lube for him");
                Game.Print("The mans smile has now dissapeared and instead there's now a frown on his face");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Game.Print("IF YOU DONT HAVE LUBE YOU DIE!");
                Console.ForegroundColor = ConsoleColor.White;
                Story.pressToContinue();
            }// om spelaren skriver in något annat än 'yes'
            else
            {
                Console.Clear();
                Game.Print("You tell the man that you don't have any lube for him");
                Game.Print("Upon hearing this the mans smile dissapears and instead there's now a frown on his face");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Game.Print("IF YOU DONT HAVE LUBE YOU DIE!");
                Console.ForegroundColor = ConsoleColor.White;
                Story.pressToContinue();
            }
        }

        //liten metod för att göra console clear används bara i story
        public static void clean()
        {
            Console.Clear();
        }
        // skapar ett mellanrum i texten och ber om att rycka på en knapp för att fortsätta
        public static void pressToContinue()
        {

            Console.WriteLine("");
            Console.WriteLine("Press any button to continue....");
            Console.ReadKey();
        }
    }
}
