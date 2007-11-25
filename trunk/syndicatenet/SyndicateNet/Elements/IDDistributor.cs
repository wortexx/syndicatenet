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
    class IDDistributor
    {
        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private List<long> recycled
            = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        private long firstFreeID = 0;
        #endregion

        #region Accessors
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The new ID</returns>
        public long NewID
        {
            get
            {
                long newID;
                if (recycled.Count == 0)
                    newID = firstFreeID++;
                else
                {
                    newID = recycled[0];
                    recycled.RemoveAt(0);
                }

                return newID;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        ///     
        /// </summary>
        /// <param name="id">
        ///     The ID to remove
        /// </param>
        public void FreeID(long id)
        {
            if (id >= firstFreeID)
            {
                // Exception
            }

            recycled.Add(id);
        }
        #endregion
    }
}
