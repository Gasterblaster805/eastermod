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
            DisplayName.SetDefault("Melded Mask");
            Tooltip.SetDefault("This mask has seen better days...\nGrants immunity to Mana Sickness");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Purple;
            item.defense = 30;
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
            player.setBonus = "Power of the Meld\n+30% Magic Damage\n+25% Magic Crit Chance\n-20% Mana Cost\n+70 Maximum Mana";
            player.magicDamage += 0.3f;        //
            player.magicCrit += 25;             //
            player.manaCost -= 0.1f;
            player.statManaMax2 += 70;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "VoidSoul", 10);
            recipe.AddIngredient(ItemID.SkeletronPrimeMask);
            recipe.AddIngredient(ItemID.HallowedBar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}