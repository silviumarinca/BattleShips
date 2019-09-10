using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete
{
    public class Coordinates : ICoordinates
    {
        public Coordinates(int x, int y)
        {
            

            this.x = x;
            this.y = y;


            this.is_hit = false;
        }
        public int x { get; internal set; }
        public int y { get; internal set; }
        private bool is_hit { get; set; }
        public bool coordonateis_hit()
        {
            return this.is_hit;
        }
        public void target_hit()
        {
            this.is_hit = true;
        }
        public override bool Equals(Object y)
        {
            var yobj = y as Coordinates;
            if (yobj == null)
            {
                return false;
            }

            return this.x == yobj.x && this.y == yobj.y;
        }

        public override int GetHashCode()
        {
            return this.x.GetHashCode() * this.y.GetHashCode();
        }
        public override string ToString()
        {
            return $"Coordonates are {x+1}-{y+1}";
        }
    }
}
 