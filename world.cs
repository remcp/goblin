using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goblin
{
    class world
    {
        public int Worldkeuze(int explored, int[] stats)
        {
            Console.Clear();
            int box = 0;
            int keuze = 0;
            if (explored == 0)
            {
                keuze = 1;
            }
            else if (explored == 1)
            {
                Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("seems like this area is dangerous..");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("it might be best to get out of here..");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("but where you end up might be even worse..");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
            checkinput:;
                Console.WriteLine("1. go back to the room   2. explore the street   0. fight another goblin");
                try
                {
                    keuze = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("at least try choosing a number");
                    Console.ReadLine();
                    Console.Clear();
                    goto checkinput;
                }
            }
            else if (explored == 2)
            {
                Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("and now we are alone in the street again");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("we do see a church further down the road");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("it looks like a great hideout while we figure out what is happening");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("but somehow it does feel very unsafe. maybe we should make sure we explored everything before heading in");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
            checkinput2:;
                Console.WriteLine("1. go back to the room   2. keep exploring the street    3. go to the church    0. fight another goblin");
                try
                {
                    keuze = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("at least try choosing a number");
                    Console.ReadLine();
                    Console.Clear();
                    goto checkinput2;
                }

            }
            else if (explored == 3)
            {
                Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("you hear a loud growl roar nearby");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("while running out of the church you swear to never go back there");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("but what now?");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("probably best to keep training for when we come across something like that again");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
            checkinput2:;
                Console.WriteLine("1. go back to the room   2. keep exploring the street    0. fight another goblin");
                try
                {
                    keuze = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("at least try choosing a number");
                    Console.ReadLine();
                    Console.Clear();
                    goto checkinput2;
                }
                if (keuze == 3)
                {
                    keuze = 2;
                }

            }
            Console.Clear();
            return keuze;
        }
        public Boolean Area1(int[] stats)
        {
            int box = 0;
            int keuze = 0;
            Boolean area1 = true;
        checkinput:;
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("you find yourself in a stange room...");

            string room = @"
       ____________________________________
      / |                                  | 
     /  |                                  |
    /   |                                  |
    |   |                                  |
    |   |             ___                  |
    |   |            |   |                 |
    |   |            |  *|           \____/|
    |   |            |   |       __  |    ||
    |   |____________|___|______|__|_|____||
    |  /                                   |
    | /                                    | 
    |/_____________________________________|
";
        boxes:;
            Console.WriteLine(room);
            Console.WriteLine();
            Console.WriteLine("all you see is a door and some boxes that look empty");
            Console.WriteLine();
            Console.WriteLine("1. leave the room.    2. check out the boxes");
            try
            {
                keuze = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("at least try choosing a number");
                Console.ReadLine();
                Console.Clear();
                goto checkinput;
            }
            if (keuze == 1221)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("nope");
                Console.ReadLine();
                Console.Clear();
            }
            if (keuze == 1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("you walk to the door... open it... and...");
                Console.ReadLine();
                Console.Clear();
                area1 = false;
            }
            if (keuze == 2)
            {
                if (box < 5)
                {
                    box++;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("as expected... the boxes are indeed empty...");
                    string checkbox = @"
                   _____________          
                  /             \   
                 /               \   
                /_________________\  
              /|\                 /|\
             / | \               / | \
            /  |  \_____________/  |  \
           /   |  |             |  |   \
           |  /|  |_____________|  |\  |
           | / |  |             |  | \ |
           |/  |  |_____________|  |  \|
           |   | /               \ |   |
           |   |/_________________\|   |
           |  /  \                / \  | 
           | /    \              /   \ |
           |/      \____________/     \|
";
                    Console.WriteLine(checkbox);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("~~~whoosh~~~ the box transforms into a treasure chest");
                    Console.WriteLine("as soon as you touch the gold it melts away. but a code reveals itself");
                    string checkbox = @"
************************************************************************************
                      _.==''`'=._
                   ,_'_ ,        `'=._
                   '=._o `'=._,       `'=._
                        `'=._o_`'=.__       `'=._
                        __.--,-`'=._o`'=._==_.-='''=._
                   ._--' ,    ;      `'=._o;' ,-'''-._'.
                   |  `'=._ ,  - 1221; , ,  `'=-._   '. ;
                   |       `'=._;  .  ,  '  ,,    '-._; ;
                   |        (#)  `'=._   ,  ;  ,___.--o/
                   |        ' '       `'=.__.--',__.--o;
                   |                     | _.--'       ;
                   `=.o_                 |             ;
                        `'=.o_           |             ;
                              `'=.o_     |       _o.--'
                                    `'=.o|o_.--''
************************************************************************************
";
                    Console.WriteLine(checkbox);
                }
                Console.ReadLine();
                Console.Clear();
                goto boxes;
            }


            Console.Clear();


            return area1;
        }

        public int Area2(int[] stats)
        {
            int spin = 5;
            Boolean spins = false;
            int keuze = 0;
            int area2 = 1;
        checkinput:;
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("at least we are out of that room");
            Console.ReadLine();
        boxes:;
            Console.WriteLine();
            Console.WriteLine("but now we are on a street that looks empty");
            string street = @"
  ~         ~~          __
       _T      .,,.    ~--~ ^^
 ^^   // \                    ~
      ][O]    ^^      ,-~ ~
   /''-I_I         _II____
__/_  /   \ ______/ ''   /'\_,__
  | II--'''' \,--:--..,_/,.-{ },
; '/__\,.--';|   |[] .-.| O{ _ }
:' |  | []  -|   ''--:.;[,.'\,/
'  |[]|,.--'' '',   ''-,.    |
  ..    ..-''    ;       ''. '";
            Console.WriteLine(street);
            Console.WriteLine();
            Console.WriteLine("the goblin had to have come from somewhere");
            Console.WriteLine();
            Console.WriteLine("well no use in staying still here. we should probably go explore");
            Console.WriteLine();

            if (spin > 0)
            {
                Console.WriteLine("or we can stand here and spin around " + spin + " times");
            }

            Console.WriteLine();
            if (spin > 0)
            {
                Console.WriteLine("1. go explore    2. spin");
            }
            else
            {
                spins = true;
                goto spins;
            }
            try
            {
                keuze = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("at least try choosing a number");
                Console.ReadLine();
                Console.Clear();
                goto checkinput;
            }

            if (keuze == 1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("alright its time to go exploring.. but what is that sound behind us?");
                Console.ReadLine();
                Console.Clear();
                area2 = 0;
            }
            if (keuze == 2)
            {
                spin--;
                if (spin < 0) { spin = 0; }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("yeah no clue what spinning was supposed to accomplish");
                Console.ReadLine();
                Console.Clear();
                goto boxes;
            }
        spins:;
            if (spins == true)
            {
                area2 = 3;
            }


            Console.Clear();


            return area2;
        }


        public Boolean Area3(int[] stats)
        {
            int spin = 5;
            int keuze = 0;
            Boolean area2 = true;
            Boolean area3 = true;
        checkinput:;
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("when looking up at the church you feel a chill down your spine");
            Console.ReadLine();
        boxes:;
            Console.WriteLine();
            Console.WriteLine("the massive church door opens slowly");
            string street = @"
                                 !
                               .':'.
                             .':::::'.
                           .':::::::::'.
                         .':::::::::::::'.
                           ||    %    ||
                           ||   .-.   ||
                           ||  /   \  ||
                           || /_____\ ||
                           ||    O    ||
                         .'||_________||'.
                       .' .'""^""^""^""^""^""'. '.
                     .' .'""^""^""^""^""^""^""^""'. '.
                   .' .'""^""^""^""^""^""^""^""^""^""'. '.
                 .'_.'""^""^""^""^""^"".""^""^""^""^""^""'._'.
                    |===========/+\===========|________________________________________
                    |          /-+-\          |""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^\
                    |          |-+-|          |^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^\
                    |          |-+-|          |""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^""^\
                    |          |-+-|          |==========================================='
                    |          |-.-|          |                    .'.                   |
                    |         =.'.'.=         |            .     .'   '.     .           |
           .'.      |        .'.'.'.'.        |           /+\  .'       '.  /+\          |
         .'   '.    |      .'.'.' '.'.'.      |          /-+-\'._.'._.'._.'/-+-\         |
       .'       '.  |    .'.'.'_____'.'.'.    |          |-+-| .'       '. |-+-|         |
      '._.'._.'._.' |  .'.'_____________'.'.  |          |-+-.'           '.-+-|         |
       .'       '.  | `| ||[][][]|[][][]|| |` |          |-+'._.'._.'._.'._.'+-|         |
     .'           '.|  | ||      |      || |  |          |-+-.'           '.-+-|         |
    '._.'._.'._.'._.'  | || ,;;, | .;;. || |  |          ==.'               '.==         |
     .'           '.|  | ||;;{};;|;;{};;|| |  |           '._.'._.'._.'._.'._.'          |
   .'               '. | ||`<><>`|`<><>`|| |  |            .'               '.           |
  '._.'._.'._.'._.'._.'| ||  /\ [|] /\  || |  |__________.'                   '._________|
   .'               '. | ||      |      || |  |         '._.'._.'._.'._.'._.'._.'
 .'                   '. ||      |      || |__|                  _ -
'lc.'._.'._.'._.'._.'._.'[]______|______[]_|_ -
 _ -                     /_______________\   _ -   
               _ -      /_________________\        
                       /___________________\  _ -        _-";
            Console.WriteLine(street);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("time to go inside");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("health " + stats[0] + ", damage " + stats[1] + ", speed " + stats[2] + ", luck " + stats[3]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string inside = @"
        ..        ____                                               ____
       . |       / +  \         ||                       ||         /+ . \
      .  |       |o x.|        =**=          _          =**=        | o x|
     .   |       |____|         ||         _( )_         ||         |____|
    .    |                      ||        /_____\        ||
   .     |                 ______________//|   |/__________________
  .      |_______^________/                | + |                  /____^_____
 .      .       _U_      /                 |___|                 //   _U_
       .         |      /_______________________________________//     |
      .         /|\     |______________________________________|/     /|\
     .   (=========================)     .      . (==========================)
    .    |                         |/|  .       . |                          |
   .     |                         | | .        . |                          |
  .      |_______________________|/|.         . ||------------------------||
     (=========================)  || .          . (==========================|
     |                         |/|  .           . |                          |
     |                         | | .            . |                          |
     |_________________________|/|.             . ||------------------------||
 (=========================)  || .              . (==========================)
 |                         |/|  .               . |                          |
 |                         | | .                . |                          |
 |_________________________|/|.                 . | ________________________ |
 |                        || .                  . ||                        ||
";
            Console.WriteLine(inside);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("you see a big goblin standing on the platform");
            Console.WriteLine();
            Console.WriteLine("do we confront it, or flee");
            Console.WriteLine();
            Console.WriteLine("1. confront    2. flee");
            try
            {
                keuze = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("at least try choosing a number");
                Console.ReadLine();
                Console.Clear();
                goto checkinput;
            }

            if (keuze == 1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("we walk up to the big goblin.. and he jumps at us surprisingly fast");
                Console.ReadLine();
                Console.Clear();
                area3 = false;
            }
            if (keuze == 2)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("we flee back to the street. we should train some more");
                Console.ReadLine();
                Console.WriteLine("but the goblin catches us and makes escape inpossible");
                Console.ReadLine();
                Console.Clear();
                area3 = true;
            }


            Console.Clear();


            return area3;
        }
    }
}
