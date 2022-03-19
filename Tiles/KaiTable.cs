using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

namespace TerrariaBall.Tiles
{
    public class KaiTable : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newTile.Origin = new Point16(1, 0);
            TileObjectData.newTile.CoordinatePadding = 2;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("KaiTable");
            AddMapEntry(new Color(223, 245, 255), name);
            disableSmartCursor = true;
            adjTiles = new int[] { mod.TileType("ZTable") };
            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY) 
        {
			Item.NewItem(new Vector2(x * 16, y * 16), 32, 16, ModContent.ItemType<Items.Placeable.Furniture.KaiTableItem>());
		}
    }
}