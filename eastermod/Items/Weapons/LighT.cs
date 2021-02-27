using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
	public class LighT : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome of Lightning");
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
			item.useTime = 5;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Sorb");
			item.shootSpeed = 20f;
		}
		public override void AddRecipes()
		{
		
		}
	}
}
