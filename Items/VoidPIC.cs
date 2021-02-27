
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace eastermod.Items
{
	public class VoidPIC : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void Pickaxe");
			Tooltip.SetDefault("The Pickaxe of the void...");
		}

		public override void SetDefaults()
		{
			item.damage = 0;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 5;
			item.pick = 999;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.tileBoost += 25;
		
		}
		
		public override void AddRecipes()
		{
			
		}
	}
}