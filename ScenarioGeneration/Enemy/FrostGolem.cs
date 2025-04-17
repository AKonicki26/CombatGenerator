namespace ScenarioGeneration.Enemy;

using Weapon;

public class FrostGolem : Enemy
{
    public FrostGolem()
    {
        Weapons.Add(new GlacierSpear());
    }

    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Frost Golem launches an icy assault at {target.Name}!");
    }

    public override Element Element => Element.Ice;
}