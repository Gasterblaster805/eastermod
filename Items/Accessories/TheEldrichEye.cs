using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace eastermod.Items.Accessories
{
	public class TheEldrichEye : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Eldrich Eye"); 
			Tooltip.SetDefault("Your sight is controlled...\nImmunity to Choas State\n-10 defense.");
		}
		public override void SetDefaults() 
			{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = -10;
			item.accessory = true;
			}
		public override void UpdateEquip(Player player)
			{
			player.buffImmune[BuffID.ChaosState] = true;	
			player.AddBuff(BuffID.Slow, 1);
			player.AddBuff(BuffID.Obstructed, 1);
		}		
	}
}