using Learn.Enum;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Learn.Struct
{
    internal struct Card
    {
        public SuitEnum Suit { get; }
        public RankEnum Rank { get; }
        public Card(SuitEnum suit, RankEnum rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public static bool operator ==(Card card1, Card card2)
        {
            return card1.Suit == card2.Suit && card1.Rank == card2.Rank;
        }
        public static bool operator !=(Card card1, Card card2)
        {
            return card1.Suit != card2.Suit || card1.Rank != card2.Rank;
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return obj is Card other && this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Suit, Rank);
        }

        public override string ToString()
        {
            return $"{Suit.ToStr()} {Rank.ToStr()}";
        }
    }
}
