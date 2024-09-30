namespace Maze_Manual_NS.Services;
using models;
public interface ICharacterService
{
    List<ICharacterService> Entities { get; set; }
    public int CharacterId { get; set; }
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
}