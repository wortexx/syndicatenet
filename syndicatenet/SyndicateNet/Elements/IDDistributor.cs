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
