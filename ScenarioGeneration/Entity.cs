using ScenarioGeneration.Status;
using ScenarioGeneration.Weapons;

namespace ScenarioGeneration;

public abstract class Entity
{
    public class DeathEventArgs : EventArgs { }

    protected int _health;

    public int Health
    {
        get => _health;
        set
        {
            if (value <= 0)
                Die(new DeathEventArgs());
            else
                _health = value;
        }
    }

    protected string _name;

    public string Name => _name;

    protected byte _level;
    public byte Level => _level;

    public delegate void DeathHandler(object sender, DeathEventArgs e);

    public event DeathHandler Death;

    public void Die(DeathEventArgs e)
    {
        _health = 0;
        Death?.Invoke(this, e);
    }

    public List<StatusEffect> ActiveEffects { get; } = new();

    public void ApplyEffect(StatusEffect effect)
    {
        ActiveEffects.Add(effect);
    }

    public void TakeDamage(int damage)
    {
        var actualDamage = Math.Max(0, damage - Defense);
        Health = Math.Max(0, Health - actualDamage);
    }

    public byte Defense { get; set; } = 0;

    public List<Weapons.Weapon> Weapons { get; } = new();
    public abstract void Attack(Entity target);

    public void TakeTurn()
    {
        for (int i = ActiveEffects.Count - 1; i >= 0; i--)
        {
            var effect = ActiveEffects[i];
            effect.Tick(this);
            if (effect.IsExpired)
                ActiveEffects.Remove(effect);
        }
    }
}
