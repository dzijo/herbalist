using Microsoft.EntityFrameworkCore.Migrations;

namespace Herbalist.Migrations
{
    public partial class AddPotions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PotionRecipes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PotionName = table.Column<string>(maxLength: 50, nullable: false),
                    Rarity = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 5000, nullable: false),
                    DC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotionRecipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Herbs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    HerbId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    PotionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herbs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Herbs",
                columns: new[] { "Id", "Amount", "HerbId", "PotionId" },
                values: new object[,]
                {
                    { 1, 5, -1, 1 },
                    { 34, 3, 12, 24 },
                    { 35, 1, 3, 25 },
                    { 36, 1, 7, 25 },
                    { 37, 1, 11, 25 },
                    { 38, 1, 15, 25 },
                    { 39, 1, 19, 25 },
                    { 40, 10, 14, 26 },
                    { 41, 2, 16, 26 },
                    { 42, 2, 16, 27 },
                    { 43, 3, 20, 27 },
                    { 44, 6, -3, 28 },
                    { 45, 4, -4, 28 },
                    { 46, 10, -4, 29 },
                    { 47, 10, 12, 30 },
                    { 49, 10, 7, 31 },
                    { 50, 9, 16, 32 },
                    { 51, 2, 4, 33 },
                    { 52, 2, 8, 33 },
                    { 53, 2, 12, 33 },
                    { 54, 2, 20, 33 },
                    { 55, 10, 3, 34 },
                    { 56, 10, 7, 34 },
                    { 57, 10, 19, 34 },
                    { 58, 9, 8, 35 },
                    { 59, 9, 12, 35 },
                    { 60, 12, 20, 36 },
                    { 61, 12, 12, 36 },
                    { 33, 3, 20, 24 },
                    { 32, 2, 4, 23 },
                    { 48, 6, 12, 31 },
                    { 30, 2, 12, 23 },
                    { 31, 2, 8, 23 },
                    { 2, 3, 9, 2 },
                    { 3, 6, -2, 3 },
                    { 4, 3, 1, 4 },
                    { 5, 1, 7, 4 },
                    { 6, 2, 10, 5 },
                    { 7, 10, 3, 6 },
                    { 8, 5, 15, 7 },
                    { 10, 5, -2, 8 },
                    { 11, 10, -2, 9 },
                    { 12, 10, 2, 10 },
                    { 13, 10, 6, 11 },
                    { 14, 10, 10, 12 },
                    { 15, 10, 14, 13 },
                    { 9, 3, 15, 8 },
                    { 25, 5, 11, 20 },
                    { 17, 5, 18, 15 },
                    { 18, 5, 19, 15 },
                    { 19, 10, 17, 16 },
                    { 20, 10, 13, 16 },
                    { 21, 7, -3, 17 },
                    { 22, 4, -2, 18 },
                    { 23, 4, -3, 18 },
                    { 24, 3, 19, 19 },
                    { 26, 1, 16, 21 },
                    { 27, 3, 15, 21 },
                    { 28, 4, 10, 22 },
                    { 16, 10, 18, 14 },
                    { 29, 4, 18, 22 }
                });

            migrationBuilder.InsertData(
                table: "PotionRecipes",
                columns: new[] { "Id", "DC", "Description", "PotionName", "Rarity" },
                values: new object[,]
                {
                    { 24, 17, @"For 1 hour after drinking it, you gain 10 Temporary Hit Points that last for 1 hour. For the same Duration, you are under the effect of the bless spell (no Concentration required).
                This blue potion bubbles and steams as if boiling.", "Potion of Heroism", 2 },
                    { 23, 18, @"When you drink this potion, your Strength score changes to 25 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.
                This potion's transparent liquid has floating in it a sliver of fingernail from a fire giant.", "Potion of Giant Strength (Fire Giant)", 2 },
                    { 34, 21, @"When you drink this potion, you gain the effect of the haste spell for 1 minute (no Concentration required).
                The potion’s yellow fluid is streaked with black and swirls on its own.", "Potion of Speed", 3 },
                    { 25, 18, @"For 1 minute after you drink this potion, you have Resistance to all damage.
                The potion's syrupy liquid looks like liquefied iron.", "Potion of Invulnerability", 2 },
                    { 21, 16, @"When you drink this potion, you gain the effect of the Gaseous Form spell for 1 hour (no Concentration required) or until you end the effect as a Bonus Action.
                This potion's container seems to hold fog that moves and pours like water.", "Potion of Gaseous Form", 2 },
                    { 22, 17, @"When you drink this potion, your Strength score changes to 23 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.
                This potion's transparent liquid has floating in it a sliver of fingernail from a frost/stone giant.", "Potion of Giant Strength (Frost/Stone Giant)", 2 },
                    { 26, 17, @"When you drink this potion, you gain the effect of the Detect Thoughts spell (save DC 13).
                The potion's dense, purple liquid has an ovoid cloud of pink floating in it.", "Potion of Mind Reading", 2 },
                    { 33, 22, @"When you drink this potion, your physical age is reduced by 1d6 + 6 years, to a minimum of 13 years. Each time you subsequently drink a potion of longevity, there is 10 percent cumulative chance that you instead age by 1d6 + 6 years.
                Suspended in this amber liquid are a scorpion's tail, an adder's fang, a dead spider, and a tiny heart that, against all reason, is still beating. These ingredients vanish when the potion is opened. ", "Potion of Longevity", 3 },
                    { 28, 20, @"You regain 10d4 + 20 Hit Points when you drink this potion. 
                The potion's red liquid glimmers when agitated.", "Supreme Healing Potion", 3 },
                    { 29, 20, @"When you drink this potion, it removes any exhaustion you are suffering and cures any disease or poison affecting you. For the next 24 hours, you regain the maximum number of hit points for any Hit Die you spend.
                The potion's crimson liquid regularly pulses with dull light, calling to mind a heartbeat. ", "Potion of Vitality", 3 },
                    { 30, 21, @"When you drink this potion, you gain a flying speed equal to your walking speed for 1 hour and can hover. If you're in the air when the potion wears off, you fall unless you have some other means of staying aloft.
                This potion's clear liquid floats at the top of its container and has cloudy white impurities drifting in it.", "Potion of Flying", 3 },
                    { 31, 21, @"When you drink this potion, your Strength score changes to 27 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.
                This potion's transparent liquid has floating in it a sliver of fingernail from a cloud giant.", "Potion of Giant Strength (Cloud Giant)", 3 },
                    { 32, 21, @"This potion's container looks empty but feels as though it holds liquid.
                When you drink it, you become Invisible for 1 hour. Anything you wear or carry is Invisible with you. The effect ends early if you Attack or Cast a Spell.", "Potion of Invisibility", 3 },
                    { 20, 16, @"When you drink this potion, you gain the ""reduce"" effect of the enlarge/reduce spell for 1d4 hours (no Concentration required).
                The red in the potion's liquid continuously contracts to a tiny bead and then expands to color the clear liquid around it. Shaking the bottle fails to interrupt this process.", "Potion of Diminution", 2 },
                    { 27, 17, @"Beads of this cloudy gray oil form on the outside of its container and quickly evaporate.
                The oil can cover a Medium or smaller creature, along with the Equipment it's wearing and carrying (one additional vial is required for each size category above Medium). Applying the oil takes 10 minutes. The affected creature then gains the effect of the Etherealness spell for 1 hour.", "Oil of Etherealness", 2 },
                    { 19, 16, @"When you drink this potion, you gain the effect of the Clairvoyance spell.
                An eyeball bobs in this yellowish liquid but vanishes when the potion is opened.", "Potion of Clairvoyance", 2 },
                    { 4, 13, @"When you drink this potion, you can cast the Animal Friendship spell (save DC 13) for 1 hour at will. 
                Agitating this muddy liquid brings little bits into view: a fish scale, a hummingbird tongue, a cat claw, or a squirrel hair.", "Potion of Animal Friendship", 1 },
                    { 17, 16, @"You regain 8d4 + 8 Hit Points when you drink this potion. 
                The potion's red liquid glimmers when agitated.", "Superior Healing Potion", 2 },
                    { 35, 21, @"This clear, gelatinous oil sparkles with tiny, ultrathin silver shards.
                The oil can coat one slashing or piercing weapon or up to 5 pieces of slashing or piercing Ammunition. Applying the oil takes 1 minute. For 1 hour, the coated item is magical and has a +3 bonus to Attack and Damage Rolls.", "Oil of Sharpness", 3 },
                    { 2, 10, @"When you drink this potion, you gain a climbing speed equal to your walking speed for 1 hour. During this time, you have advantage on Strength (Athletics) checks you make to climb. 
                The potion is separated into brown, silver, and gray layers resembling bands of stone. Shaking the bottle fails to mix the colors.", "Potion of Climbing", 0 },
                    { 3, 13, @"You regain 4d4 + 4 Hit Points when you drink this potion. 
                The potion's red liquid glimmers when agitated.", "Greater Healing Potion", 1 },
                    { 5, 13, @"After drinking this potion, you can use a bonus action to exhale fire at a target within 30 feet of you. The target must make a DC 13 Dexterity saving throw, taking 4d6 fire damage on a failed save, or half as much damage on a successful one. The effect ends after you exhale the fire three times or when 1 hour has passed. 
                This potion's orange liquid flickers, and smoke fills the top of the container and wafts out whenever it is opened. ", "Potion of Fire Breath", 1 },
                    { 6, 14, @"When you drink this potion, your Strength score changes to 21 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.
                This potion's transparent liquid has floating in it a sliver of fingernail from a hill giant.", "Potion of Giant Strength (Hill Giant)", 1 },
                    { 7, 13, @"When you drink this potion, you gain the ""enlarge"" effect of the enlarge/reduce spell for 1d4 hours (no Concentration required).
                The red in the potion's liquid continuously expands from a tiny bead to color the clear liquid around it and then contracts. Shaking the bottle fails to interrupt this process.", "Potion of Growth", 1 },
                    { 8, 14, @"This concoction looks, smells, and tastes like a Potion of Healing or other beneficial potion. However, it is actually poison masked by Illusion magic. An Identify spell reveals its true Nature.
                If you drink it, you take 3d6 poison damage, and you must succeed on a DC 13 Constitution saving throw or be Poisoned. At the start of each of your turns while you are Poisoned in this way, you take 3d6 poison damage. At the end of each of your turns, you can repeat the saving throw.On a successful save, the poison damage you take on your subsequent turns decreases by 1d6.The poison ends when the damage decreases to 0.", "Potion of Poison", 1 },
                    { 9, 14, "When you drink this potion, you gain resistance to one type of damage for 1 hour. The DM chooses the type or determines it randomly.", "Potion of Resistance (Random resistance)", 1 },
                    { 10, 14, "When you drink this potion, you gain resistance to Force and Radiant damage for 1 hour.", "Potion of Resistance (Force, Radiant)", 1 },
                    { 11, 14, "When you drink this potion, you gain resistance to Cold and Necrotic damage for 1 hour.", "Potion of Resistance (Cold, Necrotic)", 1 },
                    { 12, 14, "When you drink this potion, you gain resistance to Fire and Psychic damage for 1 hour.", "Potion of Resistance (Fire, Psychic)", 1 },
                    { 13, 14, "When you drink this potion, you gain resistance to Acid and Poison damage for 1 hour.", "Potion of Resistance (Acid, Poison)", 1 },
                    { 14, 14, "When you drink this potion, you gain resistance to Lightning and Thunder damage for 1 hour.", "Potion of Resistance (Lightning, Thunder)", 1 },
                    { 15, 13, @"You can breathe Underwater for 1 hour after drinking this potion.
                Its cloudy green fluid smells of the sea and has a jellyfish-like bubble floating in it.", "Potion of Water Breathing", 1 },
                    { 16, 13, @"This sticky black unguent is thick and heavy in the container, but it flows quickly when poured.
                The oil can cover a Medium or smaller creature, along with the Equipment it's wearing and carrying (one additional vial is required for each size category above Medium). Applying the oil takes 10 minutes. The affected creature then gains the effect of a Freedom of Movement spell for 8 hours. Alternatively, the oil can be poured on the ground as an action, where it covers a 10 - foot square, duplicating the effect of the Grease spell in that area for 8 hours.", "Oil of Slipperiness", 1 },
                    { 18, 16, @"When you drink this potion, it cures any disease afflicting you, and it removes the blinded, deafened, paralyzed, and poisoned conditions.
                The clear red liquid has tiny bubbles of light in it. ", "Elixir of Health", 2 },
                    { 36, 25, @"When you drink this potion, your Strength score changes to 29 for 1 hour. The potion has no effect on you if your Strength is equal to or greater than that score.
                This potion's transparent liquid has floating in it a sliver of fingernail from a storm giant.", "Potion of Giant Strength (Storm Giant)", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Herbs",
                table: "Herbs");

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Herbs",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DropColumn(
                name: "PotionId",
                table: "Herbs");

            migrationBuilder.RenameTable(
                name: "Herbs",
                newName: "HerbAmount");

            migrationBuilder.AddColumn<int>(
                name: "PotionRecipeId",
                table: "HerbAmount",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HerbAmount",
                table: "HerbAmount",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HerbAmount_PotionRecipeId",
                table: "HerbAmount",
                column: "PotionRecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_HerbAmount_PotionRecipes_PotionRecipeId",
                table: "HerbAmount",
                column: "PotionRecipeId",
                principalTable: "PotionRecipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
