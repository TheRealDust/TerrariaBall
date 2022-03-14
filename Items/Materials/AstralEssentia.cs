using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class AstralEssentia : ModItem 
    {
        public static int DropRate = 3;
        public static int MaxDrop = 3;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Essentia");
            Tooltip.SetDefault("The essence of those above.");
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
