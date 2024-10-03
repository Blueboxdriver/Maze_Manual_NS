using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.models;

/// <summary>
///     Represents a weapon object that can be found by the Player. Inherits from the <see cref="Item" /> class
/// </summary>
public class Weapon : Item
{
    public Weapon(string name, string weaponUrl, int weaponEffect, int itemId, string weaponDescription) : base (name, weaponUrl, weaponEffect, itemId, weaponDescription) {}
}