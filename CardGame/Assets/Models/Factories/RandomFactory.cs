using System;
using System.Collections.Generic;
using System.Linq;
using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Factories
{
    /// <summary>
    ///  Фабрика случайно создающая карту
    /// </summary>
    public static class RandomFactory
    {
        private static Dictionary<string, ICardFactory> Factories = new Dictionary<string, ICardFactory>()
        {
            {"HeroFactory",  new HeroFactory()},
            {"PotionFactory",  new PotionFactory()},
        };
        private static Random Random = new Random();

        /// <summary>
        ///  Метод случайно создаёт карту
        /// </summary>
        /// <returns>Объект карты заклинаний, либо карты героя</returns>
        public static  Card Create()
        {
            ICardFactory factory;

            int countHero = EnumToList<HeroType>().Count;
            int countPotion = EnumToList<PotionType>().Count;
            int rand = Random.Next(countHero + countPotion);

            factory = (rand < countPotion) ? Factories["PotionFactory"] : Factories["HeroFactory"];
            
            Enum type = getType(factory);
            return factory.Create(type);
        }
        /// <summary>
        ///  Случайно выбираем один тип карты из соответсвующей фабрики
        /// </summary>
        /// <param name="factory">Фабрика игровых карт</param>
        /// <returns>Тип карты</returns>
        private static Enum getType(ICardFactory factory)
        {
            return factory switch
            {
                HeroFactory => EnumToList<HeroType>()[ Random.Next(EnumToList<HeroType>().Count) ],
                PotionFactory => EnumToList<PotionType>()[ Random.Next(EnumToList<PotionType>().Count) ],
                _ => throw new NotImplementedException()
            };
        }
        private static List<T> EnumToList<T>()
        {
            return Enum.GetValues(typeof(T))
                        .Cast<T>()
                        .ToList();
        }
    }
}
