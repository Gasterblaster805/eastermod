using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace eastermod.Items.Weapons
{
    public class VoidBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a void bullet that passes through blocks.");
        }

        public override void SetDefaults()
        {
            item.damage = 500;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 0f;
            item.value = 10;
            item.rare = ItemRarityID.Purple;
            item.shoot = ProjectileType<Projectiles.VoidBul>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 10f;                  //The speed of the projectile
            item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.

        }
    }
}