using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_DemoOO_RPG.Entities.Interfaces;
using TI_NET_2023_DemoOO_RPG.Utils;

namespace TI_NET_2023_DemoOO_RPG.Entities.Heroes
{
    public abstract class Hero : Entity, IGold, ILeather
    {
        public Hero()
        {
        }
        public string Name { get; set; }

        public int Gold { get; set; } 

        public int Leather {get; set; }

        public void Heal()
        {
            CurrentHp = Hp;
        }

        public void Loot(Entity e)
        {
            if(e is IGold g)
            {
                Console.WriteLine($"{this.Name} loot {g.GetType().Name} et obtient {g.Gold} Or");
                Gold += g.Gold;
            }
            if(e is ILeather l)
            {
                Console.WriteLine($"{this.Name} loot {l.GetType().Name} et obtient {l.Leather} Or");
                Leather += l.Leather;
            }
            Heal();
        }

        public override void GenerateStats()
        {
            Strength = Dice.Throws(DiceType.D10, 5, 3);
            Stamina = Dice.Throws(DiceType.D10, 5, 3);
        }
    }
}
