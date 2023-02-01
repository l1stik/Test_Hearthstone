using Core.Player;
using Core.Player.Controllers;
using Core.Player.Views;
using UnityEngine;

namespace Core.Installers
{
    public class PlayersInstaller : BaseMonoInstaller
    {
        private const int EnemyPlayerControllerId = 0;
        private const int PlayerControllerId = 1;
        
        [SerializeField]
        private PlayerView _playerView;
        
        [SerializeField]
        private PlayerView _aiPlayerView;
        
        public override void InstallBindings()
        {
            BindObjectFromInstance(_playerView);
            BindObjectFromInstance(_aiPlayerView);
            
            BindNonMonoBehaviourClassWithConcreteId<PlayerController>(EnemyPlayerControllerId);
            BindNonMonoBehaviourClassWithConcreteId<PlayerController>(PlayerControllerId);
            
            BindNonMonoBehaviourClassAsSingle<BrainPlayersController>();
        }
    }
}