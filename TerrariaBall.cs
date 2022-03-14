using Terraria.ModLoader;

namespace TerrariaBall
{
    public class TerrariaBall : Mod
    {
        public override void Load()
        {
            // Register hotkeys
            TerrariaBallPlayer.ChargeKey = RegisterHotKey("Charge", "C");
        }
    }
}