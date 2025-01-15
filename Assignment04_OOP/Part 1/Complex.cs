using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_OOP.Part_1
{
    internal class Complex
    {
        #region properties
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0),
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - (right?.Img ?? 0),
            };
        }
    
        #endregion
    }
}
