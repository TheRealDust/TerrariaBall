using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Materials
{
    public class DemonCloth : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demon Cloth");
            Tooltip.SetDefault("A kind of fabric produced only by demonic beings.");
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
            recipe.AddIngredient(mod.GetItem("RagingKiCrystal"), 2);
            recipe.AddIngredient(ItemID.SoulofFright, 1);
            recipe.AddIngredient(ItemID.SoulofMight, 1);
            recipe.AddIngredient(ItemID.SoulofFright, 1);
            recipe.AddTile(mod, "ZTable");
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}
