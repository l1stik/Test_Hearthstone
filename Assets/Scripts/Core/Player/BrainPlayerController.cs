using Core.Other;
using Core.Player.Controllers;
using UnityEngine;
using Zenject;

namespace Core.Player
{
    public class BrainPlayerController
    {
        [Inject]
        private FieldCardsHolder _fieldCardsHolder;
        
        [Inject(Id = 0)]
        private PlayerController _aiPlayerController;
        
        [Inject(Id = 1)]
        private PlayerController _participantPlayerController;
        
        public void Preparation()
        {
            _aiPlayerController.GenerateCardPool(
                Random.Range(1, 8), _fieldCardsHolder.HolderForAiPlayer);
            
            _participantPlayerController.GenerateCardPool(
                Random.Range(1, 8), _fieldCardsHolder.HolderForPlayer);
        }
    }
}