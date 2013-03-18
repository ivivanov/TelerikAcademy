/*
* Define a class BitArray64 to hold 64 bit values inside an ulong value. 
* Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        #region Fields
        
        private ulong bits;
        
        #endregion
        
        #region Constructors
        
        public BitArray64(ulong bits = 0)
        {
            this.bits = bits;
        }
        
        #endregion
        
        #region Properties
        
        public ulong Bits
        {
            get
            {
                return this.bits;
            }
            set
            {
                this.bits = value;
            }
        }
        
        public byte this[byte i]
        {
            get 
            {
                if (i < 0 || i > 63)
                {
                    throw new IndexOutOfRangeException("Index interval: [0,63]");
                }
                return (byte)(((this.bits >> i) & 1) == 1 ? 1 : 0);
            }
            set
            {
                if (i < 0 || i > 63)
                {
                    throw new IndexOutOfRangeException("Index interval: [0,63]");
                }
                if (value != 1 && value != 0)
                {
                    throw new ArgumentOutOfRangeException("You can set only 0 or 1");
                }
                if (value == 1)
                {
                    this.bits = this.bits | ((ulong)1 << i);
                }
                if (value == 0)
                {
                    this.bits = this.bits & (~(ulong)1 << i);
                }
            }
        }
        
        #endregion
        
        #region Methods
        
        public override string ToString()
        {
            return bits.ToString();
        }
        
        public override bool Equals(object param)
        {
            BitArray64 x = param as BitArray64;
            if (x == null)
            {
                return false;
            }
            if (!Object.Equals(this.bits, x.bits))
            {
                return false;
            }
            return true;
        }
        
        public override int GetHashCode()
        {
            return new { A = this.bits }.GetHashCode();
        }
        
        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return BitArray64.Equals(a, b);
        }
        
        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !BitArray64.Equals(a, b);
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return (byte)(((this.bits >> i) & 1) == 1 ? 1 : 0);
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    
        #endregion
    }
}
