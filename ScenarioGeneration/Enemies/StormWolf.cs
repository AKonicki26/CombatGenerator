namespace ScenarioGeneration.Enemies;

using Weapons;

public class StormWolf : Enemies.Enemy
{
    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Storm Wolf strikes with a burst of lightning!");
    }

    public override Element Element => Element.Lightning;
}
