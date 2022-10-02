using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goblin
{
    internal class Fight
    {
        public Boolean fight_goblin(Boolean goblin_alive,Boolean player_alive, Boolean special, int[] stats, int move, Boolean specialblock)
        {
            player n = new();
            goblin nn = new();
            world nnn = new();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("goblin encounter");
            string goblinart = nn.Goblinart();
            Console.ReadLine();
            Console.Clear();
            int[] goblinstats = nn.Goblin();
            while (goblin_alive == true & player_alive == true)
            {
            move:;
                move = n.Move(special, stats, goblinstats);
                if (goblinstats[2] > stats[2])
                {
                    if (move == 1)
                    {
                        stats = n.damage(stats, goblinstats);
                        if (stats[0] <= 0)
                        {
                            player_alive = false;
                        }
                        goblinstats = nn.goblindamage(stats, goblinstats);
                    }
                    else if (move == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("you blocked too slow..");
                        stats = n.damage(stats, goblinstats);
                        if (stats[0] <= 0)
                        {
                            player_alive = false;
                        }
                    }
                    else if (move == 3 & special == true)
                    {
                        if (specialblock == true)
                        {
                            Console.WriteLine("special");
                            stats = n.Specialblock(stats, goblinstats, specialblock);
                            specialblock = false;
                        }
                        else
                        {
                            Console.WriteLine("you already used the special");
                            goto move;
                        }
                    }
                    if (goblinstats[0] <= 0)
                    {
                        goblin_alive = false;
                    }

                }
                else
                {
                    if (move == 1)
                    {
                        goblinstats = nn.goblindamage(stats, goblinstats);

                        stats = n.damage(stats, goblinstats);
                    }
                    else if (move == 2)
                    {
                        stats = n.Block(stats, goblinstats);
                    }
                    else if (move == 3 & special == true)
                    {
                        if (specialblock == true)
                        {
                            Console.WriteLine("special");
                            stats = n.Specialblock(stats, goblinstats, specialblock);
                            specialblock = false;
                        }
                        else
                        {
                            Console.WriteLine("you already used the special");
                            goto move;
                        }
                    }
                    if (goblinstats[0] <= 0)
                    {
                        goblin_alive = false;
                    }
                    if (stats[0] <= 0)
                    {
                        player_alive = false;
                    }


                }

            }
            return goblin_alive;
        }
        public Boolean fight_luckygoblin(Boolean goblin_alive, Boolean player_alive, Boolean special, int[] stats, int move, Boolean specialblock)
        {
            player n = new();
            goblin nn = new();
            world nnn = new();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("lucky goblin encounter");
            string goblinart = nn.Goblinart();
            Console.ReadLine();
            Console.Clear();
            int[] goblinstats = nn.luckyGoblin();
            while (goblin_alive == true & player_alive == true)
            {
            move:;
                move = n.Move(special, stats, goblinstats);
                if (goblinstats[2] > stats[2])
                {
                    if (move == 1)
                    {
                        stats = n.damage(stats, goblinstats);
                        if (stats[0] <= 0)
                        {
                            player_alive = false;
                        }
                        goblinstats = nn.goblindamage(stats, goblinstats);
                    }
                    else if (move == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("you blocked too slow..");
                        stats = n.damage(stats, goblinstats);
                        if (stats[0] <= 0)
                        {
                            player_alive = false;
                        }
                    }
                    else if (move == 3 & special == true)
                    {
                        if (specialblock == true)
                        {
                            Console.WriteLine("special");
                            stats = n.Specialblock(stats, goblinstats, specialblock);
                            specialblock = false;
                        }
                        else
                        {
                            Console.WriteLine("you already used the special");
                            goto move;
                        }
                    }
                    if (goblinstats[0] <= 0)
                    {
                        goblin_alive = false;
                    }

                }
                else
                {
                    if (move == 1)
                    {
                        goblinstats = nn.goblindamage(stats, goblinstats);

                        stats = n.damage(stats, goblinstats);
                    }
                    else if (move == 2)
                    {
                        stats = n.Block(stats, goblinstats);
                    }
                    else if (move == 3 & special == true)
                    {
                        if (specialblock == true)
                        {
                            Console.WriteLine("special");
                            stats = n.Specialblock(stats, goblinstats, specialblock);
                            specialblock = false;
                        }
                        else
                        {
                            Console.WriteLine("you already used the special");
                            goto move;
                        }
                    }
                    if (goblinstats[0] <= 0)
                    {
                        goblin_alive = false;
                    }
                    if (stats[0] <= 0)
                    {
                        player_alive = false;
                    }


                }

            }
            return goblin_alive;
        }
        public Boolean fight_goblinbrute(Boolean goblin_alive, Boolean player_alive, Boolean special, int[] stats, int move, Boolean specialblock)
        {
            player n = new();
            goblin nn = new();
            world nnn = new();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("goblin BRUTE");
            string goblinart = nn.Goblinart();
            Console.ReadLine();
            Console.Clear();
            int[] goblinstats = nn.goblinbrute();
            while (goblin_alive == true & player_alive == true)
            {
            move:;
                move = n.Move(special, stats, goblinstats);
                if (goblinstats[2] > stats[2])
                {
                    if (move == 1)
                    {
                        stats = n.damage(stats, goblinstats);
                        if (stats[0] <= 0)
                        {
                            player_alive = false;
                        }
                        goblinstats = nn.goblindamage(stats, goblinstats);
                    }
                    else if (move == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("you blocked too slow..");
                        stats = n.damage(stats, goblinstats);
                        if (stats[0] <= 0)
                        {
                            player_alive = false;
                        }
                    }
                    else if (move == 3 & special == true)
                    {
                        if (specialblock == true)
                        {
                            Console.WriteLine("special");
                            stats = n.Specialblock(stats, goblinstats, specialblock);
                            specialblock = false;
                        }
                        else
                        {
                            Console.WriteLine("you already used the special");
                            goto move;
                        }
                    }
                    if (goblinstats[0] <= 0)
                    {
                        goblin_alive = false;
                    }

                }
                else
                {
                    if (move == 1)
                    {
                        goblinstats = nn.goblindamage(stats, goblinstats);

                        stats = n.damage(stats, goblinstats);
                    }
                    else if (move == 2)
                    {
                        stats = n.Block(stats, goblinstats);
                    }
                    else if (move == 3 & special == true)
                    {
                        if (specialblock == true)
                        {
                            Console.WriteLine("special");
                            stats = n.Specialblock(stats, goblinstats, specialblock);
                            specialblock = false;
                        }
                        else
                        {
                            Console.WriteLine("you already used the special");
                            goto move;
                        }
                    }
                    if (goblinstats[0] <= 0)
                    {
                        goblin_alive = false;
                    }
                    if (stats[0] <= 0)
                    {
                        player_alive = false;
                    }


                }

            }
            return goblin_alive;
        }
        public Boolean fight_goblinking(Boolean goblin_alive, Boolean player_alive, Boolean special, int[] stats, int move, Boolean specialblock)
        {
            player n = new();
            goblin nn = new();
            world nnn = new();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Goblin King challenges you");
            string goblinart = nn.Goblinart();
            Console.ReadLine();
            Console.Clear();
            int[] goblinstats = nn.goblinking();
            while (goblin_alive == true & player_alive == true)
            {
            move:;
                move = n.Move(special, stats, goblinstats);
                if (goblinstats[2] > stats[2])
                {
                    if (move == 1)
                    {
                        stats = n.damage(stats, goblinstats);
                        if (stats[0] <= 0)
                        {
                            player_alive = false;
                        }
                        goblinstats = nn.goblindamage(stats, goblinstats);
                    }
                    else if (move == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("you blocked too slow..");
                        stats = n.damage(stats, goblinstats);
                        if (stats[0] <= 0)
                        {
                            player_alive = false;
                        }
                    }
                    else if (move == 3 & special == true)
                    {
                        if (specialblock == true)
                        {
                            Console.WriteLine("special");
                            stats = n.Specialblock(stats, goblinstats, specialblock);
                            specialblock = false;
                        }
                        else
                        {
                            Console.WriteLine("you already used the special");
                            goto move;
                        }
                    }
                    if (goblinstats[0] <= 0)
                    {
                        goblin_alive = false;
                    }

                }
                else
                {
                    if (move == 1)
                    {
                        goblinstats = nn.goblindamage(stats, goblinstats);

                        stats = n.damage(stats, goblinstats);
                    }
                    else if (move == 2)
                    {
                        stats = n.Block(stats, goblinstats);
                    }
                    else if (move == 3 & special == true)
                    {
                        if (specialblock == true)
                        {
                            Console.WriteLine("special");
                            stats = n.Specialblock(stats, goblinstats, specialblock);
                            specialblock = false;
                        }
                        else
                        {
                            Console.WriteLine("you already used the special");
                            goto move;
                        }
                    }
                    if (goblinstats[0] <= 0)
                    {
                        goblin_alive = false;
                    }
                    if (stats[0] <= 0)
                    {
                        player_alive = false;
                    }


                }

            }
            return goblin_alive;
        }
    }

}
