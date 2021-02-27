using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace eastermod.Items.Accessories
{
    public class WaterA : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Water");
            Tooltip.SetDefault("You are always wet...\nGives you complete control over water.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = ItemRarityID.Blue;
            item.defense = 0;
            item.accessory = true;
        }
        public override void UpdateEquip(Player player)
        {
            player.adjWater = true;
            player.accDivingHelm = true;
            player.accFlipper = true;
            player.breathCD = 0;
            player.dripping = true;
            player.ignoreWater = true;
        }
    }
}