using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_DemoOO_RPG.Utils;

namespace TI_NET_2023_DemoOO_RPG.Entities.Monsters
{
    public abstract class Monster : Entity
    {
        public override void GenerateStats()
        {
            Strength = Dice.Throws(DiceType.D6, 3, 3);
            Stamina = Dice.Throws(DiceType.D6, 3, 3);
        }
    }
}
