using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Cards
{
    public class Potion : Card
    {
        private int _effect;
        private PotionType _typePotion;

        public Potion( int cardCost, int cardEffect, PotionType typePotion)
            : base(cardCost)
        {
            _effect = cardEffect;
            _typePotion = typePotion;
        }
        public PotionType TypePotion
        {
            get => _typePotion;
            set => _typePotion = value;
        }
        public int Effect
        {
            get => _effect;
            set => _effect = value;
        }
        public override string ToString()
        {
            //string statusEffect = TypePotion == PotionType.HEALTH ? "+" : "-";
            return $"({Cost}) {TypePotion} Эффект: {Effect} HP";
        }
    }
}
