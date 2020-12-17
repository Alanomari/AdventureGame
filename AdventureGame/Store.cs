using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace AdventureGame
{
    public class Store
    {

        public static void playerStats(Player p)
        {
            Console.WriteLine("");
            Console.WriteLine("     " + p.name + "'s Stats");
            Console.WriteLine("***********************");
            Console.WriteLine("| Current HP:   " + p.hp + " |");
            Console.WriteLine("| Weapon damage: " + p.weaponValue + " |");
            Console.WriteLine("| Armor defence: " + p.armorValue + " |");
            Console.WriteLine("| Potion amount: " + p.pots + " |");
            Console.WriteLine("| Gold:          " + p.coins + " |");
            Console.WriteLine("***********************");

        }


        public static void getStore(Player p)
        {
            // method for executing the runstore method 
            runStore(p);
        }

        public static void runStore(Player p)
        {
            //set values for the store and show the store
            int potPrice;
            int armorPrice;
            int wepPrice;
            // int difficultyPrice;



            while (true)
            {
                potPrice = 25 + 5 * p.pMods;
                armorPrice = 100 * (p.armorValue + 1);
                wepPrice = 120 * (p.weaponValue);



                Console.Clear();
                Console.WriteLine("      Store Room     ");
                Console.WriteLine("What would you like to buy?");
                Console.WriteLine("***********************");
                Console.WriteLine("| (A)rmor upgrade  | " + armorPrice + " Gold");
                Console.WriteLine("| (W)eapon upgrade | " + wepPrice + " Gold");
                Console.WriteLine("| (P)otion         | " + potPrice + " Gold");
                Console.WriteLine("***********************");
                Console.WriteLine("| (E)xit store     | ");
                Console.WriteLine("***********************");
                Console.WriteLine("");
                playerStats(p);




                string input = Console.ReadLine().ToLower();

                if (input == "w" || input == "weapon")
                {

                    buy("weapon", wepPrice, p);
                }
                else if (input == "a" || input == "armor")
                {

                    buy("armor", armorPrice, p);
                }
                else if (input == "p" || input == "potion")
                {

                    buy("potion", potPrice, p);
                }
                else if (input == "e" || input == "exit")
                {
                    SoundPlayer sp = new SoundPlayer("Sounds/run.wav");
                    sp.Play();
                    System.Threading.Thread.Sleep(500);
                    sp.Stop();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You go towards the next room...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Story.pressToContinue();
                    break;
                }

            }



        }
        static void buy(String item, int cost, Player p)
        {
            if (p.coins >= cost)
            {
                if (item == "potion")
                {
                    p.pots++;
                    p.coins -= cost;

                    SoundPlayer sp3 = new SoundPlayer("Sounds/buypotion.wav");
                    sp3.Play();
                    System.Threading.Thread.Sleep(600);
                    sp3.Stop();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You bought a potion!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Story.pressToContinue();
                }
                else if (item == "weapon")
                {
                    p.weaponValue++;
                    p.coins -= cost;

                    SoundPlayer sp1 = new SoundPlayer("Sounds/weaponupgrade.wav");
                    sp1.Play();
                    System.Threading.Thread.Sleep(700);
                    sp1.Stop();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You bought a weapon upgrade!");
                    //upgradera vapen för varje 5 lvlar
                    if (p.weaponValue == 5)
                    {
                        Console.WriteLine("");
                        SoundPlayer sp2 = new SoundPlayer("Sounds/levelup.wav");
                        sp2.PlaySync();
                        sp2.Stop();
                        Console.WriteLine("Your weapon upgraded from bronze sword to iron sword!");
                    }
                    if (p.weaponValue == 10)
                    {
                        Console.WriteLine("");
                        SoundPlayer sp2 = new SoundPlayer("Sounds/levelup.wav");
                        sp2.PlaySync();
                        sp2.Stop();
                        Console.WriteLine("Your weapon upgraded from iron sword to steel sword!");
                    }
                    if (p.weaponValue == 15)
                    {
                        Console.WriteLine("");
                        SoundPlayer sp2 = new SoundPlayer("Sounds/levelup.wav");
                        sp2.PlaySync();
                        sp2.Stop();
                        Console.WriteLine("Your weapon upgraded from steel sword to adamant sword!");
                    }
                    if (p.weaponValue == 20)
                    {
                        Console.WriteLine("");
                        SoundPlayer sp2 = new SoundPlayer("Sounds/levelup.wav");
                        sp2.PlaySync();
                        sp2.Stop();
                        Console.WriteLine("Your weapon upgraded from adamant sword to rune sword!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Story.pressToContinue();
                }
                else if (item == "armor")
                {
                    p.armorValue++;
                    p.coins -= cost;

                    SoundPlayer sp2 = new SoundPlayer("Sounds/armorupgrade.wav");
                    sp2.Play();
                    System.Threading.Thread.Sleep(1200);
                    sp2.Stop();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You bought a armor upgrade!");
                    //upgradera armor för varje 5 lvlar
                    if (p.armorValue == 5)
                    {
                        Console.WriteLine("");
                        SoundPlayer sp3 = new SoundPlayer("Sounds/levelup.wav");
                        sp3.PlaySync();
                        sp3.Stop();
                        Console.WriteLine("Your armor upgraded from leather armor to studded leather armor!");
                    }
                    if (p.armorValue == 10)
                    {
                        Console.WriteLine("");
                        SoundPlayer sp3 = new SoundPlayer("Sounds/levelup.wav");
                        sp3.PlaySync();
                        sp3.Stop();
                        Console.WriteLine("Your armor upgraded from studded leather armor to iron armor!");
                    }
                    if (p.armorValue == 15)
                    {
                        Console.WriteLine("");
                        SoundPlayer sp3 = new SoundPlayer("Sounds/levelup.wav");
                        sp3.PlaySync();
                        sp3.Stop();
                        Console.WriteLine("Your armor upgraded from iron armor to steel armor!");
                    }
                    if (p.armorValue == 20)
                    {
                        Console.WriteLine("");
                        SoundPlayer sp3 = new SoundPlayer("Sounds/levelup.wav");
                        sp3.PlaySync();
                        sp3.Stop();
                        Console.WriteLine("Your armor upgraded from steel armor to adamant armor!");
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Story.pressToContinue();
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You don't have enough gold to buy this item!");
                Console.ForegroundColor = ConsoleColor.White;
                Story.pressToContinue();
            }
        }
    }
}
