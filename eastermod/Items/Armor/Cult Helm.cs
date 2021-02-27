using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace eastermod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CultH : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Occultist Cloak"); 
			Tooltip.SetDefault("The cloak and mask of the Ancient One");
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
	
			public override bool IsArmorSet(Item head, Item body, Item legs)
				{
				return body.type == ModContent.ItemType<CultC>() && legs.type == ModContent.ItemType<CultL>();
				}

			public override void UpdateArmorSet(Player player)
			{
			player.setBonus = "An ancient power has awoken to aid you...";
			player.magicDamage += 0.2f;
			
		
			}
	}
}