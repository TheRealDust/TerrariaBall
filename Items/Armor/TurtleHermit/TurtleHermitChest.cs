using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.TurtleHermit
{
    [AutoloadEquip(EquipType.Body)]
    public class TurtleHermitChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("5% Increased Ki Damage\n5% Increased Ki Crit Chance\nIncreased Ki Regen");
            DisplayName.SetDefault("Turtle Hermit Gi");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.Orange;
            item.defense = 8;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return ModContent.GetModItem(legs.type) is TurtleHermitLegs; // todo this needs testing
        }

        public override void UpdateArmorSet(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            player.setBonus = "+200 Max Ki";
            modPlayer.bonusMaxKi += 200;

            // player.GetModPlayer<TerrariaBallPlayer>().bonusMaxKi += 200;
            // player.setBonus = "+200 Max Ki";  
        }

        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.05f;
            modPlayer.kiCritrateMultiplier += 0.05f;
            modPlayer.kiRechargeRateMultiplier += 0.05f;

            // player.GetModPlayer<TerrariaBallPlayer>().kiDamageMultiplier += 0.05f;
            // player.GetModPlayer<TerrariaBallPlayer>().kiCritrateMultiplier += 0.05f;
            // player.GetModPlayer<TerrariaBallPlayer>().kiRechargeRateMultiplier += 0.05f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("EarthShard"), 12);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
