using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace eastermod.Items.Weapons
{
	public class R : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome of the Ancient Ritual");
			Tooltip.SetDefault("Creates a magic ritual around the player");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.magic = true;
			item.mana = 200;
			item.width = 40;
			item.height = 40;
			item.useTime = 60;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Yellow;
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

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("Ritual2"), damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 25);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
