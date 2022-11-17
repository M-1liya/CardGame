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
        public List<Card> cards = new List<Card>()
        {
            //Герои
            new Hero(Card.TypeCard.Hero, 4, 2, Card.TypeHero.Knight, 5),
            new Hero(Card.TypeCard.Hero, 7, 4, Card.TypeHero.Dragon, 10),
            new Hero(Card.TypeCard.Hero, 3, 3, Card.TypeHero.Shrek, 3),
            new Hero(Card.TypeCard.Hero, 2, 5, Card.TypeHero.Donkey, 2),
            //Зелья
            new Potion(Card.TypeCard.Potion, 2, 2, Card.TypePotion.Health),
            new Potion(Card.TypeCard.Potion, 3, 3, Card.TypePotion.Damage)
        };
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
