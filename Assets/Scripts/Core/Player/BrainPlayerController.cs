using Core.Other;
using Core.Player.Controllers;
using UnityEngine;
using Zenject;

namespace Core.Player
{
    public class BrainPlayerController
    {
        [Inject]
        private CardsHolder _cardsHolder;
        
        [Inject(Id = 0)]
        private PlayerController _aiPlayerController;
        
        [Inject(Id = 1)]
        private PlayerController _participantPlayerController;
        
        public void Preparation()
        {
            _aiPlayerController.GenerateCardPool(
                Random.Range(1, 8), _cardsHolder.HolderForAiPlayer);
            
            _participantPlayerController.GenerateCardPool(
                Random.Range(1, 8), _cardsHolder.HolderForPlayer);
        }
    }
}