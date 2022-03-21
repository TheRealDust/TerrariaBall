using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.TurtleHermit
{
    [AutoloadEquip(EquipType.Legs)]
    public class TurtleHermitLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("4% Increased Ki Damage\n4% Increased Ki Knockback\n10% Increased Movement Speed");
            DisplayName.SetDefault("Turtle Hermit Pants");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Orange;
            item.defense = 6;
        }


        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.04f;
            modPlayer.kiKnockbackMultipler += 0.04f;
            
            // player.GetModPlayer<TerrariaBallPlayer>().kiDamageMultiplier += 0.04f;
            // player.GetModPlayer<TerrariaBallPlayer>().kiKnockbackMultipler += 0.04f;

            /// Speed increased by 10%
            player.maxRunSpeed += 0.1f;
            player.accRunSpeed += 0.1f;
            player.runAcceleration += 0.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("EarthShard"), 10);
            recipe.AddIngredient(ItemID.Silk, 16);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
