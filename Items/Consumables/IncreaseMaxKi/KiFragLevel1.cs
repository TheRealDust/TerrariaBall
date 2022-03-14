using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Consumables.IncreaseMaxKi
{

    public class KiFragLevel1 : ModItem
    {
        public static int DropRate = 1;
        public static int DropsFrom = NPCID.SkeletronHead;

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
            DisplayName.SetDefault("Novice Ki Fragment");
            Tooltip.SetDefault("Increases your max Ki by 1000.");
        }

        public override bool CanUseItem(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            return player.whoAmI == Main.myPlayer && !modPlayer.KiFragLevel1;
        }

        public override bool UseItem(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.KiFragLevel1 = true;
            modPlayer.maxKi += 1000;

            return true;
        }
    }
}