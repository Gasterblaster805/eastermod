using System;
using Terraria.ModLoader;

namespace eastermod
{
    public class eastermod : Mod
    {
        public override void AddRecipes()
        {
            /* Here is an example of a recipe.
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "VoidSoul");
            recipe.AddIngredient(null, "VoidSoul");
            recipe.AddIngredient(null, "VoidSoul");
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.Wood, 999);
            recipe.AddRecipe();   */

            /*Here we reuse 'recipe', meaning we don't need to re-declare that it is a ModRecipe
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BlueBerries, 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PumpkinPie, 2);
            recipe.AddRecipe();               */
        }

        internal static void Items(string v)
        {
            throw new NotImplementedException();
        }
    }
}