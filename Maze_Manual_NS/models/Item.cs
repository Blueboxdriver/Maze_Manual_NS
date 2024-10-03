using Maze_Manual_NS.Services;
using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.models;
/// <summary>
///     Represents an abstract item that can be found in the maze that can be picked up by a player and applied for various
///     effects.
/// </summary>
public abstract class Item : IItemService
{

    public string ItemName { get; set; }
    public int ItemId { get; set; }
    
    public int ItemEffect { get; set; }
    public MarkupString ItemDescription { get; set; }
    public string ItemUrl { get; set; }
    public List<Item> Items { get; set; }


    protected Item(string itemName, string itemUrl, int itemEffect, int itemId, string itemDescription)
    {
        ItemName = itemName;
        ItemId = itemId;
        ItemEffect = itemEffect;
        ItemUrl = itemUrl;
        ItemDescription = new MarkupString(itemDescription);
    }


}