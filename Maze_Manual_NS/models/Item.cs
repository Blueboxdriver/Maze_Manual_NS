using Maze_Manual_NS.Services;
using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.models;

/// <summary>
///     Represents an abstract item that can be found in the maze that can be picked up by a player and applied for various
///     effects. Implements <see cref="IItemService"/>
/// </summary>
public abstract class Item : IItemService
{
    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public string ItemName { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public int ItemId { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public int ItemEffect { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public MarkupString ItemDescription { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public string ItemUrl { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public List<Item> Items { get; set; }

    /// <summary>
    ///     A constructor that builds an item object.
    /// </summary>
    /// <param name="itemName">The name of an item</param>
    /// <param name="itemUrl">The URL or path leading to an image representing an item</param>
    /// <param name="itemEffect">The integer value an effect has</param>
    /// <param name="itemId">The unique four digit ID an item has</param>
    /// <param name="itemDescription">The description of an item</param>
    protected Item(string itemName, string itemUrl, int itemEffect, int itemId, string itemDescription)
    {
        ItemName = itemName;
        ItemId = itemId;
        ItemEffect = itemEffect;
        ItemUrl = itemUrl;
        ItemDescription = new MarkupString(itemDescription);
    }
}