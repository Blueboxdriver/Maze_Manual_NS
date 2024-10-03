using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.Services;
using models;
public interface IItemService
{
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public int ItemEffect { get; set; }
    public MarkupString ItemDescription { get; set; }
    public string ItemUrl { get; set; } 
    List<Item> Items { get; set; }
}