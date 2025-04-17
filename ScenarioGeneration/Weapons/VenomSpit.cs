using ScenarioGeneration.Status;

namespace ScenarioGeneration.Weapons;

public class VenomSpit : Weapon
{
    private static int baseDamage = 5;

    public override Element Element => Element.Poison;
    public override float Damage => baseDamage;

    public override void Use(Entity target)
    {
        target.ApplyEffect(new PoisonEffect(duration: 4, damagePerTurn: 3));
        target.TakeDamage(baseDamage);
        Console.WriteLine("Venom Spit hits and poisons the target!");
    }
}
