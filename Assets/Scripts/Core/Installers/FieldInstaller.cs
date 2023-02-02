using Core.Field;
using Core.MetaData;
using Core.Other;
using Core.Player.Controllers;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core.Installers
{
    public class FieldInstaller : BaseMonoInstaller
    {
        [SerializeField]
        private FieldCardsHolder _fieldCardsHolder;
        
        public override void InstallBindings()
        {
            BindObjectFromInstance(_fieldCardsHolder);
        }
    }
}