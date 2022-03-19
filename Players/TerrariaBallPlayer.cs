using System;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace TerrariaBall
{
    public partial class TerrariaBallPlayer : ModPlayer
    {
        /// The current amount of ki the player has
        public int currentKi = 0;

        /// The max amount of ki this player can store
        public int maxKi = 1000;

        /// How much ki regenerates per-tick
        public int kiRegenRate = 1;

        /// Whether the player is a God
        public bool godMode = true;

        public static ModHotKey ChargeKey;

        #region Ki Fragments

        /// Increase Ki items - used/unused bool
        public bool KiFragLevel1 = false;
        public bool KiFragLevel2 = false;
        public bool KiFragLevel3 = false;
        public bool KiFragLevel4 = false;
        public bool KiFragLevel5 = false;

        #endregion

        public void ProcessCharge()
        {
            if (ChargeKey.Current && currentKi < maxKi)
            {
                currentKi = Math.Min(currentKi + kiRegenRate, maxKi);
            }
        }

        public override void PostUpdateRunSpeeds()
        {
            if (ChargeKey.Current && currentKi < maxKi)
            {
                player.maxRunSpeed = 0.5f;
                player.accRunSpeed = 0.5f;
                player.runAcceleration = 1;
            }
        }

        public override void PostUpdate()
        {
            if (ChargeKey.JustPressed)
            {
                player.statDefense = (int)((float)player.statDefense * 1.2);
            }
            else if (ChargeKey.JustReleased)
            {
                player.statDefense = (int)((float)player.statDefense / 1.2);
            }
        }

        public override TagCompound Save()
        {
            return new TagCompound
            {
                ["maxKi"] = maxKi,
                ["kiRegenRate"] = kiRegenRate,
                ["KiFragLevel1"] = KiFragLevel1,
                ["KiFragLevel2"] = KiFragLevel2,
                ["KiFragLevel3"] = KiFragLevel3,
                ["KiFragLevel4"] = KiFragLevel4,
                ["KiFragLevel5"] = KiFragLevel5,
            };
        }

        public override void Load(TagCompound tag)
        {
            maxKi = tag.GetInt("maxKi");
            kiRegenRate = tag.GetInt("kiRegenRate");
            KiFragLevel1 = tag.GetBool("KiFragLevel1");
            KiFragLevel2 = tag.GetBool("KiFragLevel2");
            KiFragLevel3 = tag.GetBool("KiFragLevel3");
            KiFragLevel4 = tag.GetBool("KiFragLevel4");
            KiFragLevel5 = tag.GetBool("KiFragLevel5");
        }
    }
}
