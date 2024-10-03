namespace Maze_Manual_NS.models;

/// <summary>
///     Represents a weapon object that can be found by the Player. Inherits from <see cref="Item"/>
/// </summary>
public class Weapon : Item
{
    /// <summary>
    ///     A constructor that creates a Weapon object
    /// </summary>
    /// <param name="name">The name of a weapon</param>
    /// <param name="weaponUrl">The URL or path to an image that represents the weapon</param>
    /// <param name="weaponEffect">The Integer representing the damage value of a weapon</param>
    /// <param name="itemId">The integer representing the unique four digit ID a weapon has</param>
    /// <param name="weaponDescription">The description of a weapon</param>
    public Weapon(string name, string weaponUrl, int weaponEffect, int itemId, string weaponDescription) : base(name,
        weaponUrl,
        weaponEffect,
        itemId,
        weaponDescription)
    {
    }
}