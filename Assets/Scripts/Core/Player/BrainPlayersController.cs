using System.Threading;
using Core.Other;
using Core.Player.Controllers;
using UnityEngine;
using Zenject;

namespace Core.Player
{
    // mediator
    public class BrainPlayersController
    {
        [Inject]
        private FieldCardsHolder _fieldCardsHolder;
        
        [Inject(Id = 0)]
        private PlayerController _aiPlayerController;
        
        [Inject(Id = 1)]
        private PlayerController _participantPlayerController;
        
        CancellationTokenSource _cancelTokenSourceForPlayer = new CancellationTokenSource();
        
        CancellationTokenSource _cancelTokenSourceForAi = new CancellationTokenSource();
        
        public async void Preparation()
        {
            _participantPlayerController.GenerateCardPool(
                Random.Range(1, 8), _fieldCardsHolder.HolderForPlayer);
            
            _aiPlayerController.GenerateCardPool(
                Random.Range(1, 8), _fieldCardsHolder.HolderForAiPlayer);
            
            await _participantPlayerController.ChooseCard(_cancelTokenSourceForPlayer);
            _aiPlayerController.ChooseCard(_cancelTokenSourceForAi);
        }
        
        
        public void RunBattle()
        {
        }
        
        public void FinishBattle()
        {
        }
    }
}