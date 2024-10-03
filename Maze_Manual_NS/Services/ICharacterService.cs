using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.Services;

/// <summary>
///     An inteferace that dictates what a character consists of
/// </summary>
public interface ICharacterService
{
    /// <summary>
    ///     A list of entities that can be found in the maze. Essentially a combination of Player and Monsters
    /// </summary>
    List<ICharacterService> Entities { get; set; }

    /// <summary>
    ///     A unique four-digit ID given to every character.
    /// </summary>
    public int CharacterId { get; set; }

    /// <summary>
    ///     A string representing the name of a character
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     A string containing the URL or path to a image used to visually represent a character
    /// </summary>
    public string ImgUrl { get; set; }

    /// <summary>
    ///     An integer representing the max health a character has
    /// </summary>
    public int Health { get; set; }

    /// <summary>
    ///     A integer representing the max damage a character can output
    /// </summary>
    public int Damage { get; set; }

    /// <summary>
    ///     A String that is compatible with HTML tags that represents the description for a character
    /// </summary>
    public MarkupString Description { get; set; }
}