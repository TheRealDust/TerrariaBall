using Terraria;
using Terraria.UI;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TerrariaBall
{
    public class TerrariaBall : Mod
    {
        internal UI.KiBar kiBar;
        internal UserInterface userInterface;

        public override void Load()
        {
            // Register hotkeys
            TerrariaBallPlayer.ChargeKey = RegisterHotKey("Charge", "C");

            // Custom ui
            kiBar = new UI.KiBar();
            kiBar.Activate();
            userInterface = new UserInterface();
            userInterface.SetState(kiBar);
        }

        public override void UpdateUI(GameTime gameTime)
        {
            kiBar.Update(Main.player[Main.myPlayer].GetModPlayer<TerrariaBallPlayer>());
            userInterface.Update(gameTime);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            layers.Insert(layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text")), new LegacyGameInterfaceLayer("KiLevel", delegate
            {
                userInterface.Draw(Main.spriteBatch, new GameTime());
                return true;

            }, InterfaceScaleType.UI));
        }
    }
}