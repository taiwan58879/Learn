using Learn.DependencyInjection.Extensions;
using Learn.DependencyInjection.Interfaces;
using Learn.Interfaces;

namespace Learn.Models
{
    internal class Game : IGame
    {
        private readonly IContainerProvider containerProvider;
        private readonly IDeck deck;

        public Game(IContainerProvider containerProvider)
        {
            this.containerProvider = containerProvider;
            this.deck = containerProvider.Resolve<IDeck>();
        }

        public void AddPlayers(params IPlayer[] players)
        {

        }

        public void Start()
        {
            this.deck.Shuffle();
#if DEBUG
            if (this.deck is Deck deck)
            {
                deck.PrintCards();
            }
#endif
        }
    }
}
