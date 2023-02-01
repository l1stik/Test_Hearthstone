using System.Collections.Generic;
using Core.Card;
using UnityEngine;

namespace Core.Player.Views
{
    public class PlayerView : MonoBehaviour
    {
        private List<CardView> _cardViews;

        public void Init(List<CardView> cardViews)
        {
            _cardViews = cardViews;
        }
        
        public void DisplayAnimation(CardView cardView)
        {
            
        }
    }
}