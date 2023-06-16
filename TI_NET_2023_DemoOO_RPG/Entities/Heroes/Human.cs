using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_DemoOO_RPG.Utils;

namespace TI_NET_2023_DemoOO_RPG.Entities.Heroes
{
    public class Human : Hero
    {

        public Human(string name)
        {
            Name = name;
            if(name == "Dante")
            {
                Strength *= 100;
                Stamina *= 100;
                Hp *= 1000;
                CurrentHp = Hp;
            }
        }

        public override void Attack(Entity e)
        {
            Console.WriteLine("Jackpot!");
            e.TakeDamage(Dice.Throws(DiceType.D10,5));
        }
    }
}
