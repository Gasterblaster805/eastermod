using System;
using Terraria;
using Terraria.ModLoader;
using eastermod.NPCs.Meld;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

using System.Collections.Generic;
using System.IO;

using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;

using Terraria.UI;


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

        public override void Load()
        {
            Filters.Scene["eastermod:Meld"] = new Filter(new MeldData("FilterMiniTower").UseColor(1.33f, 0.91f, 2.21f).UseOpacity(0.5f), EffectPriority.VeryHigh); // rgb(133, 91, 221)             og(0.4f, 0.9f, 0.4f)
            SkyManager.Instance["eastermod:Meld"] = new MeldSky();
        }
    }
}