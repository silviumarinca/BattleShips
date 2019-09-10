using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete.Extensions
{
   public static  class DrawCoordExtension
    {

        public static void DrawCoordinates(this List<ICoordinates> coord) {
         
            Console.WriteLine($"------Ship  ------");
            coord.ForEach(el =>
            {    

                Console.WriteLine(el.ToString());

            });
            Console.WriteLine($"------Ship  ------");
        }
    }
}
