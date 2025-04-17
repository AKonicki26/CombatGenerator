namespace ScenarioGeneration;
using ElementMap = Dictionary<Element, List<Element>>;
public enum Element
{
    Fire,
    Water,
    Ice,
    Poison,
    Lightning,
}

public static class ElementEffectiveness 
{

    public static ElementMap SuperEffective = new()
        {
            { Element.Water, new () { Element.Fire, Element.Poison }},
            { Element.Fire, new () { Element.Ice }},
            { Element.Ice, new() { Element.Water }}
        };

    public static ElementMap NotVeryEffective = new()
    {
        { Element.Fire , new() { Element.Water }},
        { Element.Water, new () { Element.Ice }}
    };

    public static ElementMap Useless = new()
    {
        { Element.Ice, new() { Element.Fire}}
    };
}


