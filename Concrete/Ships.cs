using Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Concrete
{
    public class Ships : IDestroyer
    {
        public Ships(int size, List<ICoordinates> coordinates)
        {
            this.size = size;
            this.coordinates = coordinates;
            this.has_sink = false;

        }

        public List<ICoordinates> coordinates { get; set; }
   

        private int size;
        private bool has_sink = false;
        public bool hasSunk()
        {
            return this.has_sink;
        }
        private bool check_for_sink()
        {
            int size_to_sink = 0;
            foreach (var item in coordinates)
            {
                size_to_sink += item.coordonateis_hit() ? 1 : 0;
            }
            if (size_to_sink == size) { this.has_sink = true; }
            return this.has_sink;

        }

        public bool checkForHit(ICoordinatesUser coordinate)
        {

            foreach (var item in coordinates)
            {
                if (item.Equals(coordinate))
                {

                    if (item.coordonateis_hit()) throw new Exception("The ship has been hit before");
                    item.target_hit();
                    check_for_sink();
                    return true;
                }
            }


            return false;


        }

    }
}

   