
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Projectiles
{
    public class Boner : ModProjectile
    {
        public override void SetStaticDefaults()
        {
        
            DisplayName.SetDefault("Boner");
        }

        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.timeLeft = 600;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.penetrate = 10;
            projectile.aiStyle = 0;
            projectile.alpha = 25;

         
        }

       

        public override void AI()
        {
            projectile.rotation += 0.5f;
        }
    }
}