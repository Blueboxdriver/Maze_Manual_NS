namespace Maze_Manual_NS.models;

/// <summary>
///     Represents a potion object that can be found by the Player. Inherits from <see cref="Item"/>
/// </summary>
public class Potion : Item
{
    /// <summary>
    ///     A constructor that makes a potion object
    /// </summary>
    /// <param name="name">The name of the potion</param>
    /// <param name="potionUrl">The URL or path to an image that represents the potion</param>
    /// <param name="potionEffect">The integer representing the effect value of a potion</param>
    /// <param name="itemId">An integer representing the unique four digit ID a potion has</param>
    /// <param name="potionDescription">The description of the potion</param>
    public Potion(string name, string potionUrl, int potionEffect, int itemId, string potionDescription) : base(name,
        potionUrl,
        potionEffect,
        itemId,
        potionDescription)
    {
    }
}