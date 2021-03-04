//Thanks example mod! UwU
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Meld
{
    [AutoloadBossHead]
    public class Meld : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meld");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.width = 150;
            npc.height = 150;
            npc.damage = 50;
            npc.defense = 25;
            npc.lifeMax = 30000;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
            npc.knockBackResist = 1f;
            npc.aiStyle = -1;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax / Main.expertLife * 1.2f * bossLifeScale);
            npc.defense = 50;
        }

        private int difficulty
        {
            get
            {
                double strength = (double)npc.lifeMax;
                int difficulty = (int)(4.0 * (1.0 - strength));
                if (Main.expertMode)
                {
                    difficulty++;
                }
                return difficulty;
            }
        }

        private float difficultyGradient
        {
            get
            {
                double strength = (double)npc.lifeMax;
                double difficulty = 4.0 * (1.0 - strength);
                return (float)(difficulty % 1.0);
            }
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("VoidSoul"));
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++)
            {
                int dustType = Main.rand.Next(27, 27);
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.1f;
            }
        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }

        public override void FindFrame(int frameHeight)
        {
            if (npc.life <= 10000)
            {
                npc.frame.Y = 2 * frameHeight;
            }

            if (npc.life <= 20000 && npc.life >= 10000)
            {
                npc.frame.Y = 1 * frameHeight;
            }
        }

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
            if (npc.ai[1] != 3f && npc.ai[1] != 2f)
            {
                Main.PlaySound(SoundID.Roar, (int)npc.position.X, (int)npc.position.Y, 0, 1f, 0f);
                npc.ai[1] = 2f;
            }
            if (npc.ai[1] == 2f)
            {
                npc.rotation += npc.direction * 0.6f;
                if (Vector2.Distance(Main.player[npc.target].Center, npc.Center) > 0)
                {
                    npc.velocity += Vector2.Normalize(Main.player[npc.target].Center - npc.Center) * new Vector2(.3f, .1f);
                }

                npc.velocity *= 0.98f;
                npc.velocity.X = Utils.Clamp(npc.velocity.X, -8, 8);
                npc.velocity.Y = Utils.Clamp(npc.velocity.Y, -8, 8);
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