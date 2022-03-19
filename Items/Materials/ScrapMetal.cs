using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class ScrapMetal : ModItem 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scrap Metal");
            Tooltip.SetDefault("An old piece of metal. Seems like the type of junk a merchant would sell.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.White;
        }
    }
}
