using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.NPCs.Meld
{
    public class MeldMin : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Shard");
        }

        public override void SetDefaults()
        {
            projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet;
            projectile.width = 14;
            projectile.height = 14;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.damage = 100;
            projectile.penetrate = -1;
            projectile.timeLeft = 400;
            projectile.tileCollide = false;
            projectile.light = 1f;
        }
    }
}