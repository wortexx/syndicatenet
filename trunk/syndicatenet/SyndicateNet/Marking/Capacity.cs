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

namespace SyndicateNet.Marking
{
    /// <summary>
    /// 
    /// </summary>
    class Capacity
    {
        #region Private Members
        /// <summary>
        /// 
        /// </summary>
        private long capacity;
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Capacity()
        {
            capacity = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap"></param>
        public Capacity(long cap)
        {
            capacity = cap;
        }
        #endregion

        #region Operators
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator<(Capacity cap1, Capacity cap2)
        {
            if (cap1.capacity == 0)
                return false;
            else
            {
                if (cap2.capacity == 0)
                    return true;
                else
                    return (cap1.capacity < cap2.capacity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator <(Capacity cap1, long cap2)
        {
            if (cap1.capacity == 0)
                return false;
            else
            {
                if (cap2 == 0)
                    return true;
                else
                    return (cap1.capacity < cap2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator <(long cap1, Capacity cap2)
        {
            if (cap1 == 0)
                return false;
            else
            {
                if (cap2.capacity == 0)
                    return true;
                else
                    return (cap1 < cap2.capacity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator <=(Capacity cap1, Capacity cap2)
        {
            if (cap2.capacity == 0)
                return true;
            else
            {
                if (cap1.capacity == 0)
                    return false;
                else
                    return (cap1.capacity <= cap2.capacity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator >(Capacity cap1, Capacity cap2)
        {
            if (cap2.capacity == 0)
                return false;
            else
            {
                if (cap1.capacity == 0)
                    return true;
                else
                    return (cap1.capacity > cap2.capacity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator >(long cap1, Capacity cap2)
        {
            if (cap2.capacity == 0)
                return false;
            else
            {
                if (cap1 == 0)
                    return true;
                else
                    return (cap1 > cap2.capacity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator >(Capacity cap1, long cap2)
        {
            if (cap2 == 0)
                return false;
            else
            {
                if (cap1.capacity == 0)
                    return true;
                else
                    return (cap1.capacity > cap2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator >=(Capacity cap1, Capacity cap2)
        {
            if (cap1.capacity == 0)
                return true;
            else
            {
                if (cap2.capacity == 0)
                    return false;
                else
                    return (cap1.capacity >= cap2.capacity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator !=(Capacity cap1, Capacity cap2)
        {
            return (cap1.capacity != cap2.capacity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator !=(long cap1, Capacity cap2)
        {
            return (cap1 != cap2.capacity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator !=(Capacity cap1, long cap2)
        {
            return (cap1.capacity != cap2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator ==(Capacity cap1, Capacity cap2)
        {
            return (cap1.capacity == cap2.capacity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator ==(long cap1, Capacity cap2)
        {
            return (cap1 == cap2.capacity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cap1"></param>
        /// <param name="cap2"></param>
        /// <returns></returns>
        public static bool operator ==(Capacity cap1, long cap2)
        {
            return (cap1.capacity == cap2);
        }
        #endregion
    }
}
