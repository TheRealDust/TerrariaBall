using Terraria.GameInput;
using Terraria.ModLoader;

namespace TerrariaBall
{
    public partial class TerrariaBallPlayer : ModPlayer
    {
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            ProcessCharge();
        }
    }
}
