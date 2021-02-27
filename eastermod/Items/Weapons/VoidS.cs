using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eastermod.Items.Weapons
{
    public class VoidS : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Void Blade");
            Tooltip.SetDefault("The blade of the Void...\nBurn your enemies with the dark flames...");
        }

        public override void SetDefaults()
        {
            item.damage = 900;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 5;
            item.useAnimation = 5;
            item.knockBack = 0;
            item.value = Item.buyPrice(gold: 99);
            item.rare = ItemRarityID.Purple;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 6;
            item.useStyle = 1;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.ShadowFlame,99);
        }
    }
}