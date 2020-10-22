using System;

namespace slagsmål
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string start;
            inte hp = 180;

            Console.ForegroundColor = ConsoleColor.Red;

            System.Console.WriteLine(@" 
            
______  _         _      _      __                                            _  _   __       
|  ___|(_)       | |    | |    / _|                                          | |(_) / _|      
| |_    _   __ _ | |__  | |_  | |_   ___   _ __   _   _   ___   _   _  _ __  | | _ | |_   ___ 
|  _|  | | / _` || '_ \ | __| |  _| / _ \ | '__| | | | | / _ \ | | | || '__| | || ||  _| / _ \
| |    | || (_| || | | || |_  | |  | (_) || |    | |_| || (_) || |_| || |    | || || |  |  __/
\_|    |_| \__, ||_| |_| \__| |_|   \___/ |_|     \__, | \___/  \__,_||_|    |_||_||_|   \___|
            __/ |                                  __/ |                                      
           |___/                                  |___/                                       
                                                                                              
        ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What is you name?");

            name = Console.ReadLine();
            
            Console.WriteLine("Hej" + name + "är du redo?");
            Console.WriteLine("Skriv starta för att börja spelet");
            start = Console.ReadLine();




        }
    }
}
