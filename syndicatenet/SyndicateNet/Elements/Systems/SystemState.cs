﻿/// <license>
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
    class SystemState
    {
        #region Protected Members
        /// <summary>
        /// 
        /// </summary>
        protected Systems.NetSystem relatedSystem = null;

        /// <summary>
        /// 
        /// </summary>
        protected double relatedSystemVersion = 0.0;
        #endregion

        #region Constructors
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
        #endregion

        #region Public Methods
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
        #endregion
    }
}
