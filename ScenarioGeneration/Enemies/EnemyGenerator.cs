namespace ScenarioGeneration.Enemies;

using Weapons;

public class EnemyGenerator(Enemies.Enemy enemy)
{
    public Enemies.Enemy Result => enemy;

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
