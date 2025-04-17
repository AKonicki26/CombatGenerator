namespace ScenarioGeneration.Weapons;

public abstract partial class Weapon
{
    private int _level;
    public int Level => _level;

    private string _name;
    public string Name => _name;

    private float _baseDamage;
    public abstract float Damage { get; }
    public abstract Element Element { get; }
    public abstract void Use(Entity target);
}

public static class ListExtensions
{
    /// <summary>
    /// Get a random value of type <see cref="T"/> from within the collection <see cref="list"/>
    /// </summary>
    /// <param name="list">List to get an item from </param>
    /// <typeparam name="T">Type of the collection</typeparam>
    /// <returns>An instance of T or null</returns>
    public static T? Random<T>(this List<T> list)
        where T : class => list.Count == 0 ? null : list[new Random().Next(0, list.Count)];
}
