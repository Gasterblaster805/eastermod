using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.NPCs.Meld
{
    public class MeldCoin : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odd Coin");
            Tooltip.SetDefault("The coin features an odd gem...\nSpawns The Meld after Moonlord is defeated");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.value = 100;
            item.rare = ItemRarityID.Purple;
            item.useAnimation = 50;
            item.useTime = 50;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return NPC.downedMoonlord && !NPC.AnyNPCs(ModContent.NPCType<Meld>());
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Meld>());
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.AddIngredient(ItemID.SoulofFlight);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddIngredient(ItemID.SoulofSight);
            recipe.AddIngredient(ItemID.SoulofNight);
            recipe.AddIngredient(ItemID.LunarBar);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}