using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_DemoOO_RPG.Entities.Interfaces;
using TI_NET_2023_DemoOO_RPG.Utils;

namespace TI_NET_2023_DemoOO_RPG.Entities.Monsters
{
    public class Dragon : Monster, IGold, ILeather
    {
        public int Gold { get; } = Dice.Throws(DiceType.D6);
        public int Leather { get; } = Dice.Throws(DiceType.D6);

        public override void Attack(Entity e)
        {
            Console.WriteLine("RRRRrrrrrrrrrrrrrrr");
            e.TakeDamage(Dice.Throws(DiceType.D20));
        }
    }
}
