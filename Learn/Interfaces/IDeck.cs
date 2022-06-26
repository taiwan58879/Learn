using Learn.Struct;

namespace Learn.Interfaces
{
    internal interface IDeck
    {
        byte CardCount { get; }
        Card DrawCard();
        void Shuffle();
    }
}
