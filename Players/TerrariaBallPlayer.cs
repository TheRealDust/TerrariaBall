using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using TerrariaBall.Items.Weapons;

namespace TerrariaBall
{
    public partial class TerrariaBallPlayer : ModPlayer
    {
        private int _currentKi = 0;

        /// The current amount of ki the player has
        public int currentKi
        {
            get { return _currentKi; }
        }

        private int _maxKi = 1000;

        /// The max amount of ki this player can store
        public int maxKi
        {
            get { return _maxKi + bonusMaxKi; }
        }

        /// How much ki regenerates per-tick (when charging)
        public int kiRegenRate = 1;

        #region Buffs

        public int bonusMaxKi = 0;

        /// A multiplier on the damage of ki weapons
        public float kiDamageMultiplier = 1.0f;

        /// A multiplier on the knockback of ki weapons
        public float kiKnockbackMultipler = 1.0f;

        /// A multiplier on the crit rate of ki weapons
        public float kiCritrateMultiplier = 1.0f;

        /// A multiplier on the ki recharge rate
        public float kiRechargeRateMultiplier = 1.0f;

        /// A multiplier on the ki drain
        public float kiDrainMultiplier = 1.0f;

        /// The amount of ki to passively regenerate (per-tick)
        public int passiveKiRegen = 0;

        #endregion

        /// Whether the player is a God
        public bool godMode = false;

        public static ModHotKey ChargeKey;

        #region Ki Fragments

        /// Increase Ki items - used/unused bool
        public bool KiFragLevel1 = false;
        public bool KiFragLevel2 = false;
        public bool KiFragLevel3 = false;
        public bool KiFragLevel4 = false;
        public bool KiFragLevel5 = false;

        #endregion

        public override void ModifyWeaponDamage(Item item, ref float add, ref float mult, ref float flat)
        {
            if (ModContent.GetModItem(item.type) is KiWeapon)
            {
                mult *= kiDamageMultiplier;
            }
        }

        public override void GetWeaponCrit(Item item, ref int crit)
        {
            if (ModContent.GetModItem(item.type) is KiWeapon)
            {
                crit = (int)((float)crit * kiDamageMultiplier);
            }
        }

        public override void GetWeaponKnockback(Item item, ref float knockback)
        {
            if (ModContent.GetModItem(item.type) is KiWeapon)
            {
                knockback *= kiDamageMultiplier;
            }
        }

        /// Use the specified amount of ki, it is up to the caller to check if the player has enough ki to do this.
        /// The amount of ki will be floored at 0.
        public void UseKi(int amount)
        {
            _currentKi = Math.Min(_currentKi - (int)((float)amount * kiDrainMultiplier), 0);
        }

        /// Permanently increase the max ki of this player by a constant amount.
        public void PermanentlyIncreaseMaxKi(int amount)
        {
            _maxKi += amount;
        }

        /// Debug function to reset max ki (this will remove all fragments from player history)
        /// Note that this will not effect temporary buffs from things like armour
        public void ResetMaxKi()
        {
            _maxKi = 0;
            KiFragLevel1 = false;
            KiFragLevel2 = false;
            KiFragLevel3 = false;
            KiFragLevel4 = false;
            KiFragLevel5 = false;
        }

        public void ProcessCharge()
        {
            if (ChargeKey.Current && _currentKi < maxKi)
            {
                _currentKi = Math.Min(_currentKi + (int)((float)kiRegenRate * kiRechargeRateMultiplier), maxKi);
            }
            else if (passiveKiRegen > 0)
            {
                _currentKi = Math.Min(_currentKi + passiveKiRegen, maxKi);
            }
            else if (passiveKiRegen < 0)
            {
                _currentKi = Math.Max(_currentKi - passiveKiRegen, 0);
            }
        }

        public override void PostUpdateRunSpeeds()
        {
            if (ChargeKey.Current && _currentKi < maxKi)
            {
                player.maxRunSpeed = 0.5f;
                player.accRunSpeed = 0.5f;
                player.runAcceleration = 1;
            }
        }

        // fixme this does not work
        // public override void PostUpdate()
        // {
        //     if (ChargeKey.JustPressed)
        //     {
        //         player.statDefense = (int)((float)player.statDefense * 1.2);
        //     }
        //     else if (ChargeKey.JustReleased)
        //     {
        //         player.statDefense = (int)((float)player.statDefense / 1.2);
        //     }
        // }

        public override TagCompound Save()
        {
            return new TagCompound
            {
                ["maxKi"] = _maxKi,
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
            _maxKi = tag.GetInt("maxKi");
            kiRegenRate = tag.GetInt("kiRegenRate");
            KiFragLevel1 = tag.GetBool("KiFragLevel1");
            KiFragLevel2 = tag.GetBool("KiFragLevel2");
            KiFragLevel3 = tag.GetBool("KiFragLevel3");
            KiFragLevel4 = tag.GetBool("KiFragLevel4");
            KiFragLevel5 = tag.GetBool("KiFragLevel5");
        }
    }
}
