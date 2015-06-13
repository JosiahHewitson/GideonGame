using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreEngine.Resources;
using CoreEngine.Common;
using CoreEngine.Improvements;

namespace CoreEngine.World
{
    public class Province
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public MapCoordinate Coordinates { get; set; }

        public TerrainType TerrainType { get; set; }
        public List<BaseResource> Resources { get; set; }
        public List<BaseImprovement> Improvements { get; set; }

        public int BaseMoveCost { get; set; }

    }
}
