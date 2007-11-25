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
