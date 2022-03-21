using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.SaiyanElite
{
    [AutoloadEquip(EquipType.Legs)]
    public class SaiyanEliteLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("22% Increased Ki Damage\n18% Increased Ki Crit Chance\n20% Increased Movement Speed");
            DisplayName.SetDefault("Elite Saiyan Pants");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Cyan;
            item.defense = 15;
        }


        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.22f;
            modPlayer.kiCritrateMultiplier += 0.18f;

            /// Speed increased by 10%
            player.maxRunSpeed += 0.2f;
            player.accRunSpeed += 0.2f;
            player.runAcceleration += 0.2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("SaiyanLegs"), 1);
            recipe.AddIngredient(mod.GetItem("KatchinScale"), 12);
            recipe.AddTile(mod.GetTile("KaiTable"));
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
