using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets.nsDeck
{
    public class Deck
    {
        int counter;
        List<Card> cards = new List<Card>() { new Hero(3, 2, "Рыцарь", 5), new Hero(7, 4, "Дракон", 10), new Hero(3, 3, "Шрек", 3), new Hero(3, 5, "Осел", 2) };
        Random random = new Random();
        public Deck()
        {
            this.counter = cards.Count;
        }
        public Card GetCard()
        {
            Card currentCard = cards[random.Next(0,cards.Count)];
            return currentCard;
        }
    }
}
