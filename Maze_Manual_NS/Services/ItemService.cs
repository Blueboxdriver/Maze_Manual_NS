using Maze_Manual_NS.models;
using Microsoft.AspNetCore.Components;

namespace Maze_Manual_NS.Services;

public class ItemService : IItemService
{
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public int ItemEffect { get; set; }
    public MarkupString ItemDescription { get; set; }
    public string ItemUrl { get; set; }
    public List<Item> Items { get; set; }


    public ItemService()
    {
        Items = new List<Item>
        {
            new Potion("Bandage", "https://static.wikia.nocookie.net/limbuscompany/images/b/b9/Compression_Bandage_Gift.png", 25, 3001,
                 "It's a bandage. More specifically, it's a piece of cloth manufactured or otherwise improvised for the sole purpose of conceal " +
                 "wounds. They've existed for a really long time, and for good reason. Typically speaking, it's a good idea to cover up anything that causes " +
                 "the red life juice to leak out of you. <br /> <br /> This bandage is used though. Not that you have any right to complain."),
            new Potion("Half empty K-Corp Ampule", "../images/ampule(1).png", 50, 3002,
                "This is a half empty ampule containing K-Corp's revolutionary singularity that can heal any wound. " +
                "Vials like this are usually sold to Fixer offices or associations and seldom sold to any solo-offices. " +
                "it works supposedly off nano-tech technology that can rapidly regenerate broken tissue. Though for some reason, it doesn't seem biological." +
                "<br /> <br /> Although it's only half full, it should bring you back from the brink of death. You're almost tempted to pocket it for a quick buck."),
            new Potion("Full K-Corp Ampule", "https://static.wikia.nocookie.net/limbuscompany/images/6/64/Decay_Ampule.png", 100, 3003, 
                "This is a ampule containing K-Corp's revolutionary singularity that can heal any wound. " +
                "Vials like this are usually sold to Fixer offices or associations and seldom sold to any solo-offices. " +
                "it works supposedly off nano-tech technology that can rapidly regenerate broken tissue. Though for some reason, it doesn't seem biological." +
                "<br /> <br /> Finding a full vial is an incredibly lucky find. This can bring you back from the brink of death and then some. " +
                "You are incredibly tempted to pocket this to sell later."),
            new Weapon("Zelkova Workshop Mace", "../images/Zelkova.png", 12, 4001, 
                "Zelkova Workshop is one of the many workshops in the city. Zelkova themselves focus mainly on blunt weapons meant to incapciate targets. " +
                "This mace seems to be a commissioned weapon, though you can't tell who commissioned it. You wonder how it ended up here. <br /> <br />" +
                "As for it's effectiveness.... you feel like it's a step above the baton you woke up with, but beyond that it isn't special."),
            new Weapon("Stigma Workshop Longsword", "../images/Stigma_Workshop.png", 15, 4002, 
                "Typically in the city, most workshops have a specific 'brand' of weapon they produce. It's what makes every workshop unique. " +
                "Stigma Workshop accomplishes this by imbuing their weapons with a pyroclastic pattern that inflict unique burns onto whoever is unfortunate to be attacked by " +
                "a Stigma Workshop weapon. This weapon specifically is of the Longsword variant, but Stigma Workshop is known for many other designs as well. <br /> <br />" +
                "This weapon is definitely a step ahead of that baton you woke up with."),
            new Weapon("Atelier Logic Handgun", "../images/Atelier.png", 20, 4003,
                "Gunsmiths in the City are somewhat rare. While the Head authorizes the use and production of firearm, it levies a hefty ammunition tax on " +
                "both producers and users, driving up the price of ammunition drastically. Atelier Logic is one of the few workshops that produces firearms, " +
                "their exclusivity provides them an edge in their quality as well. Most Fixer offices (if they can afford it) purchase from Atelier Logic <br /> <br />" +
                "The pistol you find in the basement appears to be a commissioned piece, the original owner being someone you can't tell. Surprisingly, it comes with" +
                " an impressive stache of bullets that have tax stamps. At least you won't have a Claw breathing down your neck for using it."),
            new Weapon("Rosespanner Workshop Spear", "../images/Rosespanner_Spear.png", 25, 4004, 
                "Fixer offices and their practices vary in the City. Their culture, purpose and brand often determined by their choice of equipment. " +
                "For example, the western Nests of the City and their Fixers typically dress in gaudy attire, while their eastern counterparts are in more formal attire. " +
                "The Rosespanner Fixer office (coincidentally, they are also a fixer office) display their culture through their self developed weaponry. " +
                "Rosespanner weapons tend to be mechanical in nature. This variant itself is a chainsaw merged into a two pronged spear that can compact itself into anything in between its prongs. " +
                "<br /> <br /> Contrary to popular belief, Guns are not the ultimate decider in a fight within the walls of the City. A large majority of Fixers in the City use melee weapons just " +
                "The Rosespanner Workshop Spear, and as a result have shifted the combative culture of the City to one that focuses mainly on melee weapons.")
        };
    }
}