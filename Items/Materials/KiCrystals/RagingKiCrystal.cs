using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials.KiCrystals
{
    public class RagingKiCrystal : ModItem 
    {
        public static int DropRate = 3;
        public static int MaxDrop = 3;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Raging Ki Crystal");
            Tooltip.SetDefault("This form of solidified Ki gives off a sense of burning rage and hatred found only in the depths of true evil.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.LightRed;
        }
    }
}
