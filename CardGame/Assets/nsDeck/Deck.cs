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
        private List<Card> cards = new List<Card>()
        {
            //Герои
            new Hero(Card.TypeCard.Hero, 1, 2, Hero.TypeHero.Knight, 5),
            new Hero(Card.TypeCard.Hero, 7, 4, Hero.TypeHero.Dragon, 10),
            new Hero(Card.TypeCard.Hero, 3, 3, Hero.TypeHero.Shrek, 3),
            new Hero(Card.TypeCard.Hero, 2, 5, Hero.TypeHero.Donkey, 2),
            //Зелья
            new Potion(Card.TypeCard.Potion, 2, 2, Potion.TypePotion.Health),
            new Potion(Card.TypeCard.Potion, 3, 3, Potion.TypePotion.Damage)
        };
        Random random = new Random();
        public Deck() { this.counter = cards.Count; }
        public Card Cards => cards[random.Next(0, cards.Count)];
    }
}
