using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreEngine.Common;

namespace CoreEngine.World
{
    public class WorldGenerator
    {
        Random _random = new Random();

        #region Properties 


        public int TotalProvinces { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        #endregion

        #region Public Methods

        public List<Province> GenerateWorld()
        {
            List<Province> provinces = new List<Province>();

            for (int y = 0; y <= Height; y++)
            {
                for (int x = 0; x <= Width; x++)
                {
                    Province newProvince = new Province();

                    //TODO: set things here
                    SetTerrainType(newProvince);

                    provinces.Add(newProvince);
                }
            }

            return provinces;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// This guy needs to be cleaned up to look at neighbors.  Consider a light map with mountains?
        /// </summary>
        /// <param name="newProvince"></param>
        private void SetTerrainType(Province newProvince)
        {
            //TODO:  Check Neighbors

            int seed = _random.Next(100);

            if (seed < 10)
            {
                newProvince.TerrainType = TerrainType.Coast;
            }
            else if (seed < 30)
            {
                newProvince.TerrainType = TerrainType.Hill;
            }
            else if (seed < 40)
            {
                newProvince.TerrainType = TerrainType.Lake;
            }
            else if (seed < 50)
            {
                newProvince.TerrainType = TerrainType.Mountain;
            }
            else if (seed < 60)
            {
                newProvince.TerrainType = TerrainType.Ocean;
            }
            else if (seed < 70)
            {
                newProvince.TerrainType = TerrainType.Plain;
            }
            else if (seed < 80)
            {
                newProvince.TerrainType = TerrainType.Swamp;
            }
            else if (seed < 100)
            {
                newProvince.TerrainType = TerrainType.Grassland;
            }
        }

        #endregion
    }
}
