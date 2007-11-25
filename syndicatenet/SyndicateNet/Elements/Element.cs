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
    abstract class Element
    {
        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private long elementID;
        #endregion

        #region Accessors
        /// <summary>
        /// 
        /// </summary>
        public long ElementID
        {
            get
            {
                return elementID;
            }
            set
            {
                elementID = value;
            }
        }
        #endregion

        #region Overloaded Public Methods
        /// <summary>
        /// 
        /// </summary>
        public abstract void Draw();
        #endregion
    }
}
