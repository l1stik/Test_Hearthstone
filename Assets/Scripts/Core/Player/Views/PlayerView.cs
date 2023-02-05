using System.Collections.Generic;
using Core.Card;
using Core.Player.Processes;
using UnityEngine;

namespace Core.Player.Views
{
    public class PlayerView : MonoBehaviour
    {
        private List<CardView> _cardsCollection;
        
        private AiChooseCardProcess _chooseCardProcess;
        
        public void Initialize(AiChooseCardProcess chooseCardProcess)
        {
            _chooseCardProcess = chooseCardProcess;
        }

        public void DisplayCards()
        {
        }

        public void AddCard(CardView cardView)
        {
            _chooseCardProcess.AddCard(cardView);
        }
        
        
        public void RemoveCard(CardView cardView)
        {
            _chooseCardProcess.RemoveCard(cardView);
        }
    }
}