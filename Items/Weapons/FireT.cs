using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
	public class FireT : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome of the Fire");
			Tooltip.SetDefault("The Ancient One's tome of fire.\nShoots a fireball.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.magic = true;
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Dorb");
			item.shootSpeed = 16f;
		}

	
		




		public override void AddRecipes()
		{
		
		}
	}
}