using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class CultL : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Occultist Leggings");
            Tooltip.SetDefault("This legwear has seen better days...\nGrants immunity to Confused");
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
            player.buffImmune[BuffID.Confused] = true;
        }

        public override bool DrawLegs()
        {
            return false;
        }
    }
}