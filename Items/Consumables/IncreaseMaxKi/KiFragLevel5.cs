using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Consumables.IncreaseMaxKi
{
    public class KiFragLevel5 : ModItem
    {
        public static int DropRate = 2;
        public static int DropsFrom = NPCID.MoonLordCore;

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 20;
            item.consumable = true;
            item.maxStack = 1;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.value = 0;
            item.rare = 2;
            item.potion = false;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Master Ki Fragment");
            Tooltip.SetDefault("Increases your max Ki by 2000.");
        }

        public override bool CanUseItem(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            return player.whoAmI == Main.myPlayer && !modPlayer.KiFragLevel5;
        }

        public override bool UseItem(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.KiFragLevel5 = true;
            modPlayer.maxKi += 2000;

            return true;
        }
    }
}