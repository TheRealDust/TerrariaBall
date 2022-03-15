using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class EmptyNecklace : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Empty Necklace");
            Tooltip.SetDefault("Seems like you could attach a gem to this...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 100;
            item.rare = ItemRarityID.Orange;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("ScrapMetal"), 3);
            recipe.AddIngredient(ItemID.LeadBar, 5);
            recipe.AddTile(mod, "ZTable");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("ScrapMetal"), 3);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddTile(mod, "ZTable");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
