using Maze_Manual_NS.models;
using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.Services;

public class CharacterService : ICharacterService
{
    public int CharacterId { get; set; }
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    
    public MarkupString Description { get; set; }
    public List<ICharacterService> Entities { get; set; }

    public CharacterService()
    {
        Entities = new List<ICharacterService>
        {
            new Monster(1001, "Peccatulum Irae", "https://limbuscompany.wiki.gg/images/8/87/Peccatulum_Irae_Idle_Sprite.png", 75, 10,
                "Entities that are similar to those inflicted by the Distortion, the Peccatulum are embodiments of a person's sins throughout their lives." +
                "What separates them from those inflicted by the Distortion phenomena is that these individuals lack the willpower to self reflect. <br /> <br /> " +
                "This Peccatulum in particular represents Wrath. It attacks by ramming its inflamed 'beak' into others, causing third degree burns in their victims." +
                " Other than this, it appears weak, held together by the fragile and stretched remains of whatever human was unfortunately enough to be subjected to the transformation."),
            
            new Monster(1002, "Peccatulum Morositatis", "https://limbuscompany.wiki.gg/images/2/28/Peccatulum_Morositatis_Idle_Sprite.png", 75, 10,
                "Entities that are similar to those inflicted by the Distortion, the Peccatulum are embodiments of a person's sins throughout their lives." +
                "What separates them from those inflicted by the Distortion phenomena is that these individuals lack the willpower to self reflect. <br /> <br /> " +
                "This Peccatulum in particular represents Gloom. It attacks by ejecting fluid at highly pressured levels. The fluid itself is of an unknown substance, " + 
                "However, it seems to have some form of psychological effect that greatly depresses the victim into a vulnerable state. " +
                "This vulnerable state allows the Peccatulum to puncture it with its highly pressurized attacks."),
            
            new Monster(1003, "Edgar House Butler", "https://limbuscompany.wiki.gg/images/5/59/Trained_Edgar_Family_Butler_Idle_Sprite.png", 100, 15,
                "test"),
            new Monster(1004, "Josephine of the Wild Hunt", "https://limbuscompany.wiki.gg/images/4/46/Josephine_StandingSprite.png", 125, 20,
                "test"),
            
            new Monster(1005, "Hindley of the Wild Hunt", "https://limbuscompany.wiki.gg/images/b/bc/Hindley_StandingSprite.png", 125, 20,
                "test"),
            
            new Monster(1006, "Linton of the Wild Hunt", "https://limbuscompany.wiki.gg/images/c/c4/Linton_StandingSprite.png", 125, 20,
                "test"),
            
            new Player(2001, "The Player", "https://static.wikia.nocookie.net/library-of-ruina/images/7/7e/LennyFullBody.png", 100, 10,
                "test")
        };
    }
}


