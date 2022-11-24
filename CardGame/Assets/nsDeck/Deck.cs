using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace CardGame.Assets.nsDeck
{
    public class Deck
    {
        int counter;
        private List<Card> cards = new List<Card>()
        {
            //Герои
            new Hero(Card.ETypeCard.Hero, 1, 2, Hero.ETypeHero.Knight, 5),
            new Hero(Card.ETypeCard.Hero, 1, 4, Hero.ETypeHero.Dragon, 10),
            new Hero(Card.ETypeCard.Hero, 1, 3, Hero.ETypeHero.Shrek, 3),
            new Hero(Card.ETypeCard.Hero, 1, 5, Hero.ETypeHero.Donkey, 2),
            //Зелья
            new Potion(Card.ETypeCard.Potion, 1, 2, Potion.ETypePotion.Health, Hero.ETypeHero.Shrek),
            new Potion(Card.ETypeCard.Potion, 1, 3, Potion.ETypePotion.Damage, Hero.ETypeHero.Dragon),
        };
        Random random = new Random();
        public Deck() { this.counter = cards.Count; }
        public Card getCards()
        {
            var card = cards[random.Next(0, cards.Count)];
            if (card is Hero)
                return (Hero)card.Clone();
            else
                return (Potion)card.Clone();
            //return (cards[random.Next(0, cards.Count)] is Hero) ? (Hero)cards[random.Next(0, cards.Count)].Clone(): (Potion)cards[random.Next(0, cards.Count)].Clone();
        }

    }
}
