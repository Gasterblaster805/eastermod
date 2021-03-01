using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Accessories
{
    public class TheEldrichEye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Eldritch Eye");
            Tooltip.SetDefault("Pop out the old one, if you need a new one!\nImmunity to Choas State\n-10 defense.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.defense = -10;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.ChaosState] = true;
            player.AddBuff(BuffID.Slow, 1);
            player.AddBuff(BuffID.Obstructed, 1);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "VoidSoul", 10);
            recipe.AddIngredient(ItemID.RodofDiscord);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}