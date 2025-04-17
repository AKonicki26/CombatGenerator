using ScenarioGeneration.Status;
using ScenarioGeneration.Weapons;

namespace ScenarioGeneration.Enemies;

public class FireImp : Enemies.Enemy
{
    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Fire Imp scorches {target.Name}!");
    }

    public override Element Element => Element.Fire;
}
