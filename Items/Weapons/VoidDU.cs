using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace eastermod.Items.Weapons
{
	public class VoidDU : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Left click to swing fast but with 600 Damage.\nRight click to stab slowly and deal 2000 damage.");
		}

		public override void SetDefaults()
		{
			item.damage = 600;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		
		}

		public override void AddRecipes()
		{
			
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = ItemUseStyleID.Stabbing;
				item.useTime = 15;
				item.useAnimation = 15;
				item.damage = 2000;
				item.crit = 75;
			
			}
			else
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTime = 7;
				item.useAnimation = 7;
				item.damage = 600;
		  
			}
			return base.CanUseItem(player);
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			if (player.altFunctionUse == 2)
			{
				target.AddBuff(BuffID.ShadowFlame, 60);
			}
			else
			{
				target.AddBuff(BuffID.ShadowFlame, 60);
			}
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				if (player.altFunctionUse == 2)
				{
					
				}
				else
				{
					
				}
			}
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Fix the speedX and Y to point them horizontally.
			speedX = new Vector2(speedX, speedY).Length() * (speedX > 0 ? 1 : -1);
			speedY = 0;
			// Add random Rotation
			Vector2 speed = new Vector2(speedX, speedY);
			speed = speed.RotatedByRandom(MathHelper.ToRadians(30));
			// Change the damage since it is based off the weapons damage and is too high
			damage = (int)(damage * .1f);
			speedX = speed.X;
			speedY = speed.Y;
			return true;
		}
	}
}