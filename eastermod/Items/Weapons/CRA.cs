using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
	public class CRA : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cwasont");
			Tooltip.SetDefault("No kid, knock yourself out...\nEaster Egg");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults() {
			item.damage = 1; // The damage your item deals
			item.melee = true; // Whether your item is part of the melee class
			item.width = 999; // The item texture's width
			item.height = 999; // The item texture's height
			item.useTime = 13; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 13; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
			item.knockBack = 0; // The force of knockback of the weapon. Maximum is 20
			item.rare = ItemRarityID.Green; // The rarity of the weapon, from -1 to 13. You can also use ItemRarityID.TheColorRarity
			item.UseSound = SoundID.Item1; // The sound when the weapon is being used
			item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button
			item.crit = 0; // The critical strike chance the weapon has. The player, by default, has 4 critical strike chance

			//The useStyle of the item. 
			//Use useStyle 1 for normal swinging or for throwing
			//use useStyle 2 for an item that drinks such as a potion,
			//use useStyle 3 to make the sword act like a shortsword
			//use useStyle 4 for use like a life crystal,
			//and use useStyle 5 for staffs or guns
			item.useStyle = 1; // 1 is the useStyle
		}

		public override void AddRecipes()
		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 666);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}