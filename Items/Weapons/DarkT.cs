using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
    public class DarkT : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tome of the Darkflame");
            Tooltip.SetDefault("The Ancient One's tome of fire.\nShoots dark fireballs.");
            Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.magic = true;
            item.mana = 20;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.value = 50000;
            item.rare = ItemRarityID.Purple;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Sorb");
            item.shootSpeed = 20f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FireT");
            recipe.AddIngredient(ItemID.CursedFlames);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}