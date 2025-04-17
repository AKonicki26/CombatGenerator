using ScenarioGeneration.Status;

namespace ScenarioGeneration.Weapon;

public class LightningStrike : Weapon
{
    private static int baseDamage = 12;

    public override Element Element => Element.Lightning;

    public override float Damage => baseDamage;

    public override void Use(Entity target)
    {
        target.TakeDamage(baseDamage);
        Console.WriteLine("A bolt of lightning crashes down!");
        target.ApplyEffect(new ParalyzedEffect(2, 0.35f));
    }
}
