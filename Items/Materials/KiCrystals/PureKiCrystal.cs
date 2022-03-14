using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials.KiCrystals
{
    public class PureKiCrystal : ModItem 
    {
        public static int DropRate = 3;
        public static int MaxDrop = 5;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pure Ki Crystal");
            Tooltip.SetDefault("This form of solidified Ki is radiant; absolutely pure and undiluted, a state sought after all across the world.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.Yellow;
        }
    }
}
