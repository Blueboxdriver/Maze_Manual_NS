using Maze_Manual_NS.Services;
using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.models;

/// <summary>
///     Represents a player in the maze. Implements <see cref="ICharacterService"/>
/// </summary>
public class Player : ICharacterService
{
    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public int Health { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public int Damage { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public int CharacterId { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public string ImgUrl { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public MarkupString Description { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public List<ICharacterService> Entities { get; set; }

    /// <summary>
    ///     A constructor that builds a player object
    /// </summary>
    /// <param name="characterId">A unique four digit ID assigned to a character</param>
    /// <param name="name">The name a character has</param>
    /// <param name="imgUrl">The URL or path to an image that represents the character</param>
    /// <param name="health">An integer representing the max health a character has</param>
    /// <param name="damage">An integer representing the damage value a character has.</param>
    /// <param name="description">The description of a character</param>
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