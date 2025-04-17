using ScenarioGeneration.Enemies;

namespace ScenarioGeneration;

public class ScenarioGeneration
{
    public static void Main(string[] args)
    {
        var generator = new CombatGenerator();
        generator.SetElement(Element.Fire);
        generator.SetLevel(4);
        generator.SetEnemyCount(6);

        List<Enemy> enemies = generator.GenerateEnemies();

        foreach (var enemy in enemies)
        {
            Console.WriteLine(
                $"{enemy.Name} | Level: {enemy.Level} | Health: {enemy.Health} | Weapons: {string.Join(", ", enemy.Weapons.Select(w => w.GetType().Name))}"
            );
        }
    }
}
