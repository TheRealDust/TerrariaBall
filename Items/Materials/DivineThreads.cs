using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class DivineThreads : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Divine Threads");
            Tooltip.SetDefault("A kind of fabric worn only by divine beings.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.Yellow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("PureKiCrystal"), 2);
            recipe.AddIngredient(ItemID.Ectoplasm, 1);
            recipe.AddIngredient(ItemID.Silk, 1);
            recipe.AddTile(mod, "ZTable");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
