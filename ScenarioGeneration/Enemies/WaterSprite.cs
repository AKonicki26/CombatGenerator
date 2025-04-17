namespace ScenarioGeneration.Enemies;

using Weapons;

public class WaterSprite : Enemies.Enemy
{
    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Water Sprite splashes {target.Name} with a wave of water!");
    }

    public override Element Element => Element.Water;
}
