using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace AdventureGame
{
    public class Player
    {
        Random rand = new Random();

        public string name;
        public int hp = 10;
        public int damage = 1;
        public int coins = 0;
        public int room = 2;
        public int armorValue = 0;
        public int weaponValue = 1;
        public int pots = 5;
        public int level = 1;
        public int xp = 0;
        public int pMods = 0;

        public int getHp()
        {
            //hp på mobs randomn värde högsta och lägsta 
            int urange = (2 * pMods + 4);
            int lrange = (pMods + 1);
            return rand.Next(lrange, urange);
        }

        public int getLvl()
        {
            //lvl på mobs random värde högsta och lägsta 
            int urange = (2 * pMods + 2);
            int lrange = (pMods + 1);
            return rand.Next(lrange, urange);
        }
        public int getCoins()
        {
            // coins vi kan få av en mob högsta och lägsta rand emallen värdena
            int urange = (12 * pMods + 50);
            int lrange = (7 * pMods + 10);
            return rand.Next(lrange, urange);
        }

        public int getXP()
        {
            // XPn vi kan få av en mob högsta och lägsta rand emellan värdena
            int urange = (22 * pMods + 50);
            int lrange = (17 * pMods + 10);
            return rand.Next(lrange, urange);
        }
        public int getLevelUpValue()
        {
            // 100 * vår level +100xp per varje gång vi levler
            return 100 * level + 100;
        }
        // om XP är högre än värdet vi behöver för att levla, levla annars levla inte
        public bool canLevelUp()
        {
            if (xp >= getLevelUpValue())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //levla om vi kan levla, sedan ge rewards baserat på level
        public void levelUp()
        {
            while (canLevelUp())
            {

                xp -= getLevelUpValue();
                Story.player.level++;
                Story.player.pMods++;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You have leveled up! you are now level: " + level);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            SoundPlayer sp = new SoundPlayer("Sounds/levelup.wav");
            sp.PlaySync();
            sp.Stop();
            int lvlUpHp = 10 + rand.Next(0, Story.player.level);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You feel yourself getting stronger! You gain " + lvlUpHp + " health");
            Console.ForegroundColor = ConsoleColor.White;
            hp += lvlUpHp;

            if (level == 3)
            {
                weaponValue += 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You gained the skill: Sharpened blade(1), increasing your damage by 1!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (level == 5)
            {
                weaponValue += 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You gained the skill: Sharpened blade(2), increasing your damage by 1!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (level == 8)
            {
                armorValue += 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You gained the skill: Tough skin(1), increasing your armor by 1!");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}
