using ScenarioGeneration.Status;

namespace ScenarioGeneration.Enemies;

using Weapons;

public class Dragon : Enemies.Enemy
{
    public Dragon()
    {
        // Dragon has innate access to firebreath
        Weapons.Add(new FireBreath());
    }

    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Level {Level} Dragon is attacking {target.Name}");
    }

    public override Element Element => Element.Fire;
}
