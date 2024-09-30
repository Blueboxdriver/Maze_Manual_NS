using Maze_Manual_NS.Services;

namespace Maze_Manual_NS.models;

/// <summary>
///     Represents a player in the maze and implements the <see cref="ICharacter" /> interface.
/// </summary>
public class Player : ICharacterService
{
    public int Health { get; set; }
    public int Damage { get; set; }
    public Weapon CurrentWeapon;
    public int CharacterId { get; set; }
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public List<ICharacterService> Entities { get; set; }
    
    public Player(int characterId, string name, string imgUrl, int health, int damage)
    {
        CharacterId = characterId;
        Health = health;
        Name = name;
        ImgUrl = imgUrl;
        Damage = damage;
        Weapon defaultWeapon = new("Basic Baton", "A baton you found when you woke up.", 10);
    }
}