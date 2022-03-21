using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.Demon
{
    [AutoloadEquip(EquipType.Body)]
    public class DemonChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("18% Increased Ki Damage\n15% Increased Ki Crit Chance\nIncreased Ki Regen");
            DisplayName.SetDefault("Demon Gi");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Cyan;
            item.defense = 20;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return ModContent.GetModItem(legs.type) is DemonLegs; // todo this needs testing
        }

        public override void UpdateArmorSet(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            player.setBonus = "+1000 Max Ki";
            modPlayer.bonusMaxKi += 1000;

            // player.GetModPlayer<TerrariaBallPlayer>().bonusMaxKi += 200;
            // player.setBonus = "+200 Max Ki";  
        }

        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.18f;
            modPlayer.kiCritrateMultiplier += 0.15f;
            modPlayer.kiRechargeRateMultiplier += 0.1f;

            // player.GetModPlayer<TerrariaBallPlayer>().kiDamageMultiplier += 0.05f;
            // player.GetModPlayer<TerrariaBallPlayer>().kiCritrateMultiplier += 0.05f;
            // player.GetModPlayer<TerrariaBallPlayer>().kiRechargeRateMultiplier += 0.05f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("DemonCloth"), 16);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
