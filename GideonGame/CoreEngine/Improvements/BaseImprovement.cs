using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreEngine.Resources;
using CoreEngine.Common;

namespace CoreEngine.Improvements
{
    /// <summary>
    /// represents something that is built or modified on the terrain, so Roads, Mines, Citys, Factories, Etc.
    /// </summary>
    public class BaseImprovement
    {
        public string Name { get; set; }

        public List<TerrainType> PossibleTerrains { get; set; }

        public List<BaseResource> RequiredResourcesToRun { get; set; }
        public List<BaseResource> RequiredResourcesToBuild { get; set; }

    }
}
