namespace ScenarioGeneration.Status;

public class FrozenEffect : StatusEffect
{
    public FrozenEffect(int duration)
        : base("Frozen", duration) { }

    public override void ApplyEffect(Entity target)
    {
        // You can check this in the Enemy's Attack() logic
        Console.WriteLine($"{target.Name} is frozen and cannot move!");
    }

    public override void OnApply(Entity target)
    {
        Console.WriteLine($"{target.Name} is frozen solid!");
    }

    public override void OnExpire(Entity target)
    {
        Console.WriteLine($"{target.Name} thaws out.");
    }
}
