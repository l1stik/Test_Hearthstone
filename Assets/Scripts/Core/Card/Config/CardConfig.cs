using UnityEngine;

namespace Core.Card.Config
{
    public struct CardConfig
    {
        public Sprite ImageBack { get; set; }
        public Sprite ImagePicture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
    }
}