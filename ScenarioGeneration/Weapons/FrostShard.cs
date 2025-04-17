using ScenarioGeneration.Status;

namespace ScenarioGeneration.Weapons;

public class FrostShard : Weapon
{
    private static int baseDamage = 6;

    public override Element Element => Element.Ice;

    public override float Damage => baseDamage;

    public override void Use(Entity target)
    {
        target.ApplyEffect(new FrozenEffect(duration: 2));
        target.TakeDamage(baseDamage);
        Console.WriteLine("Frost Shard pierces the air! The target is freezing.");
    }
}
