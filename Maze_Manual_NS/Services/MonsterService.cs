using Maze_Manual_NS.models;
namespace Maze_Manual_NS.Services;

public class MonsterService : IMonsterService
{
    public List<Monster> Monsters { get; set; }
    
    public MonsterService()
    {
        Monsters = new List<Monster>();
        
        for (int i = 0; i < 6; i++) // Add 6 monsters for example
        {
            Monsters.Add(Monster.GenerateMonster(i));
        }
    }

    public Monster ReturnMonster(int index)
    {
        return Monsters[index];
    }
}