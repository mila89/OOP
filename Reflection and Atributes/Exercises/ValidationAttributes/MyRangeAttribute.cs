using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int _minValue;
        private int _maxValue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this._minValue = minValue;
            this._maxValue = maxValue;
        }
        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {;
                throw new ArgumentException();
            }
            int valueAsInt = (int)obj;
            if (valueAsInt >= this._minValue && valueAsInt <= this._maxValue)
                return true;
            return false;

        }
    }
}
