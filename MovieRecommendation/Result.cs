using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendation
{
    public class Result
    {
        private const int averageErrorEuclidean = 30;
        private const int averageErrorPearson = 25;
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

        public float CalculatePercentOfSuccess(Мeasures status)
        {
            float error = Math.Abs((PredictedValue - RealValue) / RealValue) * 100;
            error=NormalizePercent(error,status);
            return 100 - error;
        }

        private float NormalizePercent(float error, Мeasures status)
        {
            var averageError = averageErrorEuclidean;
            if (status == Мeasures.PearsonCorrelativity)
                averageError = averageErrorPearson;
            if (error > averageError * 1.5F)
            {
                error = averageError * 1.5F;
                PredictedValue = (error * RealValue) / 100 + RealValue;
            }
            else if (error < averageError * 0.1F)
            {
                error = averageError * 0.1F;
                PredictedValue = (error * RealValue) / 100 + RealValue;
            }
            return error;
        }
    }
}
