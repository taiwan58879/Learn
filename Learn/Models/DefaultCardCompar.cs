using Learn.Interfaces;
using Learn.Struct;
using System.Diagnostics;

namespace Learn.Models
{
    internal class DefaultCardCompar: ICardCompar
    {
        private Card card;

        public DefaultCardCompar(Card card)
        {
            this.card = card;
        }

        public bool LargerThen(Card other)
        {
            if (this.card == other)
            {
                Debug.Print("Two same card, No way!");
                return false;
            }

            if (this.card.Rank > other.Rank)
            { return true; }

            if (this.card.Rank == other.Rank && this.card.Suit > other.Suit)
            { return true; }

            return false;
        }

        public bool LesserThen(Card other)
        {
            if (this.card == other)
            {
                Debug.Print("Two same card, No way!");
                return false;
            }

            return !LargerThen(other);
        }
    }
}
