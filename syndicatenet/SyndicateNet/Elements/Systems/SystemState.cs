using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicateNet.Elements.Systems
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    class SystemState
    {
        /// <summary>
        /// 
        /// </summary>
        protected Systems.NetSystem relatedSystem = null;

        /// <summary>
        /// 
        /// </summary>
        protected double relatedSystemVersion = 0.0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="relatedSystem">
        /// </param>
        public SystemState(NetSystem relatedSystem)
        {
            this.relatedSystem = relatedSystem;
            this.relatedSystemVersion = relatedSystem.SystemVersion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="relatedSystem">
        /// </param>
        /// <returns>
        /// </returns>
        public bool IsCompatible(Systems.NetSystem relatedSystem)
        {
            return ((relatedSystemVersion == relatedSystem.SystemVersion) &&
                (this.relatedSystem == relatedSystem));
        }
    }
}
