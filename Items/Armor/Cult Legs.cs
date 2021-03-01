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
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Confused] = true;
        }

        public override bool DrawLegs()
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "VoidSoul", 10);
            recipe.AddIngredient(ItemID.MeteorLeggings);
            recipe.AddIngredient(ItemID.HallowedBar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}