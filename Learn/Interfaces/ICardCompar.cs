using Learn.Struct;

namespace Learn.Interfaces
{
    internal interface ICardCompar
    {
        bool LargerThen(Card card);
        bool LesserThen(Card card);
    }
}
