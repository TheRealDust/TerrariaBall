using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class SkeletalEssence : ModItem 
    {
        public static int DropRate = 5;
        public static int MaxDrop = 3;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skeletal Essence");
            Tooltip.SetDefault("A chunk of the undead residing in that accursed dungeon.");
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
