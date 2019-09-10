using Abstractions;
using Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Metoda EnableDebug permite vizualizarea navelor generate aleator de program
    /// </summary>


    public static class Factory 
    {

 
        public static IDrawBoard CreateDrawBoard(bool has_debug )
        {
            int board_size = 10;
            var gen = new ShipGenerator(board_size)//.EnableDebug();

            return new DrawBoard(new List<IDestroyer>() {
                  new Ships(5,gen.GenerateShipCoordonates(5)),
                  new Ships(4,gen.GenerateShipCoordonates(4)),
                  new Ships(4,gen.GenerateShipCoordonates(4))


            }  , board_size);
        }


    }
}
