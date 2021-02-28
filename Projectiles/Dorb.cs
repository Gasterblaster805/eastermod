
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Projectiles
{
    public class Dorb : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 4;
            DisplayName.SetDefault("Blood Orb");
        }

        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.timeLeft = 600;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = false;
            projectile.penetrate = 999;
            projectile.aiStyle = 0;

            // projectile.light = 0.5f;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            // Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
            // 60 frames = 1 second
            target.AddBuff(BuffID.OnFire, 600);
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];

         //   projectile.rotation = projectile.velocity.X * 0.5f;

            //if (Main.rand.Next(6) == 0)
            {
                Dust dust;
               
                dust = Main.dust[Terraria.Dust.NewDust(projectile.position, 30, 30, 27, 0f, 0f, 0, new Color(255, 255, 255), 4.144737f)];
                dust.noGravity = true;
            }

            // This is a simple "loop through all frames from top to bottom" animation
            int frameSpeed = 3;
            projectile.frameCounter++;
            if (projectile.frameCounter >= frameSpeed)
            {
                projectile.frameCounter = 0;
                projectile.frame++;
                if (projectile.frame >= Main.projFrames[projectile.type])
                {
                    projectile.frame = 0;
                }
            }
        }
    }
}