using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace eastermod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CultC : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Occultist Robe"); 
			Tooltip.SetDefault("The robe of the Ancient One");
		}
		public override void SetDefaults() 
			{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 30;
			}
		public override void UpdateEquip(Player player)
			{
			player.buffImmune[BuffID.ManaSickness] = true;
		}		
	}
}