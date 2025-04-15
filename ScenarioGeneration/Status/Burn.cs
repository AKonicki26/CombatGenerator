namespace ScenarioGeneration.Status;

public class BurnEffect : StatusEffect
{
    private readonly byte _damagePerTurn;

    public BurnEffect(int duration, byte damagePerTurn)
        : base("Burn", duration)
    {
        _damagePerTurn = damagePerTurn;
    }

    public override void ApplyEffect(Entity target)
    {
        target.TakeDamage(_damagePerTurn);
        Console.WriteLine($"{target.Name} takes {_damagePerTurn} burn damage.");
    }
}
