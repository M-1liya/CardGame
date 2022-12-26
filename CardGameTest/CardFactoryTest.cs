using FluentAssertions;
using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;
using CardGame.Assets.Model.Factories;

namespace WPFCardGameTests
{
    [TestClass]
    public class CardFactoryTest
    {
        [TestMethod]
        public void HeroFactoryTEST()
        {
            ICardFactory heroFactrory = new HeroFactory();
            Hero drakon = new Hero(cardCost: 5, cardDamage: 6, HeroType.DRAGON, cardHealth: 10);
            drakon.Should().BeEquivalentTo(heroFactrory.Create(HeroType.DRAGON));
        }

        [TestMethod]
        public void potionFactoryTEST()
        {
            ICardFactory potionFactory = new PotionFactory();
            Potion potion = new Potion(cardCost: 3, cardEffect: 2, PotionType.HEALTH);
            potion.Should().BeEquivalentTo(potionFactory.Create(PotionType.HEALTH));
        }
    }
}
