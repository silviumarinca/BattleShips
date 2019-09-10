using Abstractions;
using Concrete.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete
{
   public   class ShipGenerator
    {
        private List<ICoordinates> coord_forValidation;
        private int  board_size=0;
        public ShipGenerator(int board_size )
        {
            this.coord_forValidation = new List<ICoordinates>();
            this.board_size = board_size - 1;

        }
        private bool validateCoordonates(List<ICoordinates> coord) {

            foreach (var items in coord) {
                if (coord_forValidation.Where(c => c.x == items.x && c.y == items.y).Count() > 0) {
                    return false;
                }

            }
            coord_forValidation.AddRange(coord);
            return true;

        }
        private bool DebugEnabled = false;
        public ShipGenerator EnableDebug()
        {
            this.DebugEnabled = true;
            return this;

        }
        public    List<ICoordinates> GenerateShipCoordonates(int size)
        {

            Random rnd = new Random();
            int x = rnd.Next(0, board_size);
            int y = rnd.Next(0, board_size);


            bool is_found = false; ;
            var coordinates = new List<ICoordinates>();






            if (x - size >= 0)
            {
                for (int i = 0; i < size; i++)
                {
                    coordinates.Add(new Coordinates(x - i, y));
                }
                is_found = true;

            }
            else
            {
                if (y - size >= 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        coordinates.Add(new Coordinates(x, y - j));
                    }

                    is_found = true;
                }
                else
                {
                    if (x + size <= board_size)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            coordinates.Add(new Coordinates(x + k, y));
                        }


                        is_found = true;

                    }
                    else
                    {
                        if (y + size <= board_size)
                        {
                            for (int i = 0; i < size; i++)
                            {
                                coordinates.Add(new Coordinates(x, y + i));
                            }

                            is_found = true;
                        }

                    }



                }


            }
            if (!is_found ||!validateCoordonates(coordinates))
            {
                GenerateShipCoordonates(size);

            }
            ///string override coordonates to see ships generated
            ///
            if (this.DebugEnabled)
            {
                coordinates.DrawCoordinates();
            }
            return coordinates;

        }
    }
}
