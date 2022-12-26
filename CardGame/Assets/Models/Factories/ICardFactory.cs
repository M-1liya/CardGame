using System;
using CardGame.Assets.Model.Cards;

namespace CardGame.Assets.Model.Factories
{
    /// <summary>
    ///  Фабрика игровых карт
    /// </summary>
    public interface ICardFactory
    {
        Card Create(Enum type);
    }
}
