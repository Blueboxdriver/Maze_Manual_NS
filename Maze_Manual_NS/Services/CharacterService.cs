using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

public class CharacterService : ICharacterService
{
    public List<Monster> Monsters { get; set; }
    public List<Player> Players { get; set; }

    public CharacterService()
    {
        Monsters = new List<Monster>()
        {
            new(1001,"Peccatulum Irae","https://limbuscompany.wiki.gg/images/8/87/Peccatulum_Irae_Idle_Sprite.png", 75, 10),
            new(1002,"Peccatulum Morositatis","https://limbuscompany.wiki.gg/images/2/28/Peccatulum_Morositatis_Idle_Sprite.png", 75, 10),
            new(1003,"Edgar House Butler","https://limbuscompany.wiki.gg/images/5/59/Trained_Edgar_Family_Butler_Idle_Sprite.png", 100, 15),
            new(1004,"Josephine of the Wild Hunt","https://limbuscompany.wiki.gg/images/4/46/Josephine_StandingSprite.png", 125, 20),
            new(1005,"Hindley of the Wild Hunt","https://limbuscompany.wiki.gg/images/b/bc/Hindley_StandingSprite.png", 125, 20),
            new(1006,"Linton of the Wild Hunt", "https://limbuscompany.wiki.gg/images/c/c4/Linton_StandingSprite.png",125, 20)
        };
    }

    public Monster ReturnMonster(int index)
    {
        return Monsters[index];
    }

    public Player ReturnPlayer(int index)
    {
        return Players[index];
    }
}