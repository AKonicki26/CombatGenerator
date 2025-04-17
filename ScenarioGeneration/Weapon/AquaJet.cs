namespace ScenarioGeneration.Weapon;

public class AquaJet : Weapon
{
    private static int baseDamage = 10;

    public override Element Element => Element.Water;
    public override float Damage => baseDamage;

    public override void Use(Entity target)
    {
        target.TakeDamage(baseDamage);
        Console.WriteLine("A high-pressure stream of water hits the target!");
    }
}