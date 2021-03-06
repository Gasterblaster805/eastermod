using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.NPCs
{
    public class VoidSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meld Slime");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[2];
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
            npc.aiStyle = 1;
            aiType = 1;
            animationType = 1;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedPlantBoss)
            {
                return SpawnCondition.OverworldNightMonster.Chance * 0.10f;
            }
            else
            {
                return 0f;
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
    }
}