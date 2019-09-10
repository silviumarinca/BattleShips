using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class DrawBoard :IDrawBoard
    {
        private string[,] board { get; set; }
        private List<IDestroyer> ships=new List<IDestroyer>();
        public bool all_ships_are_sinked { get; internal set; }
        private int ships_sunk;
        private int board_size;

        public DrawBoard(List<IDestroyer> ships,int board_size)
        {
            this.board_size = board_size;
            this.all_ships_are_sinked = false;
            board = new string[board_size, board_size];
            for (int i = 0; i < board_size; i++)
            {

                for (int j = 0; j < board_size; j++)
                {
                    board[i, j] = "B";

                }
            }
            this.ships = ships;
          
        }

        public void DrawBoardWindow()
        {

            for (int i = 0; i < board_size; i++)
            {
                Console.Write($"{(char)(65+i)}    ");
                for (int j = 0; j < board_size; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public bool CheckForHit(string x, string y) {
            bool is_hit = false;
            int x_coord = 0;
            int y_coord = 0;
            try
            {
                  x_coord = (int)x[0] - 65;
                bool is_valid = int.TryParse(y, out y_coord);

                y_coord = y_coord -1;
                if (((x_coord < 0 || x_coord > board_size-1) || (y_coord < 0 || y_coord > board_size-1))&&!is_valid)
                {
                    throw new InputValidationException("Inputs are Invalid");

                }
            }
            catch (InputValidationException  ) {

                throw new InputValidationException("Inputs are Invalid");

            }
            foreach (var item in ships) {
             
                if (item.checkForHit(new Coordinates(x_coord, y_coord))) {
                    is_hit = true;
                    if (item.hasSunk()) {
                        foreach (var coord in item.coordinates) {
                            board[coord.x, coord.y] = "S";
                        }
                      
                            ships_sunk++;
                            all_ships_are_sinked = ships_sunk == ships.Count();
                      
                    
                        return is_hit;
                    }
                }
            }
            board[x_coord, y_coord] = is_hit ? "H" : "M";

            return is_hit;

        }

 


    }
}
