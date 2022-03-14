using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class PossessedSoul : ModItem 
    {
        public static int DropRate = 3;
        public static int MaxDrop = 6;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of the Possessed");
            Tooltip.SetDefault("The soul of a reanimated foe.");
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
