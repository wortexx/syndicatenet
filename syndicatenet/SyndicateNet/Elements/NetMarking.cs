using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicateNet.Elements
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    class NetMarking : Systems.SystemState
    {
        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private List<long> markingVector
            = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        private long numberOfPlaces;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="relatedSystem"></param>
        public NetMarking(Systems.NetSystem relatedSystem)
            : base(relatedSystem)
        {
        }

        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        private void Dest()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="marking">
        ///     The marking to copy from
        /// </param>
        private void Copy(NetMarking marking)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="marking">
        ///     The marking to check
        /// </param>
        private void CheckNetMarking(NetMarking marking)
        {
        }
        #endregion
    }
}
