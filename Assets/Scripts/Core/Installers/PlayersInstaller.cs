using Core.Field;
using Core.MetaData;
using Core.Player;
using Core.Player.Controllers;
using Core.Player.Processes;
using Core.Player.Views;
using UnityEngine;

namespace Core.Installers
{
    public class PlayersInstaller : BaseMonoInstaller
    {
        [SerializeField]
        private PlayerButtonsView _playerView;
        
        [SerializeField]
        private PlayerView _aiPlayerView;
        
        public override void InstallBindings()
        {
            var aiFieldController = new FieldController();
            var playerFieldController = new FieldController();
            
            var aiPlayerController = new PlayerController();
            var playerController = new PlayerController();
            
            aiPlayerController.Initialize(aiFieldController);
            playerController.Initialize(playerFieldController);
            
            var playerChooseCardProcess = new PlayerChooseCardProcess();
            var aiChooseCardProcess = new AiChooseCardProcess();
            
            playerChooseCardProcess.Initialize(playerController);
            aiChooseCardProcess.Initialize(aiPlayerController);
            
            _playerView.Initialize(playerChooseCardProcess);
            _aiPlayerView.Initialize(aiChooseCardProcess);
            
            
            BindNonMonoBehaviourClassFromInstanceWithConcreteId<FieldController>(
                aiFieldController, GameConstants.AiPlayerId);
            
            BindNonMonoBehaviourClassFromInstanceWithConcreteId<FieldController>(
                playerFieldController, GameConstants.AiPlayerId);
            
            BindNonMonoBehaviourClassFromInstanceWithConcreteId<PlayerChooseCardProcess>(
                playerChooseCardProcess, GameConstants.AiPlayerId);
            
            BindNonMonoBehaviourClassFromInstanceWithConcreteId<AiChooseCardProcess>(
                aiChooseCardProcess, GameConstants.AiPlayerId);

            BindNonMonoBehaviourClassFromInstanceWithConcreteId<PlayerController>(
                aiPlayerController, GameConstants.AiPlayerId);
            BindNonMonoBehaviourClassFromInstanceWithConcreteId<PlayerController>(
                playerController, GameConstants.PlayerId);
            
            BindNonMonoBehaviourClassAsSingle<BrainPlayers>();
        }
    }
}