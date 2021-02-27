using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
	public class DioKnife : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dio Knife"); 
			Tooltip.SetDefault("!! ZA WALDO !!\nEaster Egg");
		}

		public override void SetDefaults() 
		{
			item.damage = 2000;
			item.magic = true;
			item.mana = 800;
			item.width = 40;
			item.height = 40;
			item.useTime = 3;
			item.useAnimation = 4;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("DioKn");
			item.shootSpeed = 100f;
			item.useTurn = true;
		}
	}
}