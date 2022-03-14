using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials.KiCrystals
{
    public class CalmKiCrystal : ModItem 
    {
        public static int DropRate = 3;
        public static int MaxDrop = 3;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Calm Ki Crystal");
            Tooltip.SetDefault("This form of solidified Ki gives off the sense of calmness and tranquility reminiscient of a sunny forest.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.Green;
        }
    }
}
