namespace Maze_Manual_NS.Services;
using models;
public interface ICharacterService
{
    public List<Monster> Monsters { get; set; }
    
    public List<Player> Players { get; set; }
    
    Player ReturnPlayer(int index);
    Monster ReturnMonster(int index);


}