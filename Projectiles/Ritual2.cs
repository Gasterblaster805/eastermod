using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Projectiles
{
    public class Ritual2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ritual Ring");
        }

        public override void SetDefaults()
        {
            
            projectile.width = 408;
            projectile.height = 408;
            projectile.timeLeft = 6000;
            projectile.alpha = 255;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.penetrate = 999;     //+=0.15f;
            projectile.aiStyle = 0;
            
            projectile.light = 1f;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            // Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
            // 60 frames = 1 second
            target.AddBuff(BuffID.Ichor, 60);
            target.AddBuff(BuffID.Daybreak, 60);
            target.AddBuff(BuffID.WitheredWeapon, 60);
            target.AddBuff(BuffID.WitheredArmor, 60);
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner]; 
           
            {
                Dust dust;

                dust = Main.dust[Terraria.Dust.NewDust(projectile.position, 408, 408, 246, 0f, 0f, 0, new Color(255, 255, 255), 2f)];
                dust.noGravity = true;
            }

            projectile.rotation += -0.1f;

            projectile.alpha--;

            float maxDistance = 18f; // This also sets the maximun speed the projectile can reach while following the cursor.
            Vector2 vectorToCursor = player.Center - projectile.Center;
            float distanceToCursor = vectorToCursor.Length();

            // Here we can see that the speed of the projectile depends on the distance to the cursor.
            if (distanceToCursor > maxDistance)
            {
                distanceToCursor = maxDistance / distanceToCursor;
                vectorToCursor *= distanceToCursor;
            }

            int velocityXBy1000 = (int)(vectorToCursor.X * 2000f);
            int oldVelocityXBy1000 = (int)(projectile.velocity.X * 2000f);
            int velocityYBy1000 = (int)(vectorToCursor.Y * 2000f);
            int oldVelocityYBy1000 = (int)(projectile.velocity.Y * 2000f);

            // This code checks if the precious velocity of the projectile is different enough from its new velocity, and if it is, syncs it with the server and the other clients in MP.
            // We previously multiplied the speed by 1000, then casted it to int, this is to reduce its precision and prevent the speed from being synced too much.
            if (velocityXBy1000 != oldVelocityXBy1000 || velocityYBy1000 != oldVelocityYBy1000)
            {
                projectile.netUpdate = true;
            }

            projectile.velocity = vectorToCursor;
        }
    }                                                                                                   //	Dust dust;
                                                                                                        // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
                                                                                                        //Vector2 position = Main.LocalPlayer.Center;	//dust = Main.dust[Terraria.Dust.NewDust(position, 30, 30, 124, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
}