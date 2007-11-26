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

namespace SyndicateNet.Elements.Arcs
{
    /// <summary>
    /// 
    /// </summary>
    class EventArc : Arc
    {
        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private bool allowsFiring = false;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromNode"></param>
        /// <param name="toNode"></param>
        /// <param name="housingSystem"></param>
        public EventArc(Nodes.Node fromNode, Nodes.Node toNode, Systems.PlaceTransitionNet housingSystem)
            : base(fromNode, toNode, housingSystem)
        {
            allowsFiring = false;
        }

        #region Public Overloaded Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="blockedNode"></param>
        /// <returns></returns>
        public override bool Blocks(SyndicateNet.Elements.Nodes.Node blockedNode)
        {
            if (blockedNode == ToNode)
            {
                return !allowsFiring;
            }
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="causingNode"></param>
        public override void Execute(SyndicateNet.Elements.Nodes.Node causingNode)
        {
            if (causingNode == FromNode)
            {
                allowsFiring = true;
                // todo
                allowsFiring = false;
            }
        }
        #endregion

        #region Protected Overloaded Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override bool IsAllowed()
        {
            /// Eventarcs connect 2 transitions, so check for it here
            if ((FromNode.Type != Nodes.Node.NodeType.TRANSITION) ||
                (ToNode.Type != Nodes.Node.NodeType.TRANSITION))
                return false;

            /// Prevent circularities
            if (ExistsEventArcPath(ToNode, FromNode))
                return false;

            foreach (Arc arc in ToNode.IncidentArcs)
            {
                if (arc.GetType() == this.GetType() && arc.ToNode == ToNode)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void SortNodes()
        {
            base.SortNodes();
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="startNode"></param>
        /// <param name="targetNode"></param>
        /// <returns></returns>
        protected bool ExistsEventArcPath(Nodes.Node startNode, Nodes.Node targetNode)
        {
            if (startNode == targetNode)
                return true;

            foreach (Arc arc in targetNode.IncidentArcs)
            {
                if (arc.GetType() == this.GetType())
                {
                    if (ExistsEventArcPath(arc.ToNode, targetNode))
                        return true;
                }
            }

            return false;
        }
        #endregion
    }
}
