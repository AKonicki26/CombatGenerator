namespace ScenarioGeneration.Enemies;

using Weapons;

public class ToxicCrawler : Enemies.Enemy
{
    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Toxic Crawler lobs venom at {target.Name}!");
    }

    public override Element Element => Element.Poison;
}
