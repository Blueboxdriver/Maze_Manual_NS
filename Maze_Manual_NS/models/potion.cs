namespace Maze_Manual_NS.models;

/// <summary>
///     Represents a potion object that can be found by the Player. Inherits from the <see cref="Item" /> class
/// </summary>
public class Potion : Item
{
    public Potion(string name, string potionUrl, int potionEffect, int itemId, string potionDescription) : base(name, potionUrl, potionEffect, itemId, potionDescription) {}
}