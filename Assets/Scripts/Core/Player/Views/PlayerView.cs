using System.Collections.Generic;
using Core.Card;
using UnityEngine;

namespace Core.Player.Views
{
    public class PlayerView : MonoBehaviour
    {
        private List<CardView> _cardViews;

        public void DisplayCards(List<CardView> cardViews, Transform parent)
        {
            transform.SetParent(parent);
        }
    }
}