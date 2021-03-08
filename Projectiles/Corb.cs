using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Projectiles
{
    public class Corb : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Shard");
        }

        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.timeLeft = 400;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = false;
            projectile.penetrate = 10;
            projectile.light = 0.33f;
            projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
            projectile.light = 0.5f;
            projectile.timeLeft = 400;
        }
       
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.immune[projectile.owner] = 5;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
        }
    }
}