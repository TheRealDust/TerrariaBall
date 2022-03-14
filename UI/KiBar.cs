using Terraria.UI;
using Terraria.GameContent.UI.Elements;


namespace TerrariaBall.UI
{
    internal class KiBar : UIState
    {
        public UIText bar;

        public override void OnInitialize()
        {
            bar = new UIText("0/0");
            Append(bar);
        }

        public void Update(TerrariaBallPlayer player)
        {
            bar.SetText($"{player.currentKi}/{player.maxKi}");
        }
    }
}
