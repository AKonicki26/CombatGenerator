namespace ScenarioGeneration.Enemy;

using Weapon;

public class WaterSprite : Enemy
{
    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Water Sprite splashes {target.Name} with a wave of water!");
    }

    public override Element Element => Element.Water;
}