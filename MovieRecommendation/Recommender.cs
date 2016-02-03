using NReco.CF.Taste.Impl.Model;
using NReco.CF.Taste.Impl.Model.File;
using NReco.CF.Taste.Impl.Recommender;
using NReco.CF.Taste.Impl.Similarity;
using NReco.CF.Taste.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendation
{
    public class Recommender
    {
        static IDataModel dataModel;
        public string PathToDataFile { get; set; }
        public Recommender()
        {
            this.PathToDataFile = Path.Combine("../../data/ratings.dat");
            //if (dataModel == null)
            //{
                
            //}
        }
       
        public Result RecommendEuclideanDistanceSimilarity(int userId, int movieId)
        {
            Result result = new Result();
            dataModel = new FileDataModel(PathToDataFile, false, FileDataModel.DEFAULT_MIN_RELOAD_INTERVAL_MS, false, ",", userId,movieId);
            var removedPrefs=GenericDataModel.preferenceFromUsersRemoved.Values;
            var valueToCompare=removedPrefs.FirstOrDefault(i => i.GetItemID() == movieId).GetValue();
            var similarity = new EuclideanDistanceSimilarity(dataModel);
            var recommender = new GenericItemBasedRecommender(dataModel, similarity);
            var preferences = recommender.EstimatePreference(userId, movieId);

            result.PredictedValue = preferences;
            result.RealValue = removedPrefs.First().GetValue();
            return result;
        }

        public Result RecommendPearsonCorrelationSimilarity(int userId, int movieId)
        {
            Result result = new Result();
            dataModel = new FileDataModel(PathToDataFile, false, FileDataModel.DEFAULT_MIN_RELOAD_INTERVAL_MS, false, ",", userId, movieId);
            var removedPrefs = GenericDataModel.preferenceFromUsersRemoved.Values;
            var valueToCompare = removedPrefs.FirstOrDefault(i => i.GetItemID() == movieId).GetValue();
            var similarity = new PearsonCorrelationSimilarity(dataModel);
            var recommender = new GenericItemBasedRecommender(dataModel, similarity);
            var preferences = recommender.EstimatePreference(userId, movieId);

            result.PredictedValue = preferences;
            result.RealValue = removedPrefs.First().GetValue();
            return result;
        }

        //public float RecommendEuclideanDistanceSimilarity(int userId, int movieId)
        //{
        //    //var plusAnonymModel = new PearsonCorrelationSimilarity(dataModel);
        //    //var prefArr = new GenericUserPreferenceArray(filmIds.Length);
        //    //prefArr.SetUserID(0, userId);
        //    //for (int i = 0; i < filmIds.Length; i++)
        //    //{
        //    //    prefArr.SetItemID(i, filmIds[i]);
        //    //    prefArr.SetValue(i, 5); // lets assume max rating
        //    //}
        //    //plusAnonymModel.SetTempPrefs(prefArr);

        //    var similarity = new EuclideanDistanceSimilarity(dataModel);
        //    //var neighborhood = new NearestNUserNeighborhood(15, similarity, dataModel);
        //    var recommender = new GenericItemBasedRecommender(dataModel, similarity);
        //    var preferences = recommender.EstimatePreference(userId, 223);
        //    //return Json(recommendedItems.Select(ri => new Dictionary<string, object>() {
        //    //    {"film_id", ri.GetItemID() },
        //    //    {"rating", ri.GetValue() },
        //    //}).ToArray());
        //    return preferences;
        //}

    }
}
