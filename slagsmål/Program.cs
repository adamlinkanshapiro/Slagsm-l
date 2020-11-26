using System;

namespace slagsmål
{
    class Program
    {
        static void Main(string[] args)
        {


            string start;
            int hp = 180;

            Console.ForegroundColor = ConsoleColor.Red;

            System.Console.WriteLine(@" 

__                       __                                                 
|  |()       | |    | |    / |                                          | |() / |
| |        _ | |  | |  | |                           | |  | |    
|  |  | | / ` || ' \ | | |  | /  \ | '| | | | | / _ \ | | | || '| |    | /  \
| |    |  (_|  | |  |  | |  | ()  |    | || || ()  |_|  |    |   |  |  /
_|    || _, ||| || _| ||   _/ ||     _, | _/  _,|    ||||   _|
            / |                                  / |
           |/                                  |/

        ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What is you name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hej " + name + " är du redo?");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Current HP = 100");

            Console.WriteLine("tryck enter för att börja spelet");
            Console.ReadLine();

            int nHp = 100;
            int mHp = 100;

            while (nHp > 0 && mHp > 0)

            {
                System.Console.WriteLine("You have " + nHp + "HP.\n" + "The monster has " + mHp + "HP.");

                Console.WriteLine("Choose between knife and sword");
                string weapon = Console.ReadLine().ToLower();

                Random generator = new Random();

                int knife = generator.Next(5, 20);
                int sword = generator.Next(10, 15);
                int monster = generator.Next(5, 20);

                if (weapon == "knife")
                {
                    System.Console.WriteLine("You slice the monster.");
                    mHp -= knife;

                    System.Console.WriteLine("the moster attacks you!");
                    nHp -= monster;
                }
            }










        }
    }
}