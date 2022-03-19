using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Placeable.Furniture
{
    public class ZTableItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Z-Table");
            Tooltip.SetDefault("A workbench specifically for ki-based crafting and processing.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 26;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = false;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = ItemRarityID.Green;
            item.value = 3000;
            item.createTile = mod.TileType("ZTable");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("ScrapMetal"), 15);
            recipe.AddIngredient(mod.GetItem("StableKiCrystal"), 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}