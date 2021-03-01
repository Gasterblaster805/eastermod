using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Accessories
{
    public class VoidEye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Void Eye");
            Tooltip.SetDefault("You can see the unseen...\nPop out the old one, if you need a new one!\nAllows you every sight buff.\nBlocks the bad effects of The Eldrich Eye if put above it in the accessory bar.\n-10 defense.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Purple;
            item.defense = -10;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.AddBuff(BuffID.Dangersense, 1);
            player.AddBuff(BuffID.Hunter, 1);
            player.AddBuff(BuffID.Spelunker, 1);
            player.AddBuff(BuffID.NightOwl, 1);
            player.AddBuff(BuffID.Shine, 1);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NightOwlPotion, 10);
            recipe.AddIngredient(ItemID.HunterPotion, 10);
            recipe.AddIngredient(ItemID.ShinePotion, 10);
            recipe.AddIngredient(ItemID.TrapsightPotion, 10);
            recipe.AddIngredient(ItemID.SpelunkerPotion, 10);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}