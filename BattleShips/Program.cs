using System;
using System.Collections.Generic;

namespace BattleShips
{
    class Program
    {
        static void Main(string[] args)
        {

            bool with_debug = false;
            var dr = Factory.Factory.CreateDrawBoard(with_debug);

             dr.DrawBoardWindow();
            string x ,y = "";
            while (!dr.all_ships_are_sinked) {
                      Console.Write("x=");
                  x = Console.ReadLine();
                      Console.Write("y=");
                  y = Console.ReadLine();
                try
                {
                    dr.CheckForHit(x, y);
                }
                catch (Exception e) {
                    Console.WriteLine($"Error! {e.Message}!!");
                }
                dr.DrawBoardWindow(); 
            }
            Console.WriteLine("All the ships where sunked");
            Console.ReadLine();


        }
    }
}
