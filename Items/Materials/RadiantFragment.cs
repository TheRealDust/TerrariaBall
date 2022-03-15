using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class RadiantFragment : ModItem 
    {
        public static int DropRate = 1;
        public static int MinDrop = 6;
        public static int MaxDrop = 12;
        public static int ExpertMinDrop = 9;
        public static int ExpertMaxDrop = 18;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Radiant Fragment");
            Tooltip.SetDefault("A radiant gem. Seems to be just a fragment of something greater...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.Cyan;
        }
    }
}
