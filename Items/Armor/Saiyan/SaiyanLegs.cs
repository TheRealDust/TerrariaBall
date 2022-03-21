using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.Saiyan
{
    [AutoloadEquip(EquipType.Legs)]
    public class SaiyanLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("7% Increased Ki Damage\n5% Increased Ki Crit Chance\n16% Increased Movement Speed");
            DisplayName.SetDefault("Saiyan Battle Pants");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.LightRed;
            item.defense = 10;
        }


        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.07f;
            modPlayer.kiCritrateMultiplier += 0.05f;

            /// Speed increased by 10%
            player.maxRunSpeed += 0.16f;
            player.accRunSpeed += 0.16f;
            player.runAcceleration += 0.16f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("SkeletalEssence"), 10);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
