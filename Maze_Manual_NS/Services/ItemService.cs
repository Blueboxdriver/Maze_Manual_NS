using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

public class ItemService : IItemService
{
    public string ItemName { get; set; }
    public int ItemDamage { get; set; }
    public string ItemDescription { get; set; }
    public List<Weapon> Weapons { get; set; }
    public List<Potion> Potions { get; set; }


    public ItemService()
    {
        Weapons = new List<Weapon>()
        {
            new Weapon("test", "test", 10)
        };
        Potions = new List<Potion>()
        {
            new Potion("test", "test", 20)
        };
    }
}