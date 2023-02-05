using System.Collections.Generic;
using Core.Card.Config;
using UnityEngine;

namespace Core.SO
{
    public class CardScriptableObject : ScriptableObject
    {
        [SerializeField]
        private List<CardConfig> _cardConfigs;

        public List<CardConfig> GetConfigs()
        {
            return _cardConfigs;
        }
    }
}