/// <license>
/// Copyright (c) 2007-2008 Simon Wollwage, Johannes Rössel
/// 
/// Permission is hereby granted, free of charge, to any person
/// obtaining a copy of this software and associated documentation
/// files (the "Software"), to deal in the Software without
/// restriction, including without limitation the rights to use,
/// copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the
/// Software is furnished to do so, subject to the following
/// conditions:
/// 
/// The above copyright notice and this permission notice shall be
/// included in all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
/// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
/// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
/// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
/// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
/// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
/// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
/// OTHER DEALINGS IN THE SOFTWARE.
/// </license>

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

        /// <summary>
        /// 
        /// </summary>
        public virtual void SystemChanged()
        {
        }
        #endregion
    }
}
