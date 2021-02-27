using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
	public class Cheese : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cheese"); 
			Tooltip.SetDefault("Cheese Grommit!\nEaster Egg");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 3;
			item.knockBack = 0;
			item.value = 0;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
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