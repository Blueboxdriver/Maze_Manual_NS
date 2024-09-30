using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

public class CharacterService : ICharacterService
{
    public int CharacterId { get; set; }
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public List<ICharacterService> Entities { get; set; }

    public CharacterService()
    {
        Entities = new List<ICharacterService>
        {
            new Monster(1001, "Peccatulum Irae", "https://limbuscompany.wiki.gg/images/8/87/Peccatulum_Irae_Idle_Sprite.png", 75, 10),
            new Monster(1002, "Peccatulum Morositatis", "https://limbuscompany.wiki.gg/images/2/28/Peccatulum_Morositatis_Idle_Sprite.png", 75, 10),
            new Monster(1003, "Edgar House Butler", "https://limbuscompany.wiki.gg/images/5/59/Trained_Edgar_Family_Butler_Idle_Sprite.png", 100, 15),
            new Monster(1004, "Josephine of the Wild Hunt", "https://limbuscompany.wiki.gg/images/4/46/Josephine_StandingSprite.png", 125, 20),
            new Monster(1005, "Hindley of the Wild Hunt", "https://limbuscompany.wiki.gg/images/b/bc/Hindley_StandingSprite.png", 125, 20),
            new Monster(1006, "Linton of the Wild Hunt", "https://limbuscompany.wiki.gg/images/c/c4/Linton_StandingSprite.png", 125, 20),
            new Player(2001, "The Player", "https://static.wikia.nocookie.net/library-of-ruina/images/7/7e/LennyFullBody.png", 100, 10)
        };
    }
}


