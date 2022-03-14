using System;
using Terraria.ModLoader;

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

        public static ModHotKey ChargeKey;

        public void ProcessCharge()
        {
            if (ChargeKey.Current && currentKi < maxKi)
            {
                currentKi = Math.Min(currentKi + kiRegenRate, maxKi);
            }
        }
    }
}
