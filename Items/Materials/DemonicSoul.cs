using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class DemonicSoul : ModItem 
    {
        public static int DropRate = 3;
        public static int MaxDrop = 3;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demonic Soul");
            Tooltip.SetDefault("The soul of a demonic being sealed in the underworld deep below.");
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
