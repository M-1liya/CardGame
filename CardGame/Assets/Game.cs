﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Assets.nsDeck;

namespace CardGame.Assets
{
    public class Game
    {
        private int currentRound;
        static Deck deck = new Deck();

        public Game(int currentRound = 1)
        {
            this.currentRound = currentRound;
        }
        public void Start(Player P1, Player P2)
        {
            for(int i = 0; i < 5; i++)
            {
                P1.handCard.Add(deck.GetCard());
                P2.handCard.Add(deck.GetCard());
            }
        }
    
        public int getCurrentRound => currentRound;
        public void setCurrentRound(int currentRound) { this.currentRound = currentRound; }
    }
}

