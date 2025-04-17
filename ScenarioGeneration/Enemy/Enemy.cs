namespace ScenarioGeneration.Enemy;

using Weapon;

public abstract partial class Enemy : Entity
{
    public abstract Element Element { get; }
}
