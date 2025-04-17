using ScenarioGeneration.Status;

namespace ScenarioGeneration.Weapon;

public class GlacierSpear : Weapon
{
    private static int baseDamage = 7;

    public override Element Element => Element.Ice;
    public override float Damage => baseDamage;

    public override void Use(Entity target)
    {
        target.ApplyEffect(new FrozenEffect(duration: 1));
        target.TakeDamage(baseDamage);
        Console.WriteLine("Glacier Spear pierces with chilling force!");
    }
}