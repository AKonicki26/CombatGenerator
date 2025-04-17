using ScenarioGeneration.Status;

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
        Console.WriteLine($"Level {Level} Dragon is attacking {target.Name}");
    }

    protected class FireBreath : Weapon
    {
        private static int baseDamage = 10;

        public override float Damage => baseDamage;
        public override Element Element => Element.Fire;

        public override void Use(Entity target)
        {
            target.ApplyEffect(new BurnEffect(duration: 3, damagePerTurn: 5));
            target.TakeDamage(baseDamage);
            Console.WriteLine("Fire Breath!! Target is burning!");
        }
    }

    public override Element Element => Element.Fire;
}
