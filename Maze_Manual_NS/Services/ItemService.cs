using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

public class ItemService : IItemService
{
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public int ItemEffect { get; set; }
    public string ItemDescription { get; set; }
    public string ItemUrl { get; set; }
    public List<Item> Items { get; set; }


    public ItemService()
    {
        Items = new List<Item>
        {
            new Potion("Bandage", "https://static.wikia.nocookie.net/limbuscompany/images/b/b9/Compression_Bandage_Gift.png", 25, 3001, ""),
            new Potion("Half empty K-Corp Ampule", "../images/ampule(1).png", 50, 3002, ""),
            new Potion("Full K-Corp Ampule", "https://static.wikia.nocookie.net/limbuscompany/images/6/64/Decay_Ampule.png", 100, 3003, ""),
            new Weapon("Zelkova workshop Mace", "../images/Zelkova.png", 12, 4001, ""),
            new Weapon("Stigma Workshop Longsword", "../images/Stigma_Workshop.png", 15, 4002, ""),
            new Weapon("Atelier Logic Handgun", "../images/Atelier.png", 20, 4003, ""),
            new Weapon("Rosespanner Workshop Spear", "../images/Rosespanner_Spear.png", 25, 4004, "")
        };
    }
}