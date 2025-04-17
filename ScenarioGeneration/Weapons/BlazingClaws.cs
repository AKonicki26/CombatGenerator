using ScenarioGeneration.Status;

namespace ScenarioGeneration.Weapons;

public class BlazingClaws : Weapon
{
    private static int baseDamage = 8;

    public override Element Element => Element.Fire;
    public override float Damage => baseDamage;

    public override void Use(Entity target)
    {
        target.TakeDamage(baseDamage);
        target.ApplyEffect(new BurnEffect(duration: 2, damagePerTurn: 4));
        Console.WriteLine("Blazing Claws slash through the target, igniting them!");
    }
}
