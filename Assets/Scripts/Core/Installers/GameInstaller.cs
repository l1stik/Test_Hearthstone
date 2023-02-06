
using Core.Battle;
using Core.Card.Factory;

namespace Core.Installers
{
    public class GameInstaller : BaseMonoInstaller
    {
        public override void InstallBindings()
        {
            BindNonMonoBehaviourClassAsSingle<GameRunner>();
            BindNonMonoBehaviourClassAsSingle<CardConfigBuildingFactory>();
        }
    }
}