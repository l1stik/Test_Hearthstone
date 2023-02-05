using System.Threading;
using System.Threading.Tasks;
using Core.Other;
using Core.Player.Controllers;
using Core.Player.Processes;
using UnityEngine;
using Zenject;

namespace Core.Player
{
    public class BrainPlayers
    {
        [Inject]
        private FieldCardsHolder _fieldCardsHolder;
        
        [Inject(Id = 0)]
        private PlayerController _aiPlayerController;
        
        [Inject(Id = 1)]
        private PlayerController _participantPlayerController;
        
        [Inject] 
        private PlayerChooseCardProcess _playerChooseCardProcess;
        
        [Inject] 
        private AiChooseCardProcess _aiChooseCardProcess;

        CancellationTokenSource _cancelTokenSourceForPlayer = new CancellationTokenSource();
        
        public async Task<Task> Preparation()
        {
            _participantPlayerController.GenerateCardPool(
                Random.Range(1, 8), _fieldCardsHolder.HolderForPlayer);
            
            _aiPlayerController.GenerateCardPool(
                Random.Range(1, 8), _fieldCardsHolder.HolderForAiPlayer);
            
            _aiChooseCardProcess.RunChooseCardProcess();
            await _playerChooseCardProcess.RunChooseCardProcess(_cancelTokenSourceForPlayer);
            
            return Task.CompletedTask;
        }
    }
}