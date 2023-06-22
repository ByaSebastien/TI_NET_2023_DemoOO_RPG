
using TI_NET_2023_DemoOO_RPG.Entities.Heroes;
using TI_NET_2023_DemoOO_RPG.Entities.Monsters;

Human dante = new Human("Dante");
List<Monster> monsters = new List<Monster>();


for (int i = 0; i < 1000; i++)
{
    Random r = new Random();
    int rng = r.Next(6);

    switch (rng)
    {
        case 0:
        case 1:
        case 2:
            Wolf wolf = new Wolf();
            wolf.DieEvent += dante.Loot;
            monsters.Add(wolf);
            break;
        case 3:
        case 4:
            Troll troll = new Troll();
            troll.DieEvent += dante.Loot;
            monsters.Add(troll);
            break;
        case 5:
            Dragon dragon = new Dragon();
            dragon.DieEvent += dante.Loot;
            monsters.Add(dragon);
            break;
    }
}

while (dante.isAlive && monsters.Count > 1)
{
    for (int i = 0;i < monsters.Count && dante.isAlive; i++)
    {
        while(dante.isAlive && monsters[i].isAlive)
        {
            dante.Attack(monsters[i]);
            if (monsters[i].isAlive)
            {
                monsters[i].Attack(dante);
            }
        }
        if (!monsters[i].isAlive)
        {
            monsters.RemoveAt(i);
        }
    }
}

if (dante.isAlive)
{
    Console.WriteLine("You win");
}
else
{
    Console.WriteLine("You loose");
}
