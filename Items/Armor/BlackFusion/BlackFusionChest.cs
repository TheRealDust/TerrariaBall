using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.BlackFusion
{
    [AutoloadEquip(EquipType.Body)]
    public class BlackFusionChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("24% Increased Ki Damage\n20% Increased Ki Crit Chance\n+15% Ki Charge Speed");
            DisplayName.SetDefault("Black Fusion Gi");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Cyan;
            item.defense = 24;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return ModContent.GetModItem(legs.type) is BlackFusionLegs; // todo this needs testing
        }

        public override void UpdateArmorSet(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            player.setBonus = "+1500 Max Ki";
            modPlayer.bonusMaxKi += 1500;
        }

        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.24f;
            modPlayer.kiCritrateMultiplier += 0.2f;
            modPlayer.kiRechargeRateMultiplier += 0.15f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("DivineThreads"), 20);
            recipe.AddTile(mod.GetTile("KaiTable"));
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
