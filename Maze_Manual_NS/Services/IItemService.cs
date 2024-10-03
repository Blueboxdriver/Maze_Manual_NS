using Maze_Manual_NS.models;
using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.Services;

/// <summary>
///     An interface that dictates what a Item consists of.
/// </summary>
public interface IItemService
{
    /// <summary>
    ///     A string representing the name a item has
    /// </summary>
    public string ItemName { get; set; }

    /// <summary>
    ///     An integer representing the unique four-digit ID a item is assigned
    /// </summary>
    public int ItemId { get; set; }

    /// <summary>
    ///     An integer containing the value for an item's effect
    /// </summary>
    public int ItemEffect { get; set; }

    /// <summary>
    ///     A markup string that is able to implement HTML tags detailing the description of an item.
    /// </summary>
    public MarkupString ItemDescription { get; set; }

    /// <summary>
    ///     A string representing the URL or path to an image that visually represents an item.
    /// </summary>
    public string ItemUrl { get; set; }

    /// <summary>
    ///     A list of items that can be found in the maze. Essentially combines Potion and Weapons.
    /// </summary>
    List<Item> Items { get; set; }
}