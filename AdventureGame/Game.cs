using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.Threading;



namespace AdventureGame
{

    class Game
    {
        public static bool mainLoop = true;


        public static void Start()
        {

            Story.storyStart();
            Fights.firstFight();
            while (mainLoop)
            {
                Fights.randomFight();
            }




        }
        //metod för att avsluta spelet & spara spel progress
        public static void quit()
        {
            Console.Clear();
            Game.Print("Would you like to save your progress?");

            Story.pressToContinue();

            Environment.Exit(0);
        }
        //printar ut texten vi skriver in i Game.Print(""); med ljud
        public static void Print(string text, int speed = 40)
        {
            SoundPlayer sp = new SoundPlayer("Sounds/writing.wav");
            //sp.PlayLooping();
            foreach (char c in text)
            {

                Console.Write(c);
                sp.Play();
                Thread.Sleep(speed);
            }
            sp.Stop();


            Console.WriteLine();
        }
        // metod för vår xp progressbar
        public static void progressBar(string filler, string background, decimal value, int size)
        {
            int dif = (int)(value * size);
            for (int i = 0; i < size; i++)
            {
                if (i < dif)
                {
                    Console.Write(filler);
                }

                else
                {
                    Console.Write(background);
                }
            }
        }

        public static void IfPlayerDies()
        {
            // Spelaren dör & ljud
            if (Story.player.hp <= 0)
            {
                SoundPlayer sp2 = new SoundPlayer("Sounds/dead.wav");
                sp2.PlaySync();
                sp2.Stop();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You have been slain! This is where your journey ends " + Story.player.name +"......");
                Console.ForegroundColor = ConsoleColor.White;
                Story.pressToContinue();
                Environment.Exit(0);
            }
        }

    }
}
