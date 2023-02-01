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
        private PlayerView _playerViewPrefab;
        
        public override void InstallBindings() 
        {
            BindObjectFromInstance(_playerViewPrefab);
            
            BindNonMonoBehaviourClassWithConcreteId<PlayerController>(EnemyPlayerControllerId);
            BindNonMonoBehaviourClassWithConcreteId<PlayerController>(PlayerControllerId);
            
            BindNonMonoBehaviourClassAsSingle<BrainPlayersController>();
        }
    }
}