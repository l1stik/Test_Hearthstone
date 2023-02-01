
using Core.Battle;

namespace Core.Installers
{
    public class BattleInstaller : BaseMonoInstaller
    {
        public override void InstallBindings()
        {
            BindNonMonoBehaviourClassAsSingle<BattleController>();

        }
    }
}