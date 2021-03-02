using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.NPCs
{
    public class VoidSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Void Slime");
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
                return SpawnCondition.OverworldNightMonster.Chance * 0.25f;
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
    }
}