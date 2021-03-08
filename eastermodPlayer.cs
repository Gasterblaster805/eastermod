using eastermod.NPCs.Meld;
using Terraria;
using Terraria.ModLoader;

namespace eastermod
{
    public class eastermodPlayer : ModPlayer
    {
        public override void UpdateBiomeVisuals()
        {
            bool usePurity = NPC.AnyNPCs(ModContent.NPCType<Meld>());
            player.ManageSpecialBiomeVisuals("eastermod:Meld", usePurity);
        }
    }
}