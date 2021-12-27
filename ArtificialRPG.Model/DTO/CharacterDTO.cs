using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialRPG.Model.DTO
{
    public class CharacterDTO
    {
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Damage { get; set; }
        public int AttackSpeed { get; set; }
        public int HpRegeneration { get; set; }
    }
}
