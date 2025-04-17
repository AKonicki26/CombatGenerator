using System.Linq;
using ScenarioGeneration.Enemies;
using ScenarioGeneration.Weapons;

namespace ScenarioGeneration;

public class CombatGenerator
{
    private byte _encounterLevel;
    private Element _encounterElement;
    private int _enemyCount;

    private static readonly Dictionary<Element, Func<Enemy>> EnemyFactories = new()
    {
        { Element.Fire, () => new List<Enemy>() { new FireImp(), new Dragon() }.Random()! },
        { Element.Water, () => new WaterSprite() },
        { Element.Ice, () => new FrostGolem() },
        { Element.Poison, () => new ToxicCrawler() },
        { Element.Lightning, () => new StormWolf() },
    };

    private static readonly List<Weapons.Weapon> AllWeapons = new()
    {
        new BlazingClaws(),
        new FireBreath(),
        new AquaJet(),
        new GlacierSpear(),
        new FrostShard(),
        new LightningStrike(),
        new VenomSpit(),
    };

    public void SetLevel(byte level) => _encounterLevel = level;

    public void SetElement(Element element) => _encounterElement = element;

    public void SetEnemyCount(int count) => _enemyCount = count;

    public List<Enemy> GenerateEnemies()
    {
        var enemies = new List<Enemy>();
        var disallowedElements = ElementEffectiveness
            .SuperEffective[_encounterElement]
            .Concat(ElementEffectiveness.NotVeryEffective[_encounterElement])
            .Concat(ElementEffectiveness.Useless[_encounterElement])
            .ToHashSet();

        var eligibleEnemies = EnemyFactories
            .Where(pair => !disallowedElements.Contains(pair.Key))
            .ToList();

        var rnd = new Random();

        for (int i = 0; i < _enemyCount; i++)
        {
            var factoryPair = eligibleEnemies[rnd.Next(eligibleEnemies.Count)];
            var enemy = factoryPair.Value.Invoke();
    
            var generator = new EnemyGenerator(enemy);
            generator.SetLevel((byte)rnd.Next(1, _encounterLevel + 1));
            generator.SetName($"{enemy.GetType().Name}_{i}");

            // Health scaling: base 20 + 10 per level
            enemy.Health = 20 + 10 * enemy.Level;

            // Add weapons based on level
            var weaponCount = Math.Clamp(enemy.Level / 2 + 1, 1, 3);
            var weaponOptions = AllWeapons.Where(w => !disallowedElements.Contains(w.Element)).ToList();

            for (int w = 0; w < weaponCount && weaponOptions.Count > 0; w++)
            {
                var weapon = weaponOptions[rnd.Next(weaponOptions.Count)];
                generator.GiveWeapon(weapon);
            }

            enemies.Add(enemy);
        }

        return enemies;
    }
}
