using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaBall.Items.Materials;
using TerrariaBall.Items.Materials.KiCrystals;
using TerrariaBall.Items.Consumables.IncreaseMaxKi;

namespace TerrariaBall.NPCs
{
    public class TerrariaBallGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            Player player = Main.player[Main.myPlayer];
            TerrariaBallPlayer modPlayer = Main.player[Main.myPlayer].GetModPlayer<TerrariaBallPlayer>();

            Func<int, int, int> DropItem = (int id, int count) => Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, id, count);
            Action<int> DropItemInstanced = (int id) => npc.DropItemInstanced(npc.position, npc.Size, id, 1, true);

            // Ki Fragment Drops 
            {
                if (npc.type == KiFragLevel1.DropsFrom && !modPlayer.KiFragLevel1 && Main.rand.Next(KiFragLevel1.DropRate) == 0)
                {
                    DropItemInstanced(mod.ItemType("KiFragLevel1"));
                }

                else if (npc.type == KiFragLevel2.DropsFrom && !modPlayer.KiFragLevel2 && Main.rand.Next(KiFragLevel2.DropRate) == 0)
                {
                    DropItemInstanced(mod.ItemType("KiFragLevel2"));
                }

                else if (npc.type == KiFragLevel3.DropsFrom && !modPlayer.KiFragLevel3 && Main.rand.Next(KiFragLevel3.DropRate) == 0)
                {
                    DropItemInstanced(mod.ItemType("KiFragLevel3"));
                }

                else if (npc.type == KiFragLevel4.DropsFrom && !modPlayer.KiFragLevel4 && Main.rand.Next(KiFragLevel4.DropRate) == 0)
                {
                    DropItemInstanced(mod.ItemType("KiFragLevel4"));
                }

                else if (npc.type == KiFragLevel5.DropsFrom && !modPlayer.KiFragLevel5 && Main.rand.Next(KiFragLevel5.DropRate) == 0)
                {
                    DropItemInstanced(mod.ItemType("KiFragLevel5"));
                }
            }

            // Ki Crystal Drops
            {
                if (NPC.downedBoss2 && player.ZoneOverworldHeight && player.ZoneJungle && Main.rand.Next(CalmKiCrystal.DropRate) == 0)
                {
                    DropItem(mod.ItemType("CalmKiCrystal"), Main.rand.Next(1, CalmKiCrystal.MaxDrop));
                }

                else if (NPC.downedBoss3 && player.ZoneUnderworldHeight && Main.rand.Next(PridefulKiCrystal.DropRate) == 0)
                {
                    DropItem(mod.ItemType("PridefulKiCrystal"), Main.rand.Next(1, PridefulKiCrystal.MaxDrop));
                }

                else if (Main.hardMode && (player.ZoneCorrupt || player.ZoneCrimson) && Main.rand.Next(RagingKiCrystal.DropRate) == 0)
                {
                    DropItem(mod.ItemType("RagingKiCrystal"), Main.rand.Next(1, RagingKiCrystal.MaxDrop));
                }

                else if (Main.hardMode && NPC.downedPlantBoss && player.ZoneGlowshroom && Main.rand.Next(PureKiCrystal.DropRate) == 0)
                {
                    DropItem(mod.ItemType("PureKiCrystal"), Main.rand.Next(1, PureKiCrystal.MaxDrop));
                }

                else if (player.ZoneOverworldHeight && Main.rand.Next(StableKiCrystal.DropRate) == 0)
                {
                    DropItem(mod.ItemType("StableKiCrystal"), Main.rand.Next(1, StableKiCrystal.MaxDrop));
                }
            }

            // Earth shard
            if (NPC.downedBoss2 && Main.rand.Next(EarthShard.DropRate) == 0)
            {
                DropItem(mod.ItemType("EarthShard"), Main.rand.Next(1, EarthShard.MaxDrop));
            }

            // Astral Essentia
            if (NPC.downedQueenBee && npc.type == NPCID.Harpy && Main.rand.Next(AstralEssentia.DropRate) == 0)
            {
                DropItem(mod.ItemType("AstralEssentia"), Main.rand.Next(1, AstralEssentia.MaxDrop));
            }

            // Skeletal Essence
            if (player.ZoneDungeon && Main.rand.Next(SkeletalEssence.DropRate) == 0)
            {
                DropItem(mod.ItemType("SkeletalEssence"), Main.rand.Next(1, SkeletalEssence.MaxDrop));
            }

            // Possessed Soul
            if (NPC.downedMechBoss1 && NPC.downedBoss2 && NPC.downedBoss3 && npc.type == NPCID.PossessedArmor && npc.type == NPCID.EnchantedSword && npc.type == NPCID.CrimsonAxe && npc.type == NPCID.CursedHammer && Main.rand.Next(PossessedSoul.DropRate) == 0)
            {
                DropItem(mod.ItemType("PossessedSoul"), Main.rand.Next(1, PossessedSoul.MaxDrop));
            }

            // Demonic Soul
            if (NPC.downedGolemBoss && npc.type == NPCID.Demon && Main.rand.Next(DemonicSoul.DropRate) == 0)
            {
                DropItem(mod.ItemType("DemonicSoul"), Main.rand.Next(1, DemonicSoul.MaxDrop));
            }
        }
    }
}
