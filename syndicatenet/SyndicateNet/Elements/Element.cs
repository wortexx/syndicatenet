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
using System.Drawing;

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

        #region Protected Members
        /// <summary>
        /// 
        /// </summary>
        protected Systems.NetSystem housingSystem = null;
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

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Element()
        {
            housingSystem = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hSystem"></param>
        public Element(Systems.NetSystem hSystem)
        {
            housingSystem = hSystem;
            ElementID = housingSystem.AddElement(this);
        }
        #endregion

        #region Overloaded Public Methods
        /// <summary>
        /// 
        /// </summary>
        public abstract void Draw(Graphics g);
        #endregion
    }
}
