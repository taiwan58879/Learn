using Learn.Enum;
using Learn.Interfaces;
using Learn.Struct;
using System;
using System.Collections.Generic;

namespace Learn.Models
{
    internal class Deck : IDeck
    {
        private readonly Queue<Card> cards = new Queue<Card>(52);

        public byte CardCount => (byte)this.cards.Count;

        public Card DrawCard()
        {
            if (CardCount > 1)
            {
                return this.cards.Dequeue();
            }
            else
            {
                throw new System.InvalidOperationException("Deck has no any card.");
            }
        }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>(NewCards());

            Random random1 = new Random(DateTime.Now.Millisecond);
            Random random2 = new Random((DateTime.Now.Millisecond / 2) + 1);

            this.cards.Clear();
            int index;
            while (newCards.Count > 0)
            {
                if (newCards.Count % 2 == 0)
                {
                    index = random1.Next(0, newCards.Count);
                }
                else
                {
                    index = random2.Next(0, newCards.Count);
                }
                Card card = newCards[index];
                newCards.Remove(card);
                this.cards.Enqueue(card);
            }
        }

        public void PrintCards()
        {
            Card[] temp = this.cards.ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine($"Card {(i + 1).ToString().PadLeft(2, '0')} {temp[i]}");
            }
        }

        private static Card[] NewCards()
        {
            return new Card[]
            {
                new Card(SuitEnum.Spade, RankEnum.__A),
                new Card(SuitEnum.Spade, RankEnum.__2),
                new Card(SuitEnum.Spade, RankEnum.__3),
                new Card(SuitEnum.Spade, RankEnum.__4),
                new Card(SuitEnum.Spade, RankEnum.__5),
                new Card(SuitEnum.Spade, RankEnum.__6),
                new Card(SuitEnum.Spade, RankEnum.__7),
                new Card(SuitEnum.Spade, RankEnum.__8),
                new Card(SuitEnum.Spade, RankEnum.__9),
                new Card(SuitEnum.Spade, RankEnum._10),
                new Card(SuitEnum.Spade, RankEnum.__J),
                new Card(SuitEnum.Spade, RankEnum.__Q),
                new Card(SuitEnum.Spade, RankEnum.__K),

                new Card(SuitEnum.Heart, RankEnum.__A),
                new Card(SuitEnum.Heart, RankEnum.__2),
                new Card(SuitEnum.Heart, RankEnum.__3),
                new Card(SuitEnum.Heart, RankEnum.__4),
                new Card(SuitEnum.Heart, RankEnum.__5),
                new Card(SuitEnum.Heart, RankEnum.__6),
                new Card(SuitEnum.Heart, RankEnum.__7),
                new Card(SuitEnum.Heart, RankEnum.__8),
                new Card(SuitEnum.Heart, RankEnum.__9),
                new Card(SuitEnum.Heart, RankEnum._10),
                new Card(SuitEnum.Heart, RankEnum.__J),
                new Card(SuitEnum.Heart, RankEnum.__Q),
                new Card(SuitEnum.Heart, RankEnum.__K),

                new Card(SuitEnum.Diamond, RankEnum.__A),
                new Card(SuitEnum.Diamond, RankEnum.__2),
                new Card(SuitEnum.Diamond, RankEnum.__3),
                new Card(SuitEnum.Diamond, RankEnum.__4),
                new Card(SuitEnum.Diamond, RankEnum.__5),
                new Card(SuitEnum.Diamond, RankEnum.__6),
                new Card(SuitEnum.Diamond, RankEnum.__7),
                new Card(SuitEnum.Diamond, RankEnum.__8),
                new Card(SuitEnum.Diamond, RankEnum.__9),
                new Card(SuitEnum.Diamond, RankEnum._10),
                new Card(SuitEnum.Diamond, RankEnum.__J),
                new Card(SuitEnum.Diamond, RankEnum.__Q),
                new Card(SuitEnum.Diamond, RankEnum.__K),

                new Card(SuitEnum.Club, RankEnum.__A),
                new Card(SuitEnum.Club, RankEnum.__2),
                new Card(SuitEnum.Club, RankEnum.__3),
                new Card(SuitEnum.Club, RankEnum.__4),
                new Card(SuitEnum.Club, RankEnum.__5),
                new Card(SuitEnum.Club, RankEnum.__6),
                new Card(SuitEnum.Club, RankEnum.__7),
                new Card(SuitEnum.Club, RankEnum.__8),
                new Card(SuitEnum.Club, RankEnum.__9),
                new Card(SuitEnum.Club, RankEnum._10),
                new Card(SuitEnum.Club, RankEnum.__J),
                new Card(SuitEnum.Club, RankEnum.__Q),
                new Card(SuitEnum.Club, RankEnum.__K),
            };
        }
    }
}
