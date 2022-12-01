using CardGame.Assets.Model.Cards;

namespace CardGame.Assets.Model.Factories
{
    internal interface CardFactory
    {
        abstract Card create(Enum type);
    }
}
