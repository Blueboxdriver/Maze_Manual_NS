namespace Maze_Manual_NS.models;
/// <summary>
///     Represents an abstract item that can be found in the maze that can be picked up by a player and applied for various
///     effects.
/// </summary>
public abstract class Item
{
    /// <summary>
    ///     A string containing the description of an item.
    /// </summary>
    public string ItemDesc { get; set; }

    /// <summary>
    ///     A string containing the message that should be displayed when picking up the item.
    /// </summary>
    public string ItemPickUp { get; set; }

    /// <summary>
    ///     An integer that sets the effect value of an item.
    /// </summary>
    public int ItemEffect { get; set; }
    
    
    /// <summary>
    ///     Creates an object of the <see cref="Item" /> class containing a description, pickup message and value for the
    ///     effect.
    /// </summary>
    /// <param name="itemDesc">The description of an item.</param>
    /// <param name="itemPickup">The pickup message of an item.</param>
    /// <param name="itemEffect">The effect value of an item.</param>
    protected Item(string itemDesc, string itemPickup, int itemEffect)
    {
        ItemDesc = itemDesc;
        ItemPickUp = itemPickup;
        ItemEffect = itemEffect;
    }

    /// <summary>
    ///     Selects a random item from <see cref="_items" />.
    ///     If the item selected is a weapon, it removes the item from <see cref="_items" /> to prevent duplicates.
    /// </summary>
    /// <returns>The randomly selected item.</returns>

    /// <summary>
    ///     Abstract method that applies an item's effect to a player.
    /// </summary>
    /// <param name="player">The player an item's effect is being applied to</param>
    public abstract void ApplyEffect(Player player);
}