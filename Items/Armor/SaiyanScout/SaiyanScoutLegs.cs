using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.SaiyanScout
{
    [AutoloadEquip(EquipType.Legs)]
    public class SaiyanScoutLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("2% Increased Ki Damage\n2% Increased Ki Knockback\n6% Increased Movement Speed");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Green;
            item.defense = 4;
        }

        // public override bool IsArmorSet(Item head, Item body, Item legs)
        // {
        //     // return legs.type == mod.ItemType("SaiyanScoutPants");
        //     return ModContent.GetModItem(body.type) is SaiyanScoutChest; // todo this needs testing
        // }

        // public override void UpdateArmorSet(Player player)
        // {
        //     TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
        //     player.setBonus = "+100 Max Ki";
        //     modPlayer.bonusMaxKi += 100;
        // }

        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.02f;
            modPlayer.kiKnockbackMultipler += 0.02f;
            player.moveSpeed += 0.06f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 14);
            recipe.AddIngredient(ItemID.CopperBar, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 14);
            recipe.AddIngredient(ItemID.TinBar, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
