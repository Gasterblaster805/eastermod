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
            DisplayName.SetDefault("Melded Robe");
            Tooltip.SetDefault("These robes have seen better days...\nGrants immunity to Obstructed");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Purple;
            item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Obstructed] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "VoidSoul", 10);
            recipe.AddIngredient(ItemID.Robe);
            recipe.AddIngredient(ItemID.HallowedBar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}