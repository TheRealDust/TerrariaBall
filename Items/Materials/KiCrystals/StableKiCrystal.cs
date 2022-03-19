using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials.KiCrystals
{
    public class StableKiCrystal : ModItem 
    {
        public static int DropRate = 2;
        public static int MaxDrop = 2;


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stable Ki Crystal");
            Tooltip.SetDefault("The most stable and common form of solidified ki energy.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.Blue;
        }
    }
}
