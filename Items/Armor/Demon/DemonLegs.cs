using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.Demon
{
    [AutoloadEquip(EquipType.Legs)]
    public class DemonLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("12% Increased Ki Damage\n10% Increased Ki Crit Chance\n16% Increased Movement Speed");
            DisplayName.SetDefault("Demon Pants");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.LightRed;
            item.defense = 12;
        }


        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.12f;
            modPlayer.kiCritrateMultiplier += 0.10f;

            /// Speed increased by 10%
            player.maxRunSpeed += 0.16f;
            player.accRunSpeed += 0.16f;
            player.runAcceleration += 0.16f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("DemonCloth"), 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
