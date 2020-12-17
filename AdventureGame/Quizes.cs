using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace AdventureGame
{
    public class Quizes
    {
        static Random rand = new Random();


        public static void OurQuizes()
        {
            switch (rand.Next(0, 3))
            {
                case 0:
                    MathQuizes();

                    break;

                case 1:

                    TriviaQuizes();

                    break;
                case 2:

                    GeneralQuizes();

                    break;
            }

            Story.player.room++;
            Game.IfPlayerDies();
        }


        // våra mattefrågor valda randomly
        public static void MathQuizes()
        {

            switch (rand.Next(0, 3))
            {
                case 0:
                    QuizText();
                    Game.Print("It says: what is 1/0.1   (pick a choice 1-3)");
                    Game.Print("1. 100        2. 10        3. 1");
                    String answer = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer.ToLower() == "2")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer);
                        Console.WriteLine("");
                        SoundPlayer sp = new SoundPlayer("Sounds/win.wav");
                        sp.Play();
                        System.Threading.Thread.Sleep(500);
                        sp.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer);
                        Console.WriteLine("");
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        SoundPlayer sp6 = new SoundPlayer("Sounds/runfailed.wav");
                        sp6.Play();
                        System.Threading.Thread.Sleep(500);
                        sp6.Stop();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }

                    break;

                case 1:
                    QuizText();
                    Game.Print("It says: what is the square root of 400   (pick a choice 1-3)");
                    Game.Print("1. 20        2. 40        3. 200");
                    String answer2 = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer2.ToLower() == "1")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer2);
                        Console.WriteLine("");
                        SoundPlayer sp1 = new SoundPlayer("Sounds/win.wav");
                        sp1.Play();
                        System.Threading.Thread.Sleep(500);
                        sp1.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer2);
                        Console.WriteLine("");
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        SoundPlayer sp5 = new SoundPlayer("Sounds/runfailed.wav");
                        sp5.Play();
                        System.Threading.Thread.Sleep(500);
                        sp5.Stop();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }
                    break;
                case 2:
                    QuizText();
                    Game.Print("It says: 12x + 0 = 144, what is x?   (pick a choice 1-3)");
                    Game.Print("1. 144        2. 12        3. x");
                    String answer3 = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer3.ToLower() == "2")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer3);
                        Console.WriteLine("");
                        SoundPlayer sp1 = new SoundPlayer("Sounds/win.wav");
                        sp1.Play();
                        System.Threading.Thread.Sleep(500);
                        sp1.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer3);
                        Console.WriteLine("");
                        SoundPlayer sp4 = new SoundPlayer("Sounds/runfailed.wav");
                        sp4.Play();
                        System.Threading.Thread.Sleep(500);
                        sp4.Stop();
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }

                    break;
            }

        }
        // våra trivia quizes valda randomly
        public static void TriviaQuizes()
        {

            switch (rand.Next(0, 3))
            {
                case 0:
                    QuizText();
                    Game.Print("It says: What planet has the highest gravity in our solar system?   (pick a choice 1-3)");
                    Game.Print("1. Uranus        2. Jupiter        3. Saturn ");
                    String answer = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer.ToLower() == "2")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer);
                        Console.WriteLine("");
                        SoundPlayer sp = new SoundPlayer("Sounds/win.wav");
                        sp.Play();
                        System.Threading.Thread.Sleep(500);
                        sp.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer);
                        Console.WriteLine("");
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        SoundPlayer sp6 = new SoundPlayer("Sounds/runfailed.wav");
                        sp6.Play();
                        System.Threading.Thread.Sleep(500);
                        sp6.Stop();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }

                    break;

                case 1:
                    QuizText();
                    Game.Print("It says: What part of the atom has no electric charge?   (pick a choice 1-3)");
                    Game.Print("1. Neutron        2. Electrons        3. Nucleus");
                    String answer2 = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer2.ToLower() == "1")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer2);
                        Console.WriteLine("");
                        SoundPlayer sp1 = new SoundPlayer("Sounds/win.wav");
                        sp1.Play();
                        System.Threading.Thread.Sleep(500);
                        sp1.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer2);
                        Console.WriteLine("");
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        SoundPlayer sp5 = new SoundPlayer("Sounds/runfailed.wav");
                        sp5.Play();
                        System.Threading.Thread.Sleep(500);
                        sp5.Stop();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }
                    break;
                case 2:
                    QuizText();
                    Game.Print("It says: Which country invented tea?   (pick a choice 1-3)");
                    Game.Print("1. England        2. China        3. India");
                    String answer3 = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer3.ToLower() == "2")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer3);
                        Console.WriteLine("");
                        SoundPlayer sp1 = new SoundPlayer("Sounds/win.wav");
                        sp1.Play();
                        System.Threading.Thread.Sleep(500);
                        sp1.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer3);
                        Console.WriteLine("");
                        SoundPlayer sp4 = new SoundPlayer("Sounds/runfailed.wav");
                        sp4.Play();
                        System.Threading.Thread.Sleep(500);
                        sp4.Stop();
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }

                    break;
            }


        }
        // våra general quizes valda randomly
        public static void GeneralQuizes()
        {
            switch (rand.Next(0, 3))
            {
                case 0:
                    QuizText();
                    Game.Print("It says: What is your body's largest organ?   (pick a choice 1-3)");
                    Game.Print("1. Intestines        2. Skin        3. Brain");
                    String answer = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer.ToLower() == "2")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer);
                        Console.WriteLine("");
                        SoundPlayer sp = new SoundPlayer("Sounds/win.wav");
                        sp.Play();
                        System.Threading.Thread.Sleep(500);
                        sp.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer);
                        Console.WriteLine("");
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        SoundPlayer sp6 = new SoundPlayer("Sounds/runfailed.wav");
                        sp6.Play();
                        System.Threading.Thread.Sleep(500);
                        sp6.Stop();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }

                    break;

                case 1:
                    QuizText();
                    Game.Print("It says: Which mammal has no vocal cords?   (pick a choice 1-3)");
                    Game.Print("1. Giraffes        2. Dolphins        3. Seals");
                    String answer2 = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer2.ToLower() == "1")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer2);
                        Console.WriteLine("");
                        SoundPlayer sp1 = new SoundPlayer("Sounds/win.wav");
                        sp1.Play();
                        System.Threading.Thread.Sleep(500);
                        sp1.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer2);
                        Console.WriteLine("");
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        SoundPlayer sp5 = new SoundPlayer("Sounds/runfailed.wav");
                        sp5.Play();
                        System.Threading.Thread.Sleep(500);
                        sp5.Stop();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }
                    break;
                case 2:
                    QuizText();
                    Game.Print("It says: How many eyes does a bee have?   (pick a choice 1-3)");
                    Game.Print("1. 4        2. 5        3. 8");
                    String answer3 = Console.ReadLine();
                    // om spelaren skriver in rätt svar
                    if (answer3.ToLower() == "2")
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer3);
                        Console.WriteLine("");
                        SoundPlayer sp1 = new SoundPlayer("Sounds/win.wav");
                        sp1.Play();
                        System.Threading.Thread.Sleep(500);
                        sp1.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Game.Print("Upon saying the number the door to the next room opens!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        Console.Clear();
                        Game.Print("You decide to pick choice " + answer3);
                        Console.WriteLine("");
                        SoundPlayer sp4 = new SoundPlayer("Sounds/runfailed.wav");
                        sp4.Play();
                        System.Threading.Thread.Sleep(500);
                        sp4.Stop();
                        int damage = 10 + Story.player.level;
                        Game.Print("Upon saying the number, an opening opens from the roof and a cable with live electricity falls down!");
                        Game.Print("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Game.Print("You take " + damage + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp -= damage;
                        Game.Print("The door to the next room opens up....");
                        Story.pressToContinue();
                    }

                    break;
            }


        }
        // texten som kommer upp innan quizet 
        public static void QuizText()
        {
            Console.Clear();
            Game.Print("You go to the door and open it to progress to the next room...");
            Game.Print("Upon entering the room you find a metal table with a note");
            Game.Print("You also notice that there's water on the floor");
            Game.Print("");
            Game.Print("There's a recording device in the corner of the room, presumably to hear your answer");
            Game.Print("You walk to the table and pick up the note to read it");
        }
    }
}
