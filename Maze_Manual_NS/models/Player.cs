using Maze_Manual_NS.Services;
using Microsoft.AspNetCore.Components;

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
    public MarkupString Description { get; set; }
    public List<ICharacterService> Entities { get; set; }
    
    public Player(int characterId, string name, string imgUrl, int health, int damage, string description)
    {
        CharacterId = characterId;
        Health = health;
        Name = name;
        ImgUrl = imgUrl;
        Damage = damage;
        Description = new MarkupString(description);
    }
}