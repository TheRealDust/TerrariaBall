using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class EarthShard : ModItem 
    {
        public static int DropRate = 10;
        public static int MaxDrop = 3;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Earthen Shard");
            Tooltip.SetDefault("A fragment of a soul; the soul of the very earth itself, perhaps.");
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
