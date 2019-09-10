using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
   public interface IDestroyer 
    {
        List<ICoordinates> coordinates { get; set; }
        bool hasSunk();
        bool checkForHit(ICoordinatesUser coordinate);
    }
}
