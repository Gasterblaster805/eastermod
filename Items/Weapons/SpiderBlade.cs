using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
	public class SpiderBlade : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("The Spider Blade");
			Tooltip.SetDefault("The blade knows of your summoning skills.\nA shortsword that does summon damage.");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults() {
			item.damage = 40; // The damage your item deals
			item.summon = true; // Whether your item is part of the melee class
			item.width = 40; // The item texture's width
			item.height = 40; // The item texture's height
			item.useTime = 15; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 15; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
			item.knockBack = 6; // The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(gold: 1); // The value of the weapon in copper coins
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; 
			item.crit = 0; 
			item.useStyle =1; 
		}


		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Webbed, 6000);
		}

		
	}
}