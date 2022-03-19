using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class KatchinScale : ModItem 
    {
        public static int DropRate = 1;
        public static int MinDrop = 12;
        public static int MaxDrop = 36;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Katchin Scale");
            Tooltip.SetDefault("A scale ripped from a great beast of the depths.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.Lime;
        }
    }
}
