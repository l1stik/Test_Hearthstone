using System.Collections.Generic;
using Core.Card;
using Core.Player.Controllers;
using UnityEngine;
using Zenject;

namespace Core.Player.Views
{
    public class PlayerView : MonoBehaviour
    {
        [Inject]
        private PlayerController _playerController;

        public void Init()
        {
            
        }
        
        public void DisplayAnimation(CardView cardView)
        {
            
        }
        
        public void ChangeCardData(CardView cardView)
        {
            
        }
    }
}