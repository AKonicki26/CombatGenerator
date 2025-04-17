namespace ScenarioGeneration.Enemy;

using Weapon;

public class StormWolf : Enemy
{
    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Storm Wolf strikes with a burst of lightning!");
    }

    public override Element Element => Element.Lightning;
}