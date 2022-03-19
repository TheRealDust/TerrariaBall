using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaBall.Projectiles;
using Microsoft.Xna.Framework;

namespace TerrariaBall.Items.Weapons
{
    public class KiLaser : KiWeapon
    {
        public override void SafeSetDefaults()
        {
            kiCost = 60;

            item.shoot = ModContent.ProjectileType<KiLaserProjectile>();
            item.shootSpeed = 70f;
            item.damage = 17;
            item.knockBack = 5f;
            item.useStyle = 5;
            item.UseSound = SoundID.Item12;
            item.useAnimation = 24;
            item.useTime = 60;
            item.width = 40;
            item.noUseGraphic = true;
            item.height = 40;
            item.autoReuse = true;
            item.value = 550;
            item.rare = ItemRarityID.Blue;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ki Laser");
        }

        public override void SafeShoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 55f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
        }
    }
}
