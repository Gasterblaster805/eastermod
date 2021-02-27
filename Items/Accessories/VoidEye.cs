using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace eastermod.Items.Accessories
{
	public class VoidEye : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Void Eye"); 
			Tooltip.SetDefault("You can see the unseen...\nAllows you every sight buff.\nBlocks the bad effects of The Eldrich Eye if put above it.\n-10 defense.");
		}
		public override void SetDefaults() 
			{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Purple;
			item.defense = -10;
			item.accessory = true;
			}
		public override void UpdateEquip(Player player)
			{
			player.buffImmune[BuffID.Obstructed] = true;	
			player.buffImmune[BuffID.Slow] = true;	
			player.AddBuff(BuffID.Dangersense, 1);
			player.AddBuff(BuffID.Hunter, 1);
			player.AddBuff(BuffID.Spelunker, 1);
			player.AddBuff(BuffID.NightOwl, 1);
			player.AddBuff(BuffID.Shine, 1);
		}		
	}
}