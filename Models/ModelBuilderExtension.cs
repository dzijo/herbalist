using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<HerbAmount>().HasData(
                new HerbAmount(5, -1, 1, 1),
                new HerbAmount(3, 9, 2, 2),
                new HerbAmount(6, -2, 3, 3),
                new HerbAmount(3, 1, 4, 4),
                new HerbAmount(1, 7, 4, 5),
                new HerbAmount(2, 10, 5, 6),
                new HerbAmount(10, 3, 6, 7),
                new HerbAmount(5, 15, 7, 8),
                new HerbAmount(3, 15, 8, 9),
                new HerbAmount(5, -2, 8, 10),
                new HerbAmount(10, -2, 9, 11),
                new HerbAmount(10, 2, 10, 12),
                new HerbAmount(10, 6, 11, 13),
                new HerbAmount(10, 10, 12, 14),
                new HerbAmount(10, 14, 13, 15),
                new HerbAmount(10, 18, 14, 16),
                new HerbAmount(5, 18, 15, 17),
                new HerbAmount(5, 19, 15, 18),
                new HerbAmount(10, 17, 16, 19),
                new HerbAmount(10, 13, 16, 20),
                new HerbAmount(7, -3, 17, 21),
                new HerbAmount(4, -2, 18, 22),
                new HerbAmount(4, -3, 18, 23),
                new HerbAmount(3, 19, 19, 24),
                new HerbAmount(5, 11, 20, 25),
                new HerbAmount(1, 16, 21, 26),
                new HerbAmount(3, 15, 21, 27),
                new HerbAmount(4, 10, 22, 28),
                new HerbAmount(4, 18, 22, 29),
                new HerbAmount(2, 12, 23, 30),
                new HerbAmount(2, 8, 23, 31),
                new HerbAmount(2, 4, 23, 32),
                new HerbAmount(3, 20, 24, 33),
                new HerbAmount(3, 12, 24, 34),
                new HerbAmount(1, 3, 25, 35),
                new HerbAmount(1, 7, 25, 36),
                new HerbAmount(1, 11, 25, 37),
                new HerbAmount(1, 15, 25, 38),
                new HerbAmount(1, 19, 25, 39),
                new HerbAmount(10, 14, 26, 40),
                new HerbAmount(2, 16, 26, 41),
                new HerbAmount(2, 16, 27, 42),
                new HerbAmount(3, 20, 27, 43),
                new HerbAmount(6, -3, 28, 44),
                new HerbAmount(4, -4, 28, 45),
                new HerbAmount(10, -4, 29, 46),
                new HerbAmount(10, 12, 30, 47),
                new HerbAmount(6, 12, 31, 48),
                new HerbAmount(10, 7, 31, 49),
                new HerbAmount(9, 16, 32, 50),
                new HerbAmount(2, 4, 33, 51),
                new HerbAmount(2, 8, 33, 52),
                new HerbAmount(2, 12, 33, 53),
                new HerbAmount(2, 20, 33, 54),
                new HerbAmount(10, 3, 34, 55),
                new HerbAmount(10, 7, 34, 56),
                new HerbAmount(10, 19, 34, 57),
                new HerbAmount(9, 8, 35, 58),
                new HerbAmount(9, 12, 35, 59),
                new HerbAmount(12, 20, 36, 60),
                new HerbAmount(12, 12, 36, 61)
                );

            builder.Entity<PotionRecipe>().HasData(
                new PotionRecipe()
                {
                    Id = 1,
                    PotionName = "Healing Potion",
                    Rarity = Rarity.Common,
                    Description = "You regain 2d4 + 2 Hit Points when you drink this potion.\nThe potion's red liquid glimmers when agitated.",
                    DC = 10
                },
                new PotionRecipe()
                {
                    Id = 2,
                    PotionName = "Potion of Climbing",
                    Rarity = Rarity.Common,
                    Description = "When you drink this potion, you gain a climbing speed equal to your walking speed for 1 hour. During this time, you have advantage on Strength (Athletics) checks you make to climb. \nThe potion is separated into brown, silver, and gray layers resembling bands of stone. Shaking the bottle fails to mix the colors.",
                    DC = 10
                },
                new PotionRecipe()
                {
                    Id = 3,
                    PotionName = "Greater Healing Potion",
                    Rarity = Rarity.Uncommon,
                    Description = "You regain 4d4 + 4 Hit Points when you drink this potion. \nThe potion's red liquid glimmers when agitated.",
                    DC = 13
                },
                new PotionRecipe()
                {
                    Id = 4,
                    PotionName = "Potion of Animal Friendship",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, you can cast the Animal Friendship spell (save DC 13) for 1 hour at will. \nAgitating this muddy liquid brings little bits into view: a fish scale, a hummingbird tongue, a cat claw, or a squirrel hair.",
                    DC = 13
                },
                new PotionRecipe()
                {
                    Id = 5,
                    PotionName = "Potion of Fire Breath",
                    Rarity = Rarity.Uncommon,
                    Description = "After drinking this potion, you can use a bonus action to exhale fire at a target within 30 feet of you. The target must make a DC 13 Dexterity saving throw, taking 4d6 fire damage on a failed save, or half as much damage on a successful one. The effect ends after you exhale the fire three times or when 1 hour has passed. \nThis potion's orange liquid flickers, and smoke fills the top of the container and wafts out whenever it is opened. ",
                    DC = 13
                },
                new PotionRecipe()
                {
                    Id = 6,
                    PotionName = "Potion of Giant Strength (Hill Giant)",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, your Strength score changes to 21 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.\nThis potion's transparent liquid has floating in it a sliver of fingernail from a hill giant.",
                    DC = 14
                },
                new PotionRecipe()
                {
                    Id = 7,
                    PotionName = "Potion of Growth",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, you gain the \"enlarge\" effect of the enlarge/reduce spell for 1d4 hours (no Concentration required).\nThe red in the potion's liquid continuously expands from a tiny bead to color the clear liquid around it and then contracts. Shaking the bottle fails to interrupt this process.",
                    DC = 13
                },
                new PotionRecipe()
                {
                    Id = 8,
                    PotionName = "Potion of Poison",
                    Rarity = Rarity.Uncommon,
                    Description = "This concoction looks, smells, and tastes like a Potion of Healing or other beneficial potion. However, it is actually poison masked by Illusion magic. An Identify spell reveals its true Nature.\nIf you drink it, you take 3d6 poison damage, and you must succeed on a DC 13 Constitution saving throw or be Poisoned. At the start of each of your turns while you are Poisoned in this way, you take 3d6 poison damage. At the end of each of your turns, you can repeat the saving throw.On a successful save, the poison damage you take on your subsequent turns decreases by 1d6.The poison ends when the damage decreases to 0.",
                    DC = 14
                },
                new PotionRecipe()
                {
                    Id = 9,
                    PotionName = "Potion of Resistance (Random resistance)",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, you gain resistance to one type of damage for 1 hour. The DM chooses the type or determines it randomly.",
                    DC = 14
                },
                new PotionRecipe()
                {
                    Id = 10,
                    PotionName = "Potion of Resistance (Force, Radiant)",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, you gain resistance to Force and Radiant damage for 1 hour.",
                    DC = 14
                },
                new PotionRecipe()
                {
                    Id = 11,
                    PotionName = "Potion of Resistance (Cold, Necrotic)",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, you gain resistance to Cold and Necrotic damage for 1 hour.",
                    DC = 14
                },
                new PotionRecipe()
                {
                    Id = 12,
                    PotionName = "Potion of Resistance (Fire, Psychic)",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, you gain resistance to Fire and Psychic damage for 1 hour.",
                    DC = 14
                },
                new PotionRecipe()
                {
                    Id = 13,
                    PotionName = "Potion of Resistance (Acid, Poison)",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, you gain resistance to Acid and Poison damage for 1 hour.",
                    DC = 14
                },
                new PotionRecipe()
                {
                    Id = 14,
                    PotionName = "Potion of Resistance (Lightning, Thunder)",
                    Rarity = Rarity.Uncommon,
                    Description = "When you drink this potion, you gain resistance to Lightning and Thunder damage for 1 hour.",
                    DC = 14
                },
                new PotionRecipe()
                {
                    Id = 15,
                    PotionName = "Potion of Water Breathing",
                    Rarity = Rarity.Uncommon,
                    Description = "You can breathe Underwater for 1 hour after drinking this potion.\nIts cloudy green fluid smells of the sea and has a jellyfish-like bubble floating in it.",
                    DC = 13
                },
                new PotionRecipe()
                {
                    Id = 16,
                    PotionName = "Oil of Slipperiness",
                    Rarity = Rarity.Uncommon,
                    Description = "This sticky black unguent is thick and heavy in the container, but it flows quickly when poured.\nThe oil can cover a Medium or smaller creature, along with the Equipment it's wearing and carrying (one additional vial is required for each size category above Medium). Applying the oil takes 10 minutes. The affected creature then gains the effect of a Freedom of Movement spell for 8 hours. Alternatively, the oil can be poured on the ground as an action, where it covers a 10 - foot square, duplicating the effect of the Grease spell in that area for 8 hours.",
                    DC = 13
                },
                new PotionRecipe()
                {
                    Id = 17,
                    PotionName = "Superior Healing Potion",
                    Rarity = Rarity.Rare,
                    Description = "You regain 8d4 + 8 Hit Points when you drink this potion. \nThe potion's red liquid glimmers when agitated.",
                    DC = 16
                },
                new PotionRecipe()
                {
                    Id = 18,
                    PotionName = "Elixir of Health",
                    Rarity = Rarity.Rare,
                    Description = "When you drink this potion, it cures any disease afflicting you, and it removes the blinded, deafened, paralyzed, and poisoned conditions.\nThe clear red liquid has tiny bubbles of light in it. ",
                    DC = 16
                },
                new PotionRecipe()
                {
                    Id = 19,
                    PotionName = "Potion of Clairvoyance",
                    Rarity = Rarity.Rare,
                    Description = "When you drink this potion, you gain the effect of the Clairvoyance spell.\nAn eyeball bobs in this yellowish liquid but vanishes when the potion is opened.",
                    DC = 16
                },
                new PotionRecipe()
                {
                    Id = 20,
                    PotionName = "Potion of Diminution",
                    Rarity = Rarity.Rare,
                    Description = "When you drink this potion, you gain the \"reduce\" effect of the enlarge/reduce spell for 1d4 hours (no Concentration required).\nThe red in the potion's liquid continuously contracts to a tiny bead and then expands to color the clear liquid around it. Shaking the bottle fails to interrupt this process.",
                    DC = 16
                },
                new PotionRecipe()
                {
                    Id = 21,
                    PotionName = "Potion of Gaseous Form",
                    Rarity = Rarity.Rare,
                    Description = "When you drink this potion, you gain the effect of the Gaseous Form spell for 1 hour (no Concentration required) or until you end the effect as a Bonus Action.\nThis potion's container seems to hold fog that moves and pours like water.",
                    DC = 16
                },
                new PotionRecipe()
                {
                    Id = 22,
                    PotionName = "Potion of Giant Strength (Frost/Stone Giant)",
                    Rarity = Rarity.Rare,
                    Description = "When you drink this potion, your Strength score changes to 23 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.\nThis potion's transparent liquid has floating in it a sliver of fingernail from a frost/stone giant.",
                    DC = 17
                },
                new PotionRecipe()
                {
                    Id = 23,
                    PotionName = "Potion of Giant Strength (Fire Giant)",
                    Rarity = Rarity.Rare,
                    Description = "When you drink this potion, your Strength score changes to 25 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.\nThis potion's transparent liquid has floating in it a sliver of fingernail from a fire giant.",
                    DC = 18
                },
                new PotionRecipe()
                {
                    Id = 24,
                    PotionName = "Potion of Heroism",
                    Rarity = Rarity.Rare,
                    Description = "For 1 hour after drinking it, you gain 10 Temporary Hit Points that last for 1 hour. For the same Duration, you are under the effect of the bless spell (no Concentration required).\nThis blue potion bubbles and steams as if boiling.",
                    DC = 17
                },
                new PotionRecipe()
                {
                    Id = 25,
                    PotionName = "Potion of Invulnerability",
                    Rarity = Rarity.Rare,
                    Description = "For 1 minute after you drink this potion, you have Resistance to all damage.\nThe potion's syrupy liquid looks like liquefied iron.",
                    DC = 18
                },
                new PotionRecipe()
                {
                    Id = 26,
                    PotionName = "Potion of Mind Reading",
                    Rarity = Rarity.Rare,
                    Description = "When you drink this potion, you gain the effect of the Detect Thoughts spell (save DC 13).\nThe potion's dense, purple liquid has an ovoid cloud of pink floating in it.",
                    DC = 17
                },
                new PotionRecipe()
                {
                    Id = 27,
                    PotionName = "Oil of Etherealness",
                    Rarity = Rarity.Rare,
                    Description = "Beads of this cloudy gray oil form on the outside of its container and quickly evaporate.\nThe oil can cover a Medium or smaller creature, along with the Equipment it's wearing and carrying (one additional vial is required for each size category above Medium). Applying the oil takes 10 minutes. The affected creature then gains the effect of the Etherealness spell for 1 hour.",
                    DC = 17
                },
                new PotionRecipe()
                {
                    Id = 28,
                    PotionName = "Supreme Healing Potion",
                    Rarity = Rarity.VeryRare,
                    Description = "You regain 10d4 + 20 Hit Points when you drink this potion. \nThe potion's red liquid glimmers when agitated.",
                    DC = 20
                },
                new PotionRecipe()
                {
                    Id = 29,
                    PotionName = "Potion of Vitality",
                    Rarity = Rarity.VeryRare,
                    Description = "When you drink this potion, it removes any exhaustion you are suffering and cures any disease or poison affecting you. For the next 24 hours, you regain the maximum number of hit points for any Hit Die you spend.\nThe potion's crimson liquid regularly pulses with dull light, calling to mind a heartbeat. ",
                    DC = 20
                },
                new PotionRecipe()
                {
                    Id = 30,
                    PotionName = "Potion of Flying",
                    Rarity = Rarity.VeryRare,
                    Description = "When you drink this potion, you gain a flying speed equal to your walking speed for 1 hour and can hover. If you're in the air when the potion wears off, you fall unless you have some other means of staying aloft.\nThis potion's clear liquid floats at the top of its container and has cloudy white impurities drifting in it.",
                    DC = 21
                },
                new PotionRecipe()
                {
                    Id = 31,
                    PotionName = "Potion of Giant Strength (Cloud Giant)",
                    Rarity = Rarity.VeryRare,
                    Description = "When you drink this potion, your Strength score changes to 27 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.\nThis potion's transparent liquid has floating in it a sliver of fingernail from a cloud giant.",
                    DC = 21
                },
                new PotionRecipe()
                {
                    Id = 32,
                    PotionName = "Potion of Invisibility",
                    Rarity = Rarity.VeryRare,
                    Description = "This potion's container looks empty but feels as though it holds liquid.\nWhen you drink it, you become Invisible for 1 hour. Anything you wear or carry is Invisible with you. The effect ends early if you Attack or Cast a Spell.",
                    DC = 21
                },
                new PotionRecipe()
                {
                    Id = 33,
                    PotionName = "Potion of Longevity",
                    Rarity = Rarity.VeryRare,
                    Description = "When you drink this potion, your physical age is reduced by 1d6 + 6 years, to a minimum of 13 years. Each time you subsequently drink a potion of longevity, there is 10 percent cumulative chance that you instead age by 1d6 + 6 years.\nSuspended in this amber liquid are a scorpion's tail, an adder's fang, a dead spider, and a tiny heart that, against all reason, is still beating. These ingredients vanish when the potion is opened. ",
                    DC = 22
                },
                new PotionRecipe()
                {
                    Id = 34,
                    PotionName = "Potion of Speed",
                    Rarity = Rarity.VeryRare,
                    Description = "When you drink this potion, you gain the effect of the haste spell for 1 minute (no Concentration required).\nThe potion’s yellow fluid is streaked with black and swirls on its own.",
                    DC = 21
                },
                new PotionRecipe()
                {
                    Id = 35,
                    PotionName = "Oil of Sharpness",
                    Rarity = Rarity.VeryRare,
                    Description = "This clear, gelatinous oil sparkles with tiny, ultrathin silver shards.\nThe oil can coat one slashing or piercing weapon or up to 5 pieces of slashing or piercing Ammunition. Applying the oil takes 1 minute. For 1 hour, the coated item is magical and has a +3 bonus to Attack and Damage Rolls.",
                    DC = 21
                },
                new PotionRecipe()
                {
                    Id = 36,
                    PotionName = "Potion of Giant Strength (Storm Giant)",
                    Rarity = Rarity.VeryRare,
                    Description = "When you drink this potion, your Strength score changes to 29 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.\nThis potion's transparent liquid has floating in it a sliver of fingernail from a storm giant.",
                    DC = 25
                }
                );
        }
    }
}
