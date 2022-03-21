using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaBall.Items.Armor.Saiyan
{
    [AutoloadEquip(EquipType.Body)]
    public class SaiyanChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("10% Increased Ki Damage\n6% Increased Ki Crit Chance\nIncreased Ki Regen");
            DisplayName.SetDefault("Saiyan Battle Armor");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 8001;
            item.rare = ItemRarityID.LightRed;
            item.defense = 12;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return ModContent.GetModItem(legs.type) is SaiyanLegs; // todo this needs testing
        }

        public override void UpdateArmorSet(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            player.setBonus = "+500 Max Ki";
            modPlayer.bonusMaxKi += 500;
            modPlayer.kiDrainMultiplier -= 0.08f;
        }

        public override void UpdateEquip(Player player)
        {
            TerrariaBallPlayer modPlayer = player.GetModPlayer<TerrariaBallPlayer>();
            modPlayer.kiDamageMultiplier += 0.1f;
            modPlayer.kiCritrateMultiplier += 0.06f;
            modPlayer.kiRechargeRateMultiplier += 0.08f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("SkeletalEssence"), 15);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
