using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class ramendevC : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ra_men0's Chestplate");
            Tooltip.SetDefault("Dedicated to Ra_men0");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = ItemRarityID.Gray;
            item.defense = 0;
        }

        
        public override void AddRecipes()
        {
          
        }
    }
}