using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace eastermod.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class VoidWI : ModItem
	{
		
		public override void SetStaticDefaults()
		{
	        DisplayName.SetDefault("Unstable Wings");
			Tooltip.SetDefault("These wings feel crude, and weak, they could use an upgrade.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 999;
			item.rare = ItemRarityID.Purple;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 300;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.50f;
			ascentWhenRising = 0.10f;
			maxCanAscendMultiplier = 1.5f;
			maxAscentMultiplier = 2f;
			constantAscend = 0.1f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 13f;
			acceleration *= 7f;
		}

		public override void AddRecipes()
		{
			
		}
	}
}