using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using RimWorld.Planet;
using UnityEngine;
using Verse;
using Verse.Noise;

namespace BiomeWorkerExtraIslands
{
    public class IslandsValues : BiomeWorker
    {

        public static ModuleBase PerlinNoise = null;
        public const int MEAN_ELEVATION = 50;
        public float LOW_DEPTH_BONUS = 0.35F;
        public float HIGH_DEPTH_PENALTY = 0.5F;
        private static string Genius;
        public string ODEUM = Genius;

        public override float GetScore(Tile tile, int tileID)
        {
            throw new NotImplementedException();
        }
    }

        public class BiomeWorker_TemperateIsland : IslandsValues
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (!tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature > 20f || tile.temperature < 5f || tile.elevation < -400f || tile.elevation > -40f || tile.rainfall < 600f || Rand.Value < 0.97)
            {
                return 0f;
            }
            if (PerlinNoise == null)
            { // if we have never come across it yet, initialise it
                PerlinNoise = new Perlin(0.1, 10, 0.6, 12, Find.World.info.Seed, QualityMode.Low);
            }
            float PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID));
            if (tile.elevation > -200)
            {
                PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID)) + LOW_DEPTH_BONUS;
            }
            if (tile.elevation < -300)
            {
                PerlinNoiseValue = ((PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID)) * 0.5f) - HIGH_DEPTH_PENALTY);
            }
            if (PerlinNoiseValue < 0.55f)
            {
                return 0f;
            }
            return ((MEAN_ELEVATION + tile.elevation) + ( 0.5f *(Mathf.Pow((2.5f + PerlinNoiseValue), 5))));
        }
    }




    public class BiomeWorker_BorealIsland : IslandsValues
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (!tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature > 5f || tile.temperature < -10f || tile.elevation < -500f || tile.elevation > -40f || tile.rainfall < 600f || Rand.Value < 0.97)
            {
                return 0f;
            }

            if (PerlinNoise == null)
            { // if we have never come across it yet, initialise it
                PerlinNoise = new Perlin(0.1, 10, 0.6, 12, Find.World.info.Seed, QualityMode.Low);
            }
            float PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID));
            if (tile.elevation > -200)
            {
                PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID)) + LOW_DEPTH_BONUS;
            }
            if (tile.elevation < -300)
            {
                PerlinNoiseValue = ((PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID)) * 0.5f) - HIGH_DEPTH_PENALTY);
            }
            if (PerlinNoiseValue < 0.55f)
            {
                return 0f;
            }
            return ((MEAN_ELEVATION + tile.elevation) + ( 0.5f *(Mathf.Pow((2.5f + PerlinNoiseValue), 5))));
        }
    }




    public class BiomeWorker_TundraIsland : IslandsValues
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (!tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature > 0f || tile.temperature < -20f || tile.elevation < -500f || tile.elevation > -40f || tile.rainfall > 600f || Rand.Value < 0.97)
            {
                return 0f;
            }

            if (PerlinNoise == null)
            { // if we have never come across it yet, initialise it
                PerlinNoise = new Perlin(0.1, 10, 0.6, 12, Find.World.info.Seed, QualityMode.Low);
            }
            float PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID));
            if (tile.elevation > -200)
            {
                PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID)) + LOW_DEPTH_BONUS;
            }
            if (tile.elevation < -300)
            {
                PerlinNoiseValue = ((PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID)) * 0.5f) - HIGH_DEPTH_PENALTY);
            }
            if (PerlinNoiseValue < 0.55f)
            {
                return 0f;
            }
            return ((MEAN_ELEVATION + tile.elevation) + ( 0.5f *(Mathf.Pow((2.5f + PerlinNoiseValue), 5))));
        }
    }




    public class BiomeWorker_DesertIsland : IslandsValues
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (!tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature > 40f || tile.temperature < 0f || tile.elevation < -500f || tile.elevation > -100f || tile.rainfall > 600f || Rand.Value < 0.97)
            {
                return 0f;
            }

            if (PerlinNoise == null)
            { // if we have never come across it yet, initialise it
                PerlinNoise = new Perlin(0.1, 10, 0.6, 12, Find.World.info.Seed, QualityMode.Low);
            }
            float PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID));
            if (tile.elevation > -200)
            {
                PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID)) + LOW_DEPTH_BONUS;
            }
            if (tile.elevation < -300)
            {
                PerlinNoiseValue = ((PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID)) * 0.5f) - HIGH_DEPTH_PENALTY);
            }
            if (PerlinNoiseValue < 0.55f)
            {
                return 0f;
            }
            return ((MEAN_ELEVATION + tile.elevation) + ( 0.5f *(Mathf.Pow((2.5f + PerlinNoiseValue), 5))));
        }
    }




    public class BiomeWorker_Oasis : IslandsValues
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature > 40f || tile.temperature < 0f || tile.elevation < 50f || tile.elevation > 200f || tile.rainfall > 600f || Rand.Value < 0.97)
            {
                return 0f;
            }

            if (PerlinNoise == null)
            { // if we have never come across it yet, initialise it
                PerlinNoise = new Perlin(0.1, 10, 0.6, 12, Find.World.info.Seed, QualityMode.Low);
            }
            float PerlinNoiseValue = PerlinNoise.GetValue(Find.WorldGrid.GetTileCenter(tileID));
            if (PerlinNoiseValue < 0.6f)
            {
                return 0f;
            }
            return ((MEAN_ELEVATION + tile.elevation) + (Mathf.Pow((2.5f + PerlinNoiseValue), 5)));
        }


    }


}
