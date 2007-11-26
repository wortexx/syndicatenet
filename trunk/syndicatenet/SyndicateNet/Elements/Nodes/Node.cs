using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyndicateNet.Elements.Nodes
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    class Node : Element
    {
        #region Enums
        /// <summary>
        /// 
        /// </summary>
        public enum NodeType
        {
            PLACE,
            TRANSITION,
        }
        #endregion

        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private long nodeID;
        #endregion

        #region Protected Members
        /// <summary>
        /// 
        /// </summary>
        protected NodeType nodeType;

        /// <summary>
        /// 
        /// </summary>
        protected List<Elements.Arcs.Arc> incidentArcs 
            = new List<Elements.Arcs.Arc>();

        /// <summary>
        /// 
        /// </summary>
        protected bool observable = false;

        /// <summary>
        /// 
        /// </summary>
        protected bool controllable = false;
        #endregion

        #region Accessors
        /// <summary>
        /// 
        /// </summary>
        public NodeType Type
        {
            get
            {
                return nodeType;
            }
            set
            {
                nodeType = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long NodeID
        {
            get
            {
                return nodeID;
            }
            set
            {
                nodeID = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsObservable
        {
            get
            {
                return observable;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsControllable
        {
            get
            {
                return controllable;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Elements.Arcs.Arc> IncidentArcs
        {
            get
            {
                return incidentArcs;
            }
        }
        #endregion

        #region Constructors
        public Node(Systems.NetSystem housingSystem)
            : base(housingSystem)
        {
            if (observable || controllable)
                housingSystem.AddElement(this);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newArc">
        ///     The Arc to add
        /// </param>
        public void AddArc(Elements.Arcs.Arc newArc)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldArc">
        ///     The Arc to remove
        /// </param>
        public void RemoveArc(Elements.Arcs.Arc oldArc)
        {
        }
        #endregion

        #region Overloaded Methods
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
