using System;
using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Factories
{
    /// <summary>
    ///  Фабрика карт героев
    /// </summary>
    public class HeroFactory : ICardFactory
    {
        /// <summary>
        ///  Создание объекта героя
        /// </summary>
        /// <param name="type">Ожидается HeroType</param>
        /// <returns>Объект героя</returns>
        public Card Create(Enum type)
        {
            return type switch
            {
                HeroType.SHREK =>       new Hero(cardCost: 1, cardDamage: 3, HeroType.SHREK, cardHealth: 3),
                HeroType.DONKEY =>      new Hero(cardCost: 2, cardDamage: 5, HeroType.DONKEY, cardHealth: 2),
                HeroType.PRINCESS =>    new Hero(cardCost: 3, cardDamage: 2, HeroType.PRINCESS, cardHealth: 10),
                HeroType.DRAGON =>      new Hero(cardCost: 5, cardDamage: 6, HeroType.DRAGON, cardHealth: 10),
                HeroType.KNIGHT =>      new Hero(cardCost: 8, cardDamage: 20, HeroType.KNIGHT, cardHealth: 5),
                
                _ => throw new NotImplementedException()
            };
        }
    }
}
