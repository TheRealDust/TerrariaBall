using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TerrariaBall.Items.Weapons
{
    public class KiBeam : KiWeapon
    {
        public override void SafeSetDefaults()
        {
            kiCost = 2;
            item.shoot = mod.ProjectileType("KiBeamProjectile");
            item.shootSpeed = 70f;
            item.damage = 17;
            item.knockBack = 5f;
            item.useStyle = 5;
            item.UseSound = SoundID.Item12;
            item.useAnimation = 24;
            item.useTime = 24;
            item.width = 40;
            item.noUseGraphic = true;
            item.height = 40;
            item.autoReuse = true;
            item.value = 550;
            item.rare = 1;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ki Beam");
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 55f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            return true;
        }
    }
}
