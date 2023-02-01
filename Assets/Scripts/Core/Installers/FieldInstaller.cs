using Core.Field;
using Core.Other;
using UnityEngine;

namespace Core.Installers
{
    public class FieldInstaller : BaseMonoInstaller
    {
        [SerializeField]
        private CardsHolder _cardsHolder;
        
        public override void InstallBindings()
        {
            BindNonMonoBehaviourClassAsSingle<FieldController>();
            BindObjectFromInstance(_cardsHolder);
        }
    }
}