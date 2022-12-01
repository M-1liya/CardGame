using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Factories
{
    internal class PotionFactory : CardFactory
    {
        public Card create(Enum type)
        {
            return type switch
            {
                PotionType.HEALTH => new Potion(1, 2, PotionType.HEALTH, HeroType.SHREK),
                PotionType.DAMAGE => new Potion(1, 3, PotionType.DAMAGE, HeroType.DRAGON),
                _ => throw new NotImplementedException()
            };
        }
    }
}
