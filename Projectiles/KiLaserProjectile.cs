using System;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TerrariaBall.Projectiles
{
    public class KiLaserProjectile : KiProjectile
    {
        private int pierced = 0;
        private int maxPiercing = 3;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("KiLaserProjectile");
        }

        public override void SetDefaults()
        {
            aiType = 14;
            projectile.width = 10;
            projectile.height = 10;
            projectile.gfxOffY = 174;
            projectile.light = 1f;
            projectile.knockBack = 1.0f;
            projectile.alpha = 220;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.netUpdate = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 120;
            projectile.aiStyle = 1;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 12;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (pierced++ < maxPiercing)
            {
                damage = Math.Max(damage / pierced, 0);

                if (damage == 0)
                {
                    pierced = maxPiercing;
                }
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (pierced == maxPiercing)
            {
                projectile.Kill();
            }
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Vector2 origin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
            for (int k = 0; k < projectile.oldPos.Length; k++)
            {
                Vector2 draw = projectile.oldPos[k] - Main.screenPosition + origin + new Vector2(0f, projectile.gfxOffY);
                Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
                spriteBatch.Draw(Main.projectileTexture[projectile.type], draw, null, color, projectile.rotation, origin, projectile.scale, SpriteEffects.None, 0f);
            }
            return true;
        }
    }
}