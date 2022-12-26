﻿using CardGame.Assets.Model;
using CardGame.Assets.Model.Cards;
using CardGame.Assets.Util;

namespace CardGame.Assets
{
    public class Player
    {
        private Deck _deck;
        private bool _move;
        private int _healthNexus;
        private int _mana;
        private BattleStatus _battleStatus;
        public Player(BattleStatus battleStatus,
                        int heatNexus = GameConst.BASE_HEALTH_NEXUS,
                        int mana = GameConst.BASE_MANA_PLAYER,
                        bool move = false)
        {
            _healthNexus = heatNexus;
            _mana = mana;
            _deck = new Deck();
            _battleStatus = battleStatus;
            _move = move;
        }

        /// <summary>
        /// Проверка можем ли мы положить карту на игровое поле игрока
        /// </summary>
        /// <param name="playerCard">Карта игрока</param>
        /// <returns>true/false</returns>
        public bool IsCanPutCard(Card playerCard)
        {
            if(playerCard== null) return false;
            return (playerCard.Cost <= _mana) ? true : false;
        }
        public Deck Deck
        {
            get => _deck;
            set => _deck = value;
        }
        public int HealthNexus
        {
            get => _healthNexus;
            set => _healthNexus = value;
        }
        public int Mana
        {
            get => _mana;
            set => _mana = value;
        }
        public bool Move
        {
            get => _move;
            set => _move = value;
        }
        public BattleStatus BattleStatus
        {
            get => _battleStatus;
            set => _battleStatus = value;
        }
    }
}
