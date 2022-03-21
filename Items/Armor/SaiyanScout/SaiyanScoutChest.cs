using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.SaiyanScout
{
    [AutoloadEquip(EquipType.Body)]
    public class SaiyanScoutChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("3% Increased Ki Damage\n2% Increased Ki Crit Chance\n5% Reduced Ki Usage");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Green;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            // return legs.type == mod.ItemType("SaiyanScoutLegs");
            return ModContent.GetModItem(legs.type) is SaiyanScoutLegs; // todo this needs testing
        }

        public override void UpdateArmorSet(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            player.setBonus = "+100 Max Ki";
            modPlayer.bonusMaxKi += 100;
        }

        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.03f;
            modPlayer.kiCritrateMultiplier += 0.02f;
            modPlayer.kiDrainMultiplier -= 0.05f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 18);
            recipe.AddIngredient(ItemID.CopperBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 18);
            recipe.AddIngredient(ItemID.TinBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
