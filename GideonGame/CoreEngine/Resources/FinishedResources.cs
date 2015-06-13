using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreEngine.Resources
{
    /// <summary>
    /// Represents a finsihed good, or something that Raw Resources are tunred into
    /// </summary>
    public class FinishedResources : BaseResource
    {
        /// <summary>
        /// the resources needed to build this object
        /// </summary>
        public List<RawResource> RequiredResources { get; set; }
    }
}
