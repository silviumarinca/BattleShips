namespace Abstractions
{
    public interface ICoordinates : ICoordinatesUser
    {
 
        bool coordonateis_hit();
        void target_hit();
    }

    public interface ICoordinatesUser
    {
        int x { get; }
        int y { get; }

      
    }
}