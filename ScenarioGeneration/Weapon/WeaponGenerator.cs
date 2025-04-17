namespace ScenarioGeneration.Weapon;

public class WeaponGenerator(Weapon weapon)
{
    private Weapon _weapon = weapon;

    public Weapon Result => _weapon;

    public void SetName(string name)
    {
        _weapon.SetName(name);
    }

    public void SetLevel(int level)
    {
        _weapon.SetLevel(level);
    }

    public void SetBaseDamage(float baseDamage)
    {
        _weapon.SetBaseDamage(baseDamage);
    }
}

// Extending Weapon with internal setters using partial
public abstract partial class Weapon
{
    internal void SetName(string name)
    {
        _name = name;
    }

    internal void SetLevel(int level)
    {
        _level = level;
    }

    internal void SetBaseDamage(float baseDamage)
    {
        // You might need to make _baseDamage non-readonly to allow this
        typeof(Weapon)
            .GetField("_baseDamage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
            .SetValue(this, baseDamage);
    }
}