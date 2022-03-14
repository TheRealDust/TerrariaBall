using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials.KiCrystals
{
    public class PridefulKiCrystal : ModItem 
    {
        public static int DropRate = 3;
        public static int MaxDrop = 3;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Prideful Ki Crystal");
            Tooltip.SetDefault("This form of solidified Ki gives off the feeling of unyielding pride and ego, reminding you of a burning flame.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.Orange;
        }
    }
}
