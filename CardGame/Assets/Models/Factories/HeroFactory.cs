using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Factories
{
    public class HeroFactory : CardFactory
    {
        public Card create(Enum type)
        {
            return type switch
            {
                HeroType.DRAGON => new Hero(1, 4, HeroType.DRAGON, 10),
                HeroType.PRINCESS => new Hero(1, 4, HeroType.PRINCESS, 10),
                HeroType.SHREK => new Hero( 1, 3, HeroType.SHREK, 3),
                HeroType.DONKEY => new Hero(1, 5, HeroType.DONKEY, 2),
                HeroType.KNIGHT => new Hero(1, 20, HeroType.KNIGHT, 5),
                _ => throw new NotImplementedException()
            };
        }
    }
}
