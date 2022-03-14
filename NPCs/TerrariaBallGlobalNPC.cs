using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaBall.Items.Consumables.IncreaseMaxKi;

namespace TerrariaBall.NPCs
{
    public class TerrariaBallGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            // Ki Fragment Drops 
            {
                TerrariaBallPlayer player = Main.player[Main.myPlayer].GetModPlayer<TerrariaBallPlayer>();

                if (npc.type == KiFragLevel1.DropsFrom && !player.KiFragLevel1 && Main.rand.Next(KiFragLevel1.DropRate) == 0)
                {
                    npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("KiFragLevel1"), 1, true);
                }

                else if (npc.type == KiFragLevel2.DropsFrom && Main.rand.Next(KiFragLevel2.DropRate) == 0)
                {
                    npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("KiFragLevel2"), 1, true);
                }

                else if (npc.type == KiFragLevel3.DropsFrom && Main.rand.Next(KiFragLevel3.DropRate) == 0)
                {
                    npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("KiFragLevel3"), 1, true);
                }

                else if (npc.type == KiFragLevel4.DropsFrom && Main.rand.Next(KiFragLevel4.DropRate) == 0)
                {
                    npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("KiFragLevel4"), 1, true);
                }

                else if (npc.type == KiFragLevel5.DropsFrom && Main.rand.Next(KiFragLevel5.DropRate) == 0)
                {
                    npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("KiFragLevel5"), 1, true);
                }
            }
        }
    }
}
