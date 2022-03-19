using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Placeable.Furniture
{
    public class KaiTableItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kai Table");
            Tooltip.SetDefault("The workbench of the gods.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 26;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = ItemRarityID.Lime;
            item.value = 120000;
            item.createTile = mod.TileType("KaiTable");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("ZTableItem"), 1);
            recipe.AddIngredient(mod.GetItem("PureKiCrystal"), 15);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
            recipe.AddIngredient(ItemID.Pearlwood, 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}