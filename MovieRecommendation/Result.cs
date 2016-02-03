using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendation
{
    public class Result
    {
        private float _RealValue;
        private float _PredictedValue;

        public float RealValue
        {
            get
            {
                return _RealValue;
            }
            set
            {
                _RealValue = value;
            }
        }

        public float PredictedValue
        {
            get
            {
                return _PredictedValue;
            }
            set
            {
                _PredictedValue = value;
            }
        }

        public float CalculatePercent()
        {
            float error = Math.Abs((PredictedValue - RealValue) / RealValue) * 100;
            return 100 - error;
        }
    }
}
