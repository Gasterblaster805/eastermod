using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Projectiles
{
	public class DioKn : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("DioKn");
		}

		public override void SetDefaults() {
			projectile.width = 30;
			projectile.height = 30;
			projectile.timeLeft = 600;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
			projectile.penetrate = 999;
			projectile.aiStyle = 1;
		}
	}
}