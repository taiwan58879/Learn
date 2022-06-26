using Learn.Interfaces;
using Learn.Struct;

namespace Learn.Models
{
    internal class DefaultCardComparBehavior : ICardComparBehavior
    {
        public ICardCompar Is(Card card)
        {
            return new DefaultCardCompar(card);
        }
    }
}
