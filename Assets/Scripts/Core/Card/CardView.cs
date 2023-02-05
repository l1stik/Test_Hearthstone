using System;
using Core.Card.Config;
using Core.Other;
using UnityEngine;

namespace Core.Card
{
    [RequireComponent(typeof(DragAndDropComponent))]
    public class CardView : MonoBehaviour
    {
        private const string fieldTag = "Field";
       
        private CardConfig _cardConfig;
        private CardState _cardState;
        
        public event Action<CardView> OnStateChanged = delegate { };

        public string Name => _cardConfig.Name;
        public CardState State => _cardState;
        
        public void SetCardConfig(CardConfig cardConfig)
        {
            _cardConfig = cardConfig;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.CompareTag(fieldTag))
            {
                _cardState = CardState.OnField;
                OnStateChanged?.Invoke(this);
            }
        }
        
        private void OnTriggerExit(Collider other)
        {
            if (other.transform.CompareTag(fieldTag))
            {
                _cardState = CardState.InHand;
                OnStateChanged?.Invoke(this);
            }
        }
    }
}