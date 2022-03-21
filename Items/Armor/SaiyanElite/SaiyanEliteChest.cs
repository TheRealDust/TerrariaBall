using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.SaiyanElite
{
    [AutoloadEquip(EquipType.Body)]
    public class SaiyanEliteChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Armor worn by only the elite class of the Saiyan race.\n26% Increased Ki Damage\n24% Increased Ki Crit Chance\n+20% Ki Charge Speed");
            DisplayName.SetDefault("Saiyan Elite Armor");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Cyan;
            item.defense = 25;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return ModContent.GetModItem(legs.type) is SaiyanEliteLegs; // todo this needs testing
        }

        public override void UpdateArmorSet(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            player.setBonus = "+1750 Max Ki";
            modPlayer.bonusMaxKi += 1750;
        }

        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.26f;
            modPlayer.kiCritrateMultiplier += 0.24f;
            modPlayer.kiRechargeRateMultiplier += 0.2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("SaiyanChest"), 1);
            recipe.AddIngredient(mod.GetItem("KatchinScale"), 16);
            recipe.AddTile(mod.GetTile("KaiTable"));
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
