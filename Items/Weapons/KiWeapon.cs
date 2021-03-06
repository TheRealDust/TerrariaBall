using Terraria;
using Terraria.ModLoader;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace TerrariaBall.Items.Weapons
{
    public abstract class KiWeapon : ModItem
    {
        /// The base ki cost of this weapon, required to fire it once or for one frame
        public int kiCost;

        public virtual void SafeSetDefaults()
        {

        }

        public sealed override void SetDefaults()
        {
            SafeSetDefaults();

            item.melee = false;
            item.ranged = false;
            item.magic = false;
            item.thrown = false;
            item.summon = false;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            // Get the vanilla damage tooltip
            TooltipLine tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");

            if (tt != null)
            {
                // We want to grab the last word of the tooltip, which is the translated word for 'damage' (depending on what language the player is using)
                // So we split the string by whitespace, and grab the last word from the returned arrays to get the damage word, and the first to get the damage shown in the tooltip
                string[] splitText = tt.text.Split(' ');
                string damageValue = splitText.First();
                string damageWord = splitText.Last();
                // Change the tooltip text
                tt.text = damageValue + " ki " + damageWord;
            }
        }

        public override bool CanUseItem(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            return modPlayer.godMode || (modPlayer.currentKi >= kiCost && !TerrariaBallPlayer.ChargeKey.Current);
        }

        public virtual void SafeShoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
        }

        public sealed override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.whoAmI == Main.myPlayer)
            {
                TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
                modPlayer.UseKi(kiCost);
            }
            SafeShoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
            return true;
        }
    }
}