using Maze_Manual_NS.models;
using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.Services;

/// <summary>
///     A service used to contain every character that exists in the Maze. Implements <see cref="ICharacterService" />
/// </summary>
public class CharacterService : ICharacterService
{
    /// <inheritdoc />
    public int CharacterId { get; set; }

    /// <inheritdoc />
    public string Name { get; set; }

    /// <inheritdoc />
    public string ImgUrl { get; set; }

    /// <inheritdoc />
    public int Health { get; set; }

    /// <inheritdoc />
    public int Damage { get; set; }

    /// <inheritdoc />
    public MarkupString Description { get; set; }

    /// <inheritdoc />
    public List<ICharacterService> Entities { get; set; }

    /// <summary>
    ///     Creates a new instance of <see cref="CharacterService"/> that fills the <see cref="Entities" /> list with characters/monsters that can be found in the maze.
    /// </summary>
    public CharacterService()
    {
        Entities = new List<ICharacterService>
        {
            new Monster(1001,
                "Peccatulum Irae",
                "https://limbuscompany.wiki.gg/images/8/87/Peccatulum_Irae_Idle_Sprite.png",
                75,
                10,
                "Entities that are similar to those inflicted by the Distortion, the Peccatulum are embodiments of a person's sins throughout their lives." +
                "What separates them from those inflicted by the Distortion phenomena is that these individuals lack the willpower to self reflect. <br /> <br /> " +
                "This Peccatulum in particular represents Wrath. It attacks by ramming its inflamed 'beak' into others, causing third degree burns in their victims." +
                " Other than this, it appears weak, held together by the fragile and stretched remains of whatever human was unfortunately enough to be subjected to the transformation."),

            new Monster(1002,
                "Peccatulum Morositatis",
                "https://limbuscompany.wiki.gg/images/2/28/Peccatulum_Morositatis_Idle_Sprite.png",
                75,
                10,
                "Entities that are similar to those inflicted by the Distortion, the Peccatulum are embodiments of a person's sins throughout their lives." +
                "What separates them from those inflicted by the Distortion phenomena is that these individuals lack the willpower to self reflect. <br /> <br /> " +
                "This Peccatulum in particular represents Gloom. It attacks by ejecting fluid at highly pressured levels. The fluid itself is of an unknown substance, " +
                "However, it seems to have some form of psychological effect that greatly depresses the victim into a vulnerable state. " +
                "This vulnerable state allows the Peccatulum to puncture it with its highly pressurized attacks."),

            new Monster(1003,
                "Edgar House Butler",
                "https://limbuscompany.wiki.gg/images/5/59/Trained_Edgar_Family_Butler_Idle_Sprite.png",
                100,
                15,
                "One of the many contracted butlers for the Edgar Family. Butlers in general are a staple in T Corp's Nest, essentially they're fixers who take " +
                "contracts with a family for a period of time. This prevents them from doing fixer work, but also grants them the resources from the family hiring them. <br /> <br /> " +
                "It seems like many of the butlers in the manor were also trapped in the basement. They're armed to the teeth with general cutlery and other cleaning supplies turned into weapons."),

            new Monster(1004,
                "Josephine of the Wild Hunt",
                "https://limbuscompany.wiki.gg/images/4/46/Josephine_StandingSprite.png",
                125,
                20,
                "Chief Butler of Wulthering Heights. Despite the prestige of her title, her age is showing and has been known to go into mad fits randomly. " +
                "Despite this, she shouldn't be underestimated. Years of experience and augmentation funded by her master have made her a formidable opponent. <br /> <br />" +
                "Unlike the other butlers in the manor, she mainly uses augmented melee attacks. Despite the simple nature of her attacks, they are incredibly potent. " +
                "The effects of the Wild Hunt make her even more formidable."),

            new Monster(1005,
                "Hindley of the Wild Hunt",
                "https://limbuscompany.wiki.gg/images/b/bc/Hindley_StandingSprite.png",
                125,
                20,
                "The only son of the Earnshaw family and the former master of Wulthering Heights. Hindley has returned to Wulthering Heights in hopes of reclaiming what he lost. " +
                "Unfortunately, he's been trapped in the basement as well. He reeks of alcohol and he appears almost penniless and on the brink of mentally collapsing. " +
                "Despite this, he's still a formidable opponent purely due to his augmentation despite his lack of fighting experience. <br /> <br />" +
                "As mentioned, Hindley's attacks are powerful purely because he is augmented. They lack any form of technique, which makes it easy for people to underestimate him. " +
                "Furthermore, he seems a bit more empowered by the effects of the Wild hunt. "),

            new Monster(1006,
                "Linton of the Wild Hunt",
                "https://limbuscompany.wiki.gg/images/c/c4/Linton_StandingSprite.png",
                125,
                20,
                "A member of the Edgar family, his presence at Wulthering heights is unknown to you. Regardless, he looks sickly in nature moving " +
                "only because of the Wild hunt fueling him. Compared to Hindley and Josephine, it's hard to tell if he has any augmentation, especially with his sickly nature. " +
                "That said, Linton is most formidable when he's using his cane sword, something tells you he's paid serious money to be trained with it. <br /> <br />" +
                "Linton himself is dangerous with his sword and his sword alone. You can tell between every move he makes that he's barely holding himself together. " +
                "If anything, you suspect the Wild hunt is the only thing that's allowing him to walk."),

            new Player(2001,
                "The Player",
                "https://static.wikia.nocookie.net/library-of-ruina/images/7/7e/LennyFullBody.png",
                100,
                10,
                "It's you. <br /> <br />" +
                "At least, you think it's you. It's hard to tell. All you remember is waking up from some pod and watching a chaotic scene unfold. " +
                "Whether you're a rat from the backstreets, some nest employee or a member of a syndicate doesn't matter. You're trapped and you need to escape. " +
                "At the very least, you are familiar with weaponry and the basics of combat, so you should be able to fight your way out. Overall, you're just very plain compared to the others in the basement.")
        };
    }
}