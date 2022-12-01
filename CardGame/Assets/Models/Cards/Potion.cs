using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Cards
{
    public class Potion : Card
    {
        private int _effect;
        private HeroType _hero;
        private PotionType _typePotion;

        public Potion( int cardCost, int cardEffect, PotionType typePotion, HeroType hero)
            : base(cardCost)
        {
            _effect = cardEffect;
            _typePotion = typePotion;
            _hero = hero;
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
        public HeroType Hero
        {
            get => _hero;
            set => _hero = value;
        }
        public override string ToString()
        {
            string statusEffect = TypePotion == PotionType.HEALTH ? "+" : "-";
            return $"({Cost}) {TypePotion} Эффект: {statusEffect + Effect} HP";
        }
    }
}
