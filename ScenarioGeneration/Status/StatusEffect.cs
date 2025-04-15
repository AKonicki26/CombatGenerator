namespace ScenarioGeneration.Status;

public abstract class StatusEffect
{
    public string Name { get; protected set; }
    public int Duration { get; protected set; }

    protected StatusEffect(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public abstract void ApplyEffect(Entity target);

    public virtual void OnApply(Entity target) { }

    public virtual void OnExpire(Entity target) { }

    public bool IsExpired => Duration <= 0;

    public void Tick(Entity target)
    {
        if (IsExpired)
            return;

        ApplyEffect(target);
        Duration--;

        if (IsExpired)
            OnExpire(target);
    }
}
