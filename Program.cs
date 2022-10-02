using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace goblin
{
    class Exe 
    {
        static void Main()
        {
        newgame:;
            Console.SetWindowSize(110, 46);
            int worldkeuze = 9;
            int explored = 0;
            int move = 0;
            int lvl = 5;
            int lvlupcheck = 0;
            int xp = 0;
            int monsters = 0;
            Boolean area1 = true;
            int area2 = 0;
            Boolean area3 = false;
            Boolean special = false;
            Boolean specialblock = false;
            Boolean code = true;
            Boolean player_alive = true;
            Boolean goblin_alive = false;
            Boolean luckygoblin_alive = false;
            Boolean goblinking_alive = false;
            Boolean goblinbrute_alive = false;
            string name = " ";
            player n = new();
            goblin nn = new();
            world nnn = new();
            Fight nnnn = new();
            //name = n.name();

            //Console.WriteLine("hello " + name);
            //Console.ReadLine();
            int[] stats = { 0, 0, 0, 0 };
            n.Stats(stats);
            Console.WriteLine();
            Console.WriteLine();
            stats = n.Stats_setup(lvl);
            int defaulthealth = stats[0];
        worldkeuze:;
            worldkeuze = nnn.Worldkeuze(explored, stats); 
            if(worldkeuze == 0)
            {

            }
            else if(worldkeuze == 1 & explored >= 0)
            {
                area1 = true;
            }
            else if(worldkeuze == 2 & explored >= 1)
            {
                area2 = 1;
            }
            else if (worldkeuze == 3 & explored >= 2)
            {
                area3 = true;
            }
            else if (worldkeuze == 0)
            {
                goto monsters;
            }
            else if (worldkeuze == 1221)
            {
                if(code == true)
                {
                    code = false;
                    Console.WriteLine("the boxes were not empty after all");
                    lvl = n.lvls(xp, lvl, stats, 10);
                    defaulthealth = stats[0];
                    goto monsters;
                }
                else
                {
                    Console.WriteLine("you already found the secret");
                }
            }
        world:;
            while(area1 == true)
            {
                area1 = nnn.Area1(stats);
                if (explored == 0)
                {
                    explored = 1;
                }
            }

            while (area2 == 1)
            {
                area2 = nnn.Area2(stats);
                if (explored == 1)
                {
                    explored = 2;
                }
                if(area2 == 3)
                {
                    goto getspecialblock;
                }
            }
            while (area3 == true)
            {
                area3 = nnn.Area3(stats);
                if (explored == 2)
                {
                    explored = 3;
                }
                goblinbrute_alive = true;
                goto goblinbrute;
            }
            goto monsters;
        goblin:;
            goblin_alive = nnnn.fight_goblin(goblin_alive, player_alive, special, stats, move, specialblock, defaulthealth, lvlupcheck, lvl, xp);
            if (goblin_alive == true)
            {
                goto dead;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("goblin dies");
                Console.ReadLine();
                stats = n.Resethealth(stats, defaulthealth);
                lvlupcheck = lvl;
                xp = n.xp(xp, 5);
                lvl = n.lvl(xp, lvl, stats);
                if (lvl > lvlupcheck)
                {
                    xp = 0;
                }
                defaulthealth = stats[0];
                goto worldkeuze;
            }
        luckygoblin:;
            luckygoblin_alive = nnnn.fight_luckygoblin(luckygoblin_alive, player_alive, special, stats, move, specialblock, defaulthealth, lvlupcheck, lvl, xp);
            if (goblin_alive == true)
            {
                goto dead;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("lucky goblin dies");
                Console.ReadLine();
                stats = n.Resethealth(stats, defaulthealth);
                lvlupcheck = lvl;
                xp = n.xp(xp, 5);
                lvl = n.lvls(xp, lvl, stats,3);
                if (lvl > lvlupcheck)
                {
                    xp = 0;
                }
                defaulthealth = stats[0];
                goto worldkeuze;
            }
        goblinking:;
            luckygoblin_alive = nnnn.fight_goblinking(goblinking_alive, player_alive, special, stats, move, specialblock, defaulthealth, lvlupcheck, lvl, xp);
            if (goblin_alive == true)
            {
                goto dead;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("goblin dies");
                Console.ReadLine();
                stats = n.Resethealth(stats, defaulthealth);
                lvlupcheck = lvl;
                xp = n.xp(xp, 5);
                lvl = n.lvl(xp, lvl, stats);
                if (lvl > lvlupcheck)
                {
                    xp = 0;
                }
                defaulthealth = stats[0];
                goto you_won;
            }
        goblinbrute:;
            luckygoblin_alive = nnnn.fight_goblinbrute(goblinbrute_alive, player_alive, special, stats, move, specialblock, defaulthealth, lvlupcheck, lvl, xp);
            if (goblin_alive == true)
            {
                goto dead;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("goblin dies");
                Console.ReadLine();
                stats = n.Resethealth(stats, defaulthealth);
                lvlupcheck = lvl;
                xp = n.xp(xp, 5);
                lvl = n.lvls(xp, lvl, stats, 5);
                if (lvl > lvlupcheck)
                {
                    xp = 0;
                }
                defaulthealth = stats[0];
                goto worldkeuze;
            }
        monsters:;
            if (special == true)
            {
                specialblock = true;
            }
            monsters = nn.Monsters(stats);
            if (monsters >= 7 & explored >= 3)
            {
                goblinking_alive = true;
                goto goblinking;
            }
            else if (monsters <= 3 & explored >=2)
            {
                luckygoblin_alive = true;
                goto luckygoblin;
            }
            else
            {
                goblin_alive = true;
                goto goblin;
            }
        dead:;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("you died");
            Console.ReadLine();
            goto newgame;
        you_won:;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("you won!!");
            Console.ReadLine();
            Environment.Exit(0);
        getspecialblock:;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("unlocked special block");
            Console.ReadLine();
            special = true;
            goto worldkeuze;
        }
    }
}