namespace ScenarioGeneration.Enemy;

using Weapon;

public class EnemyGenerator(Enemy enemy)
{
    public Enemy Result => enemy;

    public void GiveWeapon(Weapon w)
    {
        enemy.Weapons.Add(w);
    }

    public void SetLevel(byte level)
    {
        enemy.SetLevel(level);
    }

    public void SetName(string name)
    {
        enemy.SetName(name);
    }
}

partial class Enemy
{
    internal void SetLevel(byte level)
    {
        _level = level;
    }

    internal void SetName(string name)
    {
        _name = name;
    }
}
