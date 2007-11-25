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
    abstract class NetSystem : Elements.Element
    {
        #region Enums
        /// <summary>
        /// 
        /// </summary>
        public enum SystemType
        {
            NOSYSTEM,
            PLACETRANSITIONNET,
            COMPOSITESYSTEM,
            CONTINUOUSSYSTEM,
        }
        #endregion

        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private System.Collections.Generic.List<Elements.Element> includedElements
            = new List<SyndicateNet.Elements.Element>();

        /// <summary>
        /// 
        /// </summary>
        private Elements.IDDistributor elementIDMaker = new Elements.IDDistributor();

        /// <summary>
        /// 
        /// </summary>
        private double systemVersion = 0.0;
        #endregion

        #region Protected Members
        /// <summary>
        /// 
        /// </summary>
        protected SystemType systemType = SystemType.NOSYSTEM;
        #endregion

        #region Accessors
        /// <summary>
        /// 
        /// </summary>
        public double SystemVersion
        {
            get
            {
                return systemVersion;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newElement">
        ///     The element to add
        /// </param>
        /// <returns>
        ///     The added element's ID
        /// </returns>
        public long AddElement(Elements.Element newElement)
        {
            if (includedElements.Contains(newElement))
            {
            }
            includedElements.Add(newElement);
            return elementIDMaker.NewID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldElement">
        ///     The Element to remove
        /// </param>
        public void RemoveElement(Elements.Element oldElement)
        {
            includedElements.Remove(oldElement);
            elementIDMaker.FreeID(oldElement.ElementID);
        }
        #endregion
    }
}
