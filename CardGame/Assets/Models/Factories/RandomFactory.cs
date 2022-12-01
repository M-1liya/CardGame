using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Factories
{
    public static class RandomFactory
    {
        private static CardFactory[] Factories = new CardFactory[]{ new HeroFactory(), new PotionFactory() };
        private static Random Random = new Random();
        public static  Card create()
        {
            CardFactory factory = Factories[Random.Next(Factories.Length)];
            Enum type = getType(factory);
            return factory.create(type);
        }
        private static Enum getType(CardFactory factory)
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
