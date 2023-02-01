using Core.Field;
using Core.Other;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core.Installers
{
    public class FieldInstaller : BaseMonoInstaller
    {
        [FormerlySerializedAs("_cardsHolder")] [SerializeField]
        private FieldCardsHolder fieldCardsHolder;
        
        public override void InstallBindings()
        {
            BindNonMonoBehaviourClassAsSingle<FieldController>();
            BindObjectFromInstance(fieldCardsHolder);
        }
    }
}