using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreEngine.Resources
{
    /// <summary>
    /// The Base Resource Class.  represents anything that can be produced or consumend
    /// </summary>
    public class BaseResource
    {
        public string Name { get; set; }

        public bool Replenishable { get; set; }

        public int TotalAmount { get; set; }
        public int RemainingAmount { get; set; }
        public int BaseProductionPerTurn { get; set; }
    }
}
