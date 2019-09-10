namespace Abstractions
{
    public interface IDrawBoard
    {
        bool all_ships_are_sinked { get; }

        bool CheckForHit(string x, string y);
        void DrawBoardWindow();
    }
}