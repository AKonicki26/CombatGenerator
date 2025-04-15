namespace ScenarioGeneration.Status;

public class PoisonEffect : StatusEffect
{
    private readonly byte _damagePerTurn;

    public PoisonEffect(int duration, byte damagePerTurn)
        : base("Poison", duration)
    {
        _damagePerTurn = damagePerTurn;
    }

    public override void ApplyEffect(Entity target)
    {
        target.TakeDamage(_damagePerTurn);
        Console.WriteLine($"{target.Name} is poisoned and takes {_damagePerTurn} damage.");
    }
}
