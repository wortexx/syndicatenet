/// <license>
/// Copyright (c) 2007-2008 Simon Wollwage
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

        #region Contructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="relatedSystem"></param>
        public NetMarking(Systems.NetSystem relatedSystem)
            : base(relatedSystem)
        {
        }
        #endregion

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
