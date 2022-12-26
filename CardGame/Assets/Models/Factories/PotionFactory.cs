using System;
using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Factories
{
    /// <summary>
    ///  Фабрика карт заклинаний
    /// </summary>
    public class PotionFactory : ICardFactory
    {
        /// <summary>
        ///  Создание объекта карты заклинаний
        /// </summary>
        /// <param name="type">Ожидается PotionType</param>
        /// <returns>Объект карты заклинаний</returns>
        public Card Create(Enum type)
        {
            return type switch
            {
                PotionType.HEALTH => new Potion(cardCost: 3, cardEffect: 2, PotionType.HEALTH),
                PotionType.DAMAGE => new Potion(cardCost: 3, cardEffect: 3, PotionType.DAMAGE),
                _ => throw new NotImplementedException()
            };
        }
    }
}
