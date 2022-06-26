using Learn.DependencyInjection;
using Learn.DependencyInjection.Extensions;
using Learn.DependencyInjection.Interfaces;
using Learn.Interfaces;
using Learn.Models;
using System;

namespace Learn
{
    class Program
    {
        public static int Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            IContainerProvider containerProvider = Entry.GetContainerRegistry()
                  .RegisterSingleton<ICardComparBehavior, DefaultCardComparBehavior>()
                  .RegisterSingleton<IDeck, Deck>()
                  //.RegisterSingleton<ICardComparBehavior, DefaultCardComparBehavior>()
                  //.RegisterSingleton<ICardComparBehavior, DefaultCardComparBehavior>()
                  //.RegisterSingleton<ICardComparBehavior, DefaultCardComparBehavior>()
                  .RegisterSingleton<Game, Game>()
                  .CreateContainerProvider();

            Game? game = containerProvider.Resolve<Game>();

            if (game != null)
            {
                game.AddPlayers(new HumanPlayer(),
                    new ComputerPlayer(),
                    new ComputerPlayer(),
                    new ComputerPlayer());

                game.Start();
            }

            Console.ReadLine();

            return 0;
        }
    }
}