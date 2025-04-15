namespace ScenarioGeneration.Enemy;

using Weapon;

public class Dragon : Enemy
{
    public Dragon()
    {
        // Dragon has innate access to firebreath
        Weapons.Add(new FireBreath());
    }

    public override void Attack(Entity target)
    {
        Weapons.Random()?.Use(target);
        Console.WriteLine($"Dragon is attacking {target.Name}");
    }

    protected class FireBreath : Weapon
    {
        private static int baseDamage = 10;

        public override void Use(Entity target)
        {
            target.TakeDamage(baseDamage);
            Console.WriteLine("Fire Breath!!");
        }
    }
}
