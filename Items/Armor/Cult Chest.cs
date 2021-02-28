using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class CultC : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Occultist Robe");
            Tooltip.SetDefault("These robes have seen better days...\nGrants immunity to Horrified");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Blue;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Horrified] = true;
        }
    }
}