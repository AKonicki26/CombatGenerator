using ScenarioGeneration.Status;
using ScenarioGeneration.Weapon;


namespace ScenarioGeneration.Enemy;


public class FireImp : Enemy
{
    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Fire Imp scorches {target.Name}!");
    }

    public override Element Element => Element.Fire;
}