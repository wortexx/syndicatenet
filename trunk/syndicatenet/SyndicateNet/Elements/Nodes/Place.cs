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

namespace SyndicateNet.Elements.Nodes
{
    /// <summary>
    /// 
    /// </summary>
    class Place : Node
    {
        #region Protected Members
        /// <summary>
        /// 
        /// </summary>
        protected Marking.Capacity capacity = new SyndicateNet.Marking.Capacity();

        /// <summary>
        /// 
        /// </summary>
        protected long placeID;

        /// <summary>
        /// 
        /// </summary>
        protected long markingPlaceID;

        /// <summary>
        /// 
        /// </summary>
        protected long marking;
        #endregion

        #region Accessors
        /// <summary>
        /// 
        /// </summary>
        public Marking.Capacity Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long MarkingPlaceID
        {
            get
            {
                return markingPlaceID;
            }
            set
            {
                markingPlaceID = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long Marking
        {
            get
            {
                return marking;
            }
            set
            {
                marking = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long PlaceID
        {
            get
            {
                return placeID;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="housingSystem"></param>
        public Place(Systems.PlaceTransitionNet housingSystem)
            : base((Systems.NetSystem)housingSystem)
        {
            Type = Nodes.Node.NodeType.PLACE;
            Marking = 0;
            Capacity = new Marking.Capacity(1);
            placeID = housingSystem.AddElement(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="housingSystem"></param>
        /// <param name="cap"></param>
        public Place(Systems.PlaceTransitionNet housingSystem, Marking.Capacity cap)
            : base((Systems.NetSystem)housingSystem)
        {
            Type = Nodes.Node.NodeType.PLACE;
            Marking = 0;
            Capacity = cap;
            placeID = housingSystem.AddElement(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="housingSystem"></param>
        /// <param name="cap"></param>
        public Place(Systems.PlaceTransitionNet housingSystem, long cap)
            : base((Systems.NetSystem)housingSystem)
        {
            Type = Nodes.Node.NodeType.PLACE;
            Marking = 0;
            Capacity = new Marking.Capacity(cap);
            placeID = housingSystem.AddElement(this);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dMarking"></param>
        public void AddToMarking(long dMarking)
        {
            if (Marking + dMarking > Capacity)
            {
                throw new System.Exception();
            }
            Marking += dMarking;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dMarking"></param>
        public void SubFromMarking(long dMarking)
        {
            if (Marking >= dMarking)
                Marking -= dMarking;
            else
                Marking = 0;
        }
        #endregion

        #region Public Overloaded Methods
        /// <summary>
        /// 
        /// </summary>
        public override void Draw()
        {
            base.Draw();
        }
        #endregion
    }
}
