using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace AdventureGame
{
    class FightMenu
    {
        static Random rand = new Random();
        public static void combat(bool random, string name, int level, int health)
        {
            string n = "";
            int lvl = 0;
            int hp = 0;
            if (random)
            {
                n = getName();
                lvl = Story.player.getLvl();
                hp = Story.player.getHp();
            }
            else
            {
                n = name;
                lvl = level;
                hp = health;
            }
            while (hp > 0)
            {
                Console.Clear();
                // skriv ut monsterns namn lvl och hp
                Console.WriteLine(n);
                Console.WriteLine("Level: " + lvl + " /" + " Health: " + hp);
                Console.WriteLine("");
                // visa menyn
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("***********************");
                Console.WriteLine("| (A)ttack  (D)efend  |");
                Console.WriteLine("| (R)un     (P)otion  |");
                Console.WriteLine("| (Q)uit game & Save  |");
                Console.WriteLine("***********************");
                //visa vilket rum spelaren är i samt och spelarens xp och pots
                Console.WriteLine(" Room: " + Story.player.room);
                Console.WriteLine("");
                Console.WriteLine("XP:");
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Game.progressBar("■", " ", ((decimal)Story.player.xp / (decimal)Story.player.getLevelUpValue()), 31);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]");
                Console.WriteLine("Level: " + Story.player.level);
                Console.WriteLine(Story.player.name + " Has.. Potions: " + Story.player.pots + " Health: " + Story.player.hp);
                String input = Console.ReadLine();
                //om spelaren väljer attack
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack / attack sound
                    SoundPlayer sp1 = new SoundPlayer("Sounds/attack.wav");
                    sp1.Play();
                    System.Threading.Thread.Sleep(700);
                    sp1.Stop();
                    int attack = rand.Next(0, Story.player.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You slice the " + n + " with your sword dealing " + attack + " damage to it!");


                    // ta skada
                    int damage = Story.player.level + rand.Next(0, 3) - Story.player.armorValue;
                    if (damage < 0)
                        damage = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You take " + damage + " damage from the " + n + "s blow!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Story.player.hp -= damage;
                    hp -= attack;
                    Story.pressToContinue();
                }// om spelaren väljer defend
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    int attack = rand.Next(1, Story.player.weaponValue) - 2;
                    if (attack < 0)
                        attack = 0;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You defend with your sword as the " + n + " attacks dealing " + attack + " damage to it!");
                    Console.ForegroundColor = ConsoleColor.White;
                    //ta skada
                    int damage = (lvl / 2) - Story.player.armorValue;
                    if (damage < 0)
                        damage = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You take " + damage + " damage from the " + n + "s blow!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Story.player.hp -= damage;
                    hp -= attack;
                    Story.pressToContinue();

                }// om spelaren väljer run
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Lyckades inte rymma & ljud
                    if (rand.Next(0, 15) > 0)
                    {
                        SoundPlayer sp4 = new SoundPlayer("Sounds/runfailed.wav");
                        sp4.Play();
                        System.Threading.Thread.Sleep(500);
                        sp4.Stop();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You try to run away from the " + n + " but you fail and take a hit in the back!");
                        Console.ForegroundColor = ConsoleColor.White;
                        int damage = Story.player.level + rand.Next(0, 3) - Story.player.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You take " + damage + " damage from the " + n + "s blow!");
                        Story.player.hp -= damage;
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                    }
                    else
                    {
                        //Lyckades rymma & ljud
                        SoundPlayer sp3 = new SoundPlayer("Sounds/run.wav");
                        sp3.Play();
                        System.Threading.Thread.Sleep(500);
                        sp3.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You try to run away from the " + n + ", you manage to run back to the previous room and leave the " + n + " behind!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.pressToContinue();
                        Fights.RunAway();
                       


                    }
                }// om spelaren väljer potion
                else if (input.ToLower() == "p" || input.ToLower() == "potion")
                {
                    //Om vi inte har pots, ta skada
                    if (Story.player.pots == 0)
                    {
                        Console.WriteLine("You check your backpack and you do not have any potions left!");
                        int damage = lvl - Story.player.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The " + n + " hits you for " + damage + " damage!");
                        Story.player.hp -= damage;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {//Om vi har pots
                        Console.WriteLine("You check your backpack and you grab a potion!");
                        int potionValue = rand.Next(0, Story.player.level) + 5;
                        SoundPlayer sp2 = new SoundPlayer("Sounds/potion.wav");
                        sp2.Play();
                        System.Threading.Thread.Sleep(400);
                        sp2.Stop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You gain " + potionValue + " health!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Story.player.hp += potionValue;
                        Story.player.pots -= 1;


                    }

                    Story.pressToContinue();

                }// om spelaren väljer att quitta
                else if (input.ToLower() == "q" || input.ToLower() == "quit")
                {
                    Game.quit();
                }

                Game.IfPlayerDies();


            }
            //monster droppar coin och xp efter fighten & spela upp ljud 
            Console.WriteLine("");
            int coins = Story.player.getCoins();
            int xp = Story.player.getXP();
            SoundPlayer sp = new SoundPlayer("Sounds/win.wav");
            sp.Play();
            System.Threading.Thread.Sleep(500);
            sp.Stop();
            Console.WriteLine("You defeated the: " + n + "!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You get: " + coins + " Gold from the " + n + "!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You have gained " + xp + " Experience!");
            Story.player.coins += coins;
            Story.player.xp += xp;
            // om spelaren kan levla, levla spelaren
            if (Story.player.canLevelUp())
            {
                Story.player.levelUp();

            }
            //öka room värdet med 1 efter fight loopen
            Story.player.room++;

            Story.pressToContinue();


        }
        //namnen för våra basic fights returnar ett random namn så vi inte möter samma monster hela tiden
        public static string getName()
        {
            switch (rand.Next(0, 11))
            {
                case 0:
                    return "Goblin";
                case 1:
                    return "Giant";
                case 2:
                    return "Ogre";
                case 3:
                    return "Lesser Demon";
                case 4:
                    return "Witch";
                case 5:
                    return "Imp";
                case 6:
                    return "Kobold";
                case 7:
                    return "Centaur";
                case 8:
                    return "Siren";
                case 9:
                    return "Yeti";
                case 10:
                    return "Werewolf";
            }
            return "";


        }

    }
}
