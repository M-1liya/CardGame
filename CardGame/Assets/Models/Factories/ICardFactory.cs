using CardGame.Assets.Model.Cards;

namespace CardGame.Assets.Model.Factories
{
    internal interface ICardFactory
    {
        abstract Card create(Enum type);
    }
}
