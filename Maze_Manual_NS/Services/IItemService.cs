namespace Maze_Manual_NS.Services;
using models;
public interface IItemService
{
    public string ItemName { get; set; }
    
    public int ItemDamage { get; set; }
    
    public string ItemDescription { get; set; }
    
    public List<Weapon> Weapons { get; set; }
    public List<Potion> Potions { get; set; }
}