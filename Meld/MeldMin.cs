using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Meld
{
    public class MeldMin : ModNPC
    {

        private int Ai = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meld Fragment");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[6];
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
        
        
        public override void AI()
        {
            Player player = Main.player[npc.target];

        }
    }
}