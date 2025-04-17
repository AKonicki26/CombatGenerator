namespace ScenarioGeneration.Status;

public class ParalyzedEffect : StatusEffect
{
    private readonly Random _rng = new();
    private readonly float _stunChance;

    public bool IsParalyzedThisTurn { get; private set; }

    public ParalyzedEffect(int duration, float stunChance = 0.5f)
        : base("Paralyzed", duration)
    {
        _stunChance = stunChance;
    }

    public override void ApplyEffect(Entity target)
    {
        IsParalyzedThisTurn = _rng.NextDouble() < _stunChance;
        if (IsParalyzedThisTurn)
        {
            Console.WriteLine($"{target.Name} is paralyzed and can't move!");
        }
        else
        {
            Console.WriteLine($"{target.Name} resists the paralysis!");
        }
    }

    public override void OnApply(Entity target)
    {
        Console.WriteLine($"{target.Name} is paralyzed!");
    }

    public override void OnExpire(Entity target)
    {
        Console.WriteLine($"{target.Name} is no longer paralyzed.");
    }
}
