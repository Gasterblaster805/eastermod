using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Meld
{
    public class MeldMin : ModNPC
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meld Fragment");
        }

        public override void SetDefaults()
        {
            npc.width = 20;
            npc.height = 20;
            npc.damage = 50;
            npc.defense = 25;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
            npc.knockBackResist = 1f;
            npc.aiStyle = -1;
        }

        /*
         * 0 = Nothing
         * 1 = Target Found, Attack
         * 2 = Target Dead
         */

        public override void AI()
        {
            if (npc.ai[0] == 0f && Main.netMode != NetmodeID.MultiplayerClient)
            {
                npc.TargetClosest(true);
                npc.ai[0] = 1f;
            }

            if (Main.player[npc.target].dead || Math.Abs(npc.position.X - Main.player[npc.target].position.X) > 2000f || Math.Abs(npc.position.Y - Main.player[npc.target].position.Y) > 2000f)
            {
                npc.TargetClosest(true);
                if (Main.player[npc.target].dead || Math.Abs(npc.position.X - Main.player[npc.target].position.X) > 2000f || Math.Abs(npc.position.Y - Main.player[npc.target].position.Y) > 2000f)
                {
                    npc.ai[1] = 3f;
                }
            }
            if (npc.ai[1] == 2f)
            {
                npc.rotation += npc.direction * 0.4f;
                if (Vector2.Distance(Main.player[npc.target].Center, npc.Center) > 1)
                {
                    npc.velocity += Vector2.Normalize(Main.player[npc.target].Center - npc.Center) * new Vector2(.5f, .2f);
                }

                npc.velocity *= 0.98f;
                npc.velocity.X = Utils.Clamp(npc.velocity.X, -18, 18);
                npc.velocity.Y = Utils.Clamp(npc.velocity.Y, -18, 18);
            }
            else if (npc.ai[1] == 3f)
            {
                npc.velocity.Y = npc.velocity.Y + 0.1f;
                if (npc.velocity.Y < 0f)
                {
                    npc.velocity.Y = npc.velocity.Y * 0.95f;
                }
                npc.velocity.X = npc.velocity.X * 0.95f;
                if (npc.timeLeft > 50)
                {
                    npc.timeLeft = 50;
                }
            }
        }
    }
}