using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.BlackFusion
{
    [AutoloadEquip(EquipType.Legs)]
    public class BlackFusionLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("20% Increased Ki Damage\n16% Increased Ki Crit Chance\n18% Increased Movement Speed");
            DisplayName.SetDefault("Demon Pants");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Cyan;
            item.defense = 16;
        }


        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.2f;
            modPlayer.kiCritrateMultiplier += 0.16f;

            /// Speed increased by 10%
            player.maxRunSpeed += 0.18f;
            player.accRunSpeed += 0.18f;
            player.runAcceleration += 0.18f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("DivineThreads"), 15);
            recipe.AddTile(mod.GetTile("KaiTable"));
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
