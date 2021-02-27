using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace eastermod.Items.Weapons
{
	public class VoidSn : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Void Sniper");
			Tooltip.SetDefault("The Sniper Rifle of the Void...\nShoots Slowly, with 100% crit chance.");
		}

		public override void SetDefaults()
		{
			item.damage = 3000; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.crit = 96;
			item.height = 3; // hitbox height of the item
			item.useTime = 100; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 100; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Purple; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.

		}

		public override void AddRecipes()
		{

		}
	}
}