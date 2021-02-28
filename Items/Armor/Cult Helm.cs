using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class CultH : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Occultist Mask");
            Tooltip.SetDefault("This mask has seen better days...\nGrants immunity to Mana Sickness");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Blue;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.ManaSickness] = true;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<CultC>() && legs.type == ModContent.ItemType<CultL>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Power of the Occult\n+20% Magic Damage\n+20 Magic Critical Damage\n-20% Mana Cost";
            player.magicDamage += 0.2f;
            player.magicCrit += 20;
            player.manaCost = 0.80f;
        }
    }
}