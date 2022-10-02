using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goblin
{
    class goblin
    {
        public string Goblinart()
        {
            string goblinart = @"
             ,      ,
            /(.-""-.)\
        |\  \/      \/  /|
        | \ / =.  .= \ / |
        \( \   o\/o   / )/
         \_, '-/  \-' ,_/
           /   \__/   \
           \ \__/\__/ /
         ___\ \|--|/ /___
       /`    \      /    `\
      /       '----'       \";
            Console.WriteLine(goblinart);
            return goblinart;
        }

        public string Goblinkingart()
        {
            string goblinart = @"  
                  /\     /\
              __,/='\```/'=\__
              '//  (o) \(o) \ `'         _,-,
              //|     ,_)   (`\      ,-'`_,-\
            ,-~~~\  `'==='  /-,      \==```` \__
           /        `----'     `\     \       \/
        ,-`                  ,   \  ,.-\       \
       /      ,               \,-`\`_,-`\_,..--'\
      ,`    ,/,              ,>,   )     \--`````\
      (      `\`---'`  `-,-'`_,<   \      \_,.--'`
       `.      `--. _,-'`_,-`  |    \
        [`-.___   <`_,-'`------(    /
        (`` _,-\   \ --`````````|--`
         >-`_,-`\,-` ,          |
       <`_,'     ,  /\          /
        `  \/\,-/ `/  \/`\_/V\_/
           (  ._. )    ( .__. )
           |      |    |      |
            \,---_|    |_---./
            ooOO(_)    (_)OOoo";
            Console.WriteLine(goblinart);
            return goblinart;
        }

        public int Monsters(int[] stats)
        {
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Random rnd = new Random();
            int rndnum = rnd.Next(1, 20 + 1);
            int a = rndnum;
            return rndnum;
        }

        public int[] Goblin()
        {
            int[] statsgoblin = { 5, 1, 2, 1 };
            return statsgoblin;
        }
        public int[] luckyGoblin()
        {
            int[] statsgoblin = { 7, 2, 2, 7 };
            return statsgoblin;
        }
        public int[] goblinking()
        {
            int[] statsgoblin = { 30, 4, 1, 0 };
            return statsgoblin;
        }
        public int[] goblinbrute()
        {
            int[] statsgoblin = { 15, 3, 2, 0 };
            return statsgoblin;
        }
        public int[] goblindamage(int[] stats, int[] goblinstats)
        {
            Boolean crit = false;
            for (int i = 0; i < stats[3]; i++)
            {
                Random rnd = new Random();
                int rndnum = rnd.Next(1, 20 + 1);
                int a = rndnum;
                if (rndnum == 10)
                {
                    crit = true;
                }
            }
            if (crit == true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("you attack and do " + stats[1] * 2 + " damage");
                goblinstats[0] = goblinstats[0] - stats[1] * 2;
                string attack = @"  * ** *
                                   ***/|***
                                   **|\|**
                                    *|||*
                                     |||
             ///~`     |\\_          |||         =\\\\         . .
            ,  |='  ,))\_| ~-_       |||          _)  \      _/_/|
           / ,' ,;((((((    ~ \      |||         `~~~\-~-_ /~ (_/\
         /' -~/~)))))))'\_   _/'  ~-[{o}]-~           \_  /'  D   |
        (       (((((( ~-/ ~-/       |/|                ~-;  /    \--_
         ~~--|   ))''    ')  `       |/|                  `~~\_    \   )
             :        (_  ~\         `0'  ,                 /~~-     ./
              \        \_   )--__  /(_/)                   |    )    )|
    ___       |_     \__/~-__    ~~   ,'      /,_;,   __--(   _/      |
  //~~\`\    /' ~~~----|     ~~~~~~~~'        \-  ((~~    __-~        |
((()   `\`\_(_     _-~~-\                      ``~~ ~~~~~~   \_      /
 )))     ~----'   /      \                                   )       )
  (         ;`~--'        :                                _-    ,;;(
            |    `\       |                             _-~    ,;;;;)
            |    /'`\     ;                          _-~          _/
           /~   /    |    )                         /;;;''  ,;;:-~
          |    /     / | /                         |;;'   ,''
          /   /     |  \\|                         |   ,;(
        _/  /'       \  \_)                   .---__\_    \,--._______
       ( )|'         (~-_|                   (;;'  ;;;~~~/' `;;|  `;;;\
        ) `\_         |-_;;--__               ~~~----__/'    /'_______/
        `----'       (________|\\   `                  ;;;'_/'";
                Console.WriteLine(attack);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("you attack and do " + stats[1] + " damage");
                goblinstats[0] = goblinstats[0] - stats[1];
                string attack = @"
                                      /|
                                     |\|
                                     |||
                                     |||
             ///~`     |\\_          |||         =\\\\         . .
            ,  |='  ,))\_| ~-_       |||          _)  \      _/_/|
           / ,' ,;((((((    ~ \      |||         `~~~\-~-_ /~ (_/\
         /' -~/~)))))))'\_   _/'  ~-[{o}]-~           \_  /*  D   |
        (       (((((( ~-/ ~-/       |/|                ~-;  /    \--_
         ~~--|   ))''    ')  `       |/|                  `~~\_    \   )
             :        (_  ~\         `0'  ,                 /~~-     ./
              \        \_   )--__  /(_/)                   |    )    )|
    ___       |_     \__/~-__    ~~   ,'      /,_;,   __--(   _/      |
  //~~\`\    /' ~~~----|     ~~~~~~~~'        \-  ((~~    __-~        |
((()   `\`\_(_     _-~~-\                      ``~~ ~~~~~~   \_      /
 )))     ~----'   /      \                                   )       )
  (         ;`~--'        :                                _-    ,;;(
            |    `\       |                             _-~    ,;;;;)
            |    /'`\     ;                          _-~          _/
           /~   /    |    )                         /;;;''  ,;;:-~
          |    /     / | /                         |;;'   ,''
          /   /     |  \\|                         |   ,;(
        _/  /'       \  \_)                   .---__\_    \,--._______
       ( )|'         (~-_|                   (;;'  ;;;~~~/' `;;|  `;;;\
        ) `\_         |-_;;--__               ~~~----__/'    /'_______/
        `----'       (________|\\   `                  ;;;'_/'";
                Console.WriteLine(attack);
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Console.WriteLine("goblin has " + goblinstats[0] + " health");
            return goblinstats;
        }
    }
}
