using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Media;



namespace AdventureGame
{
    public class Fights
    {
        static Random rand = new Random();


        


        //vår första fight efter lite story
        public static void firstFight()
        {
            Story.storyFightOne();
            FightMenu.combat(false, "The Stranger", 1, 4);
        }
        //vår basic fight metod
        public static void basicFight()
        {
            Console.Clear();
            Game.Print("You go to the door and open it to progress to the next room...");
            Story.pressToContinue();
            FightMenu.combat(true, "", 0, 0);
        }
        //metod för stranger encountern
        public static void Strangerfight()
        {
            Console.Clear();
            Game.Print("You go to the door and open it to progress to the next room...");
            Game.Print("Before you stands yet another person");
            Console.WriteLine("");
            Game.Print("Before you manage to say anything the stranger attacks!");
            Story.pressToContinue();
            FightMenu.combat(false, "Stranger", Story.player.level + rand.Next(0, 2), Story.player.level + rand.Next(0, 6));
        }
        //metod för tom rum encounter
        public static void emptyRoom()
        {

            Console.Clear();
            Game.Print("You go to the door and open it to progress to the next room...");
            Game.Print("You find yourself standing in an empty room, you take this opportunity to rest for a while");
            int restValue = 5 + rand.Next(0, Story.player.level);
            Story.player.hp += restValue;
            Story.player.room++;
            Console.WriteLine("");
            SoundPlayer sp = new SoundPlayer("Sounds/sleep.wav");
            sp.PlaySync();
            sp.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You gain " + restValue + " hp from resting!");
            Console.ForegroundColor = ConsoleColor.White;
            Story.pressToContinue();

        }
        //när spelaren lyckas rymma
        public static void RunAway()
        {

            Console.Clear();
            Game.Print("You run back to the previous room and rest for a bit to heal your wounds before trying to go the the next room again.");
            int restValue = 5 + rand.Next(0, Story.player.level);
            Story.player.hp += restValue;
            Story.player.room++;
            Console.WriteLine("");
            SoundPlayer sp = new SoundPlayer("Sounds/sleep.wav");
            sp.PlaySync();
            sp.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You gain " + restValue + " hp from resting!");
            Console.ForegroundColor = ConsoleColor.White;
            Story.pressToContinue();

        }
        //affär
        public static void storeRoom()
        {
            Console.Clear();
            Game.Print("You go to the door and open it to progress to the next room...");
            Game.Print("You find yourself standing inside a room with upgrades for your gear and your sword");
            Story.pressToContinue();
            Console.Clear();
            // gå till affären
            Store.getStore(Story.player);
            Story.player.room++;
        }

        //första bossen för våning 20
        public static void firstBoss()
        {
            Story.storyBossOne();
            FightMenu.combat(false, "Emilio, the Krarumpa", Story.player.level + 2, 40);
        }
        //vår andra bossfight för våning 40
        public static void secondBoss()
        {

            Story.storyBossTwo();
            FightMenu.combat(false, "Krillo, the mage", Story.player.level + 3, 60);

        }
        // vår tredje bossfight våning 60
        public static void thirdBoss()
        {
            Story.storyBossThree();
            FightMenu.combat(false, "Juice, the lubeman", Story.player.level + 4, 80);
        }



        // våra fighter, randomly valda bossar på specifika våningar 20,40 etc
        public static void randomFight()
        {
            switch (rand.Next(0, 6))
            {
                case 0:
                    CheckForBosses();
                    basicFight();


                    break;
                case 1:
                    CheckForBosses();
                    Strangerfight();

                    break;

                case 2:
                    CheckForBosses();
                    storeRoom();
                    break;
                case 3:
                    CheckForBosses();
                    emptyRoom();
                    break;

                case 4:
                    CheckForBosses();
                    Quizes.OurQuizes();
                    break;

                case 5:
                    CheckForBosses();
                    basicFight();
                    break;
            }
        }
        public static void CheckForBosses()
        {
            if (Story.player.room == 20)
            {
                firstBoss();
            }
            if (Story.player.room == 40)
            {
                secondBoss();
            }
            if (Story.player.room == 60)
            {
                thirdBoss();
            }
        }
    }

}

