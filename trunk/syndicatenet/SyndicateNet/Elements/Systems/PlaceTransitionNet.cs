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

namespace SyndicateNet.Elements.Systems
{
    /// <summary>
    /// 
    /// </summary>
    class PlaceTransitionNet : NetSystem
    {
        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private IDDistributor placeIDMaker = new IDDistributor();

        /// <summary>
        /// 
        /// </summary>
        private IDDistributor transitionIDMaker = new IDDistributor();

        /// <summary>
        /// 
        /// </summary>
        private IDDistributor arcIDMaker = new IDDistributor();
        #endregion

        #region Protected Members
        /// <summary>
        /// 
        /// </summary>
        protected List<Nodes.Place> places = new List<Nodes.Place>();

        /// <summary>
        /// 
        /// </summary>
        protected List<Nodes.Transition> transitions = new List<Nodes.Transition>();

        /// <summary>
        /// 
        /// </summary>
        protected List<Arcs.Arc> arcs = new List<Arcs.Arc>();

        /// <summary>
        /// 
        /// </summary>
        protected Dictionary<long, Nodes.Place> IDPlaceMap = new Dictionary<long, SyndicateNet.Elements.Nodes.Place>();

        /// <summary>
        /// 
        /// </summary>
        protected Marking.MarkingConstraint naturalMarkingConstraint = new SyndicateNet.Marking.MarkingConstraint();
        #endregion

        #region Protected Methods
        /// <summary>
        /// 
        /// </summary>
        protected void RenumberPlaces()
        {
            long ID = 0;
            IDPlaceMap.Clear();

            foreach (Nodes.Place place in places)
            {
                place.MarkingPlaceID = ID;
                IDPlaceMap[ID] = place;
                ++ID;
            }
            SystemChanged();
        }

        /// <summary>
        /// 
        /// </summary>
        protected void MakeMarkinConstraint()
        {
            /*if (naturalMarkingConstraint != 0)
                naturalMarkingConstraint = null;*/

            naturalMarkingConstraint = new Marking.MarkingConstraint(/*this*/);

            foreach (Nodes.Place place in places)
            {
                if (place.Capacity != 0)
                {
                    //naturalMarkingConstraint.SetUpperBound(place, place.Capacity);
                }
            }
        }
        #endregion

        #region Public Overloaded Methods
        /// <summary>
        /// 
        /// </summary>
        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nPlace"></param>
        /// <returns></returns>
        public long AddPlace(Nodes.Place nPlace)
        {
            places.Add(nPlace);
            RenumberPlaces();
            return placeIDMaker.NewID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Nodes.Place AddNewPlace()
        {
            Nodes.Place p = new SyndicateNet.Elements.Nodes.Place(this);
            return p;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Nodes.Place GetPlaceByMarkingID(long ID)
        {
            if (!IDPlaceMap.ContainsKey(ID))
            {
                throw new System.Exception("ID " + ID + " not in Map!");
            }

            return IDPlaceMap[ID];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldPlace"></param>
        public void RemovePlace(Nodes.Place oldPlace)
        {
            places.Remove(oldPlace);
            placeIDMaker.FreeID(oldPlace.PlaceID);
            RenumberPlaces();
        }
        #endregion
    }
}
