using ScenarioGeneration.Status;

namespace ScenarioGeneration.Weapons;

public class FireBreath : Weapon
{
    private static int baseDamage = 10;

    public override float Damage => baseDamage;
    public override Element Element => Element.Fire;

    public override void Use(Entity target)
    {
        target.ApplyEffect(new BurnEffect(duration: 3, damagePerTurn: 5));
        target.TakeDamage(baseDamage);
        Console.WriteLine("Fire Breath!! Target is burning!");
    }
}