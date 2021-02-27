using eastermod.Projectiles;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
	public class R : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome of the Ancient Light");
			Tooltip.SetDefault("Summons the Ritual of the Ancient One...\nCreates a magic ritual around the player");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 250;
			item.magic = true;
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 60;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Ritual");
			item.shootSpeed = 0f;
		//	item.buffType = (BuffID.Regeneration); //Specify an existing buff to be applied when used.
		//	item.buffTime = 6000; //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
		}

        public override bool CanUseItem(Player player)
		{
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

		public override void AddRecipes()
		{
		
		}
	}
}
