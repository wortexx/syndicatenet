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

namespace SyndicateNet.Elements.Arcs
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    class Arc : Element
    {
        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private long arcID;
        #endregion

        #region Protected Members
        /// <summary>
        /// 
        /// </summary>
        Elements.Nodes.Node fromNode = null;

        /// <summary>
        /// 
        /// </summary>
        Elements.Nodes.Node toNode = null;
        #endregion

        #region Accessors
        /// <summary>
        /// 
        /// </summary>
        public Elements.Nodes.Node FromNode
        {
            get
            {
                return fromNode;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Elements.Nodes.Node ToNode
        {
            get
            {
                return toNode;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long ArcID
        {
            get
            {
                return arcID;
            }
        }
        #endregion

        #region Virtual Protected Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsAllowed()
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void SortNodes()
        {
        }
        #endregion

        #region Virtual Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="blockedNode">
        ///     The node to check if it is blocked by the Arc
        /// </param>
        /// <returns>
        ///     True if so
        /// </returns>
        public virtual bool Blocks(Elements.Nodes.Node blockedNode)
        {
            return false;
        }

        //public virtual bool Blocks(Elements.Nodes.Node blockedNode, NetMarking usedMarking)
        //{
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="causingNode">
        ///     The node that causes the execution
        /// </param>
        public virtual void Execute(Elements.Nodes.Node causingNode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Draw()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
