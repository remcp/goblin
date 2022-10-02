using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goblin
{
    class player
    {
        public int[] Block(int[] stats, int[] goblinstats)
        {
            Boolean block = false;
            for (int i = 0; i < stats[3]; i++)
            {
                Random rnd = new Random();
                int rndnum = rnd.Next(1, 10 + 1);
                int a = rndnum;
                if (rndnum == 10)
                {
                    block = true;
                }
            }
            if (block == true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("goblin attacked.. you blocked and reflect " + goblinstats[1] + " damage");
                goblinstats[0] = goblinstats[0] - goblinstats[1];
                string attack = @"                                    
             ///~`     |\\_              
            ,  |='  ,))\_| ~-_       
           / ,' ,;((((((    ~ \        
         /' -~/~)))))))'\_   _/'          
        (       (((((( ~-/ ~-/                 
         ~~--|   ))''    ')  `               
             :        (_  ~\           |`-._/\_.-`|                                   
              \        \_   )--__  /(_/|    ||    |
    ___       |_     \__/~-__    ~~   ,|___o()o___|
  //~~\`\    /' ~~~----|     ~~~~~~~~' |__((<>))__|
((()   `\`\_(_     _-~~-\              \   o\/o   /
 )))     ~----'   /      \              \   ||   /
  (         ;`~--'        :              \  ||  /
            |    `\       |               '.||.'
            |    /'`\     ;                 ``                  
           /~   /    |    )                   
          |    /     / | /                     
          /   /     |  \\|                   
        _/  /'       \  \_)                
       ( )|'         (~-_|       
        ) `\_         |-_;;--__ 
        `----'       (________|\\   `";
                Console.WriteLine(attack);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("goblin attacked.. through your block and did " + goblinstats[1] + " damage");
                stats[0] = stats[0] - goblinstats[1];
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Console.WriteLine("goblin has " + goblinstats[0] + " health");
            return stats;
        }

        public int[] Specialblock(int[] stats, int[] goblinstats, Boolean specialblock)
        {
            specialblock = false;
            Console.WriteLine();
            Console.WriteLine();
            int blockdamage = goblinstats[1] + 2;
            Console.WriteLine("goblin attacked.. you blocked and reflect " + blockdamage + " damage");
            goblinstats[0] = goblinstats[0] - blockdamage;
            string attack = @"                                    
             ///~`     |\\_              
            ,  |='  ,))\_| ~-_       
           / ,' ,;((((((    ~ \        
         /' -~/~)))))))'\_   _/'          
        (       (((((( ~-/ ~-/                 
         ~~--|   ))''    ')  `               
             :        (_  ~\           |`-._/\_.-`|                                   
              \        \_   )--__  /(_/|    ||    |
    ___       |_     \__/~-__    ~~   ,|___o()o___|
  //~~\`\    /' ~~~----|     ~~~~~~~~' |__((<>))__|
((()   `\`\_(_     _-~~-\              \   o\/o   /
 )))     ~----'   /      \              \   ||   /
  (         ;`~--'        :              \  ||  /
            |    `\       |               '.||.'
            |    /'`\     ;                 ``                  
           /~   /    |    )                   
          |    /     / | /                     
          /   /     |  \\|                   
        _/  /'       \  \_)                
       ( )|'         (~-_|       
        ) `\_         |-_;;--__ 
        `----'       (________|\\   `";
            Console.WriteLine(attack);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Console.WriteLine("goblin has " + goblinstats[0] + " health");
            return stats;
        }


        public int Move(Boolean special, int[] stats, int[] goblinstats)
        {
        keuze:;
            int move = 0;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. attack    2. block    3.special");
            string attack = @"
                                    
                                    
                                   
                                    
             ///~`     |\\_              
            ,  |='  ,))\_| ~-_       
           / ,' ,;((((((    ~ \        
         /' -~/~)))))))'\_   _/'          
        (       (((((( ~-/ ~-/                 
         ~~--|   ))''    ')  `               
             :        (_  ~\                 
              \        \_   )--__  /(_/)          
    ___       |_     \__/~-__    ~~   ,'      
  //~~\`\    /' ~~~----|     ~~~~~~~~'        
((()   `\`\_(_     _-~~-\                    
 )))     ~----'   /      \                            
  (         ;`~--'        :                            
            |    `\       |                            
            |    /'`\     ;                     
           /~   /    |    )                   
          |    /     / | /                     
          /   /     |  \\|                   
        _/  /'       \  \_)                
       ( )|'         (~-_|       
        ) `\_         |-_;;--__ 
        `----'       (________|\\   `";
            Console.WriteLine(attack);
            try
            {
                move = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("attack");
                Console.ReadLine();
                Console.Clear();
                goto keuze;
            }
            Console.Clear();
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Console.WriteLine("goblin has " + goblinstats[0] + " health");

            return move;
        }
        public Boolean Special(Boolean special)
        {
            special = false;
            return special;
        }
        public int[] Resethealth(int[] stats, int defaulthealth)
        {
            int[] resethealth = { defaulthealth, stats[1], stats[2], stats[3] };
            return resethealth;
        }


        public int xp(int xpstand, int xp)
        {
            xpstand = xpstand + xp;
            return xpstand;
        }
        public int lvl(int xp, int lvl, int[] stats)
        {
            int lvlcheck = 2 * lvl;
            if (xp >= lvlcheck)
            {
                lvl++;
            oops:;
                Console.WriteLine("lvl up");
                Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
                string keuze = Console.ReadLine();
                Console.Clear();
                try
                {
                    stats[Int32.Parse(keuze) - 1]++;
                }
                catch
                {
                    goto oops;
                }

            }
            return lvl;
        }

        public int lvls(int xp, int lvl, int[] stats, int lvls)
        {
            int up = lvls;
            for (int i = 0; i < lvls; i++)
            {
                lvl++;
            oops:;
                Console.WriteLine(up + " lvls up");
                up--;
                Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
                string keuze = Console.ReadLine();
                Console.Clear();
                try
                {
                    stats[Int32.Parse(keuze) - 1]++;
                }
                catch
                {
                    goto oops;
                }
            }
            return lvl;
        }

        public int[] damage(int[] stats, int[] goblinstats)
        {
            Boolean crit = false;
            for (int i = 0; i < goblinstats[3]; i++)
            {
                Random rnd = new Random();
                int rndnum = rnd.Next(1, 10 + 1);
                if (rndnum == 10)
                {
                    crit = true;
                }
            }
            if (crit == true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("goblin attacks and does " + goblinstats[1] * 2 + " damage");
                stats[0] = stats[0] - goblinstats[1] * 2;
                string attack = @"     
                                *_________                                
             ///~`     |\\_    */         \______=\\\\____|   . .
            ,  |='  ,))\_| ~-_ *|          ________)  \___| _/_/|
           / ,' ,;((((((    * \ *\________/ *    `~~~\-~-_|/~ (_/\
         /' -~/~)))))))'\_   _/' *  *  *  *           \_  /'  D   |
        (       (((((( ~-/ ~-/                          ~-;  /    \--_
         ~~--|   ))''    ')  `                            `~~\_    \   )
             :        (_  ~\                        ,       /~~-     ./
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
                Console.WriteLine("goblin attacks and does " + goblinstats[1] + " damage");
                stats[0] = stats[0] - goblinstats[1];
                string attack = @"     
                                 _________                               
             ///~`     |\\_     /         \______=\\\\____|   . .
            ,  |='  ,))\_| ~-_  |          ________)  \___| _/_/|
           / ,' ,;((((((    * \  \________/      `~~~\-~-_|/~ (_/\
         /' -~/~)))))))'\_   _/'                      \_  /'  D   |
        (       (((((( ~-/ ~-/                          ~-;  /    \--_
         ~~--|   ))''    ')  `                            `~~\_    \   )
             :        (_  ~\                        ,       /~~-     ./
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
            return stats;
        }
        public string name()
        {
            Console.WriteLine("name");
            string name = Console.ReadLine();
            Console.Clear();
            return name;
        }

        public int[] Stats_setup(int lvl)
        {
            int[] stats = { 1, 1, 1, 1 };
            Console.WriteLine(lvl + " points to spend on stats");
            for (int i = 0; i < lvl; i++)
            {
            oops:;
                Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
                string keuze = Console.ReadLine();
                Console.Clear();
                try
                {
                    stats[Int32.Parse(keuze) - 1]++;
                }
                catch
                {
                    goto oops;
                }
            }

            return stats;
        }

        public int[] Stats(int[] stats)
        {
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            return stats;
        }
    }
}
