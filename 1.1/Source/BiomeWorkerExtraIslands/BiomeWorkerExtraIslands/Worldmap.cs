using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace BiomeWorkerExtraIslands
{
    [StaticConstructorOnStartup]
    public static class WorldMaterials
    {
        
        public static readonly Material Oasis;
        public static readonly Material TemperateIsland;
        public static readonly Material BorealIsland;
        public static readonly Material TundraIsland;
        public static readonly Material DesertIsland;
        static WorldMaterials()
        {
            Oasis = MaterialPool.MatFrom("World/MapGraphics/Oasis", ShaderDatabase.WorldOverlayTransparentLit, 3515);
            TemperateIsland = MaterialPool.MatFrom("World/MapGraphics/TemperateIsland", ShaderDatabase.WorldOverlayTransparentLit, 3505);
            BorealIsland = MaterialPool.MatFrom("World/MapGraphics/BorealIsland", ShaderDatabase.WorldOverlayTransparentLit, 3505);
            TundraIsland = MaterialPool.MatFrom("World/MapGraphics/TundraIsland", ShaderDatabase.WorldOverlayTransparentLit, 3505);
            DesertIsland = MaterialPool.MatFrom("World/MapGraphics/DesertIsland", ShaderDatabase.WorldOverlayTransparentLit, 3505);
        }
    }

    [DefOf]
    public static class BiomesExtraIslandsWorldMapGraphicClass
    {
        public static BiomeDef BiomesIslands_Oasis;
        public static BiomeDef BiomesIslands_BorealIsland;
        public static BiomeDef BiomesIslands_TemperateIsland;
        public static BiomeDef BiomesIslands_TundraIsland;
        public static BiomeDef BiomesIslands_DesertIsland;


        static BiomesExtraIslandsWorldMapGraphicClass()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(BiomesExtraIslandsWorldMapGraphicClass));
        }
    }

    public class BiomesOasisLakeMaker : WorldLayer
    {
        private static readonly IntVec2 TexturesInAtlas = new IntVec2(2, 2);

        public override IEnumerable Regenerate()
        {
            foreach (object obj in base.Regenerate())
            {
                yield return obj;
            }
            Rand.PushState();
            Rand.Seed = Find.World.info.Seed;
            WorldGrid worldGrid = Find.WorldGrid;
            for (int i = 0; i < worldGrid.TilesCount; i++)
            {
                if (worldGrid.tiles[i].biome != BiomesExtraIslandsWorldMapGraphicClass.BiomesIslands_Oasis)
                    continue;
                Material material = WorldMaterials.Oasis;
                LayerSubMesh subMesh = base.GetSubMesh(material);
                Vector3 vector = worldGrid.GetTileCenter(i);
                WorldRendererUtility.PrintQuadTangentialToPlanet(vector, vector, worldGrid.averageTileSize, 0.01f, subMesh, false, false, false);
                WorldRendererUtility.PrintTextureAtlasUVs(Rand.Range(0, TexturesInAtlas.x), Rand.Range(0, TexturesInAtlas.z), TexturesInAtlas.x, TexturesInAtlas.z, subMesh);
            }
            Rand.PopState();
            base.FinalizeMesh(MeshParts.All);
            yield break;
        }
    }

    public class BiomesTemperateIslandMaker : WorldLayer
    {
        private static readonly IntVec2 TexturesInAtlas = new IntVec2(2, 2);

        public override IEnumerable Regenerate()
        {
            foreach (object obj in base.Regenerate())
            {
                yield return obj;
            }
            Rand.PushState();
            Rand.Seed = Find.World.info.Seed;
            WorldGrid worldGrid = Find.WorldGrid;
            for (int i = 0; i < worldGrid.TilesCount; i++)
            {
                if (worldGrid.tiles[i].biome != BiomesExtraIslandsWorldMapGraphicClass.BiomesIslands_TemperateIsland)
                    continue;
                Material material = WorldMaterials.TemperateIsland;
                LayerSubMesh subMesh = base.GetSubMesh(material);
                Vector3 vector = worldGrid.GetTileCenter(i);
                WorldRendererUtility.PrintQuadTangentialToPlanet(vector, vector, worldGrid.averageTileSize, 0.01f, subMesh, false, false, false);
                WorldRendererUtility.PrintTextureAtlasUVs(Rand.Range(0, TexturesInAtlas.x), Rand.Range(0, TexturesInAtlas.z), TexturesInAtlas.x, TexturesInAtlas.z, subMesh);
            }
            Rand.PopState();
            base.FinalizeMesh(MeshParts.All);
            yield break;
        }
    }

    public class BiomesBorealIslandMaker : WorldLayer
    {
        private static readonly IntVec2 TexturesInAtlas = new IntVec2(2, 2);

        public override IEnumerable Regenerate()
        {
            foreach (object obj in base.Regenerate())
            {
                yield return obj;
            }
            Rand.PushState();
            Rand.Seed = Find.World.info.Seed;
            WorldGrid worldGrid = Find.WorldGrid;
            for (int i = 0; i < worldGrid.TilesCount; i++)
            {
                if (worldGrid.tiles[i].biome != BiomesExtraIslandsWorldMapGraphicClass.BiomesIslands_BorealIsland)
                    continue;
                Material material = WorldMaterials.BorealIsland;
                LayerSubMesh subMesh = base.GetSubMesh(material);
                Vector3 vector = worldGrid.GetTileCenter(i);
                WorldRendererUtility.PrintQuadTangentialToPlanet(vector, vector, worldGrid.averageTileSize, 0.01f, subMesh, false, false, false);
                WorldRendererUtility.PrintTextureAtlasUVs(Rand.Range(0, TexturesInAtlas.x), Rand.Range(0, TexturesInAtlas.z), TexturesInAtlas.x, TexturesInAtlas.z, subMesh);
            }
            Rand.PopState();
            base.FinalizeMesh(MeshParts.All);
            yield break;
        }
    }

    public class BiomesTundraIslandMaker : WorldLayer
    {
        private static readonly IntVec2 TexturesInAtlas = new IntVec2(2, 2);

        public override IEnumerable Regenerate()
        {
            foreach (object obj in base.Regenerate())
            {
                yield return obj;
            }
            Rand.PushState();
            Rand.Seed = Find.World.info.Seed;
            WorldGrid worldGrid = Find.WorldGrid;
            for (int i = 0; i < worldGrid.TilesCount; i++)
            {
                if (worldGrid.tiles[i].biome != BiomesExtraIslandsWorldMapGraphicClass.BiomesIslands_TundraIsland)
                    continue;
                Material material = WorldMaterials.TundraIsland;
                LayerSubMesh subMesh = base.GetSubMesh(material);
                Vector3 vector = worldGrid.GetTileCenter(i);
                WorldRendererUtility.PrintQuadTangentialToPlanet(vector, vector, worldGrid.averageTileSize, 0.01f, subMesh, false, false, false);
                WorldRendererUtility.PrintTextureAtlasUVs(Rand.Range(0, TexturesInAtlas.x), Rand.Range(0, TexturesInAtlas.z), TexturesInAtlas.x, TexturesInAtlas.z, subMesh);
            }
            Rand.PopState();
            base.FinalizeMesh(MeshParts.All);
            yield break;
        }
    }

    public class BiomesDesertIslandMaker : WorldLayer
    {
        private static readonly IntVec2 TexturesInAtlas = new IntVec2(2, 2);

        public override IEnumerable Regenerate()
        {
            foreach (object obj in base.Regenerate())
            {
                yield return obj;
            }
            Rand.PushState();
            Rand.Seed = Find.World.info.Seed;
            WorldGrid worldGrid = Find.WorldGrid;
            for (int i = 0; i < worldGrid.TilesCount; i++)
            {
                if (worldGrid.tiles[i].biome != BiomesExtraIslandsWorldMapGraphicClass.BiomesIslands_DesertIsland)
                    continue;
                Material material = WorldMaterials.DesertIsland;
                LayerSubMesh subMesh = base.GetSubMesh(material);
                Vector3 vector = worldGrid.GetTileCenter(i);
                WorldRendererUtility.PrintQuadTangentialToPlanet(vector, vector, worldGrid.averageTileSize, 0.01f, subMesh, false, false, false);
                WorldRendererUtility.PrintTextureAtlasUVs(Rand.Range(0, TexturesInAtlas.x), Rand.Range(0, TexturesInAtlas.z), TexturesInAtlas.x, TexturesInAtlas.z, subMesh);
            }
            Rand.PopState();
            base.FinalizeMesh(MeshParts.All);
            yield break;
        }
    }
}
