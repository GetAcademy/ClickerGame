using System;
using System.Text;

namespace ClickerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var games = new Game[]
            {
                new Game('A','B'), 
                new Game('C','D'),
                new Game('E','F'),
            };
            while (true)
            {
                Console.Clear();
                foreach (var game in games)
                {
                    Console.WriteLine(game.UpdateView());
                }
                var keyInfo = Console.ReadKey();
                foreach (var game in games)
                {
                    if(keyInfo.KeyChar == game.ClickChar) game.DoClick();
                    else if (keyInfo.KeyChar == game.UpgradeChar) game.BuyUpgrade();
                }
            }
        }
    }
}
