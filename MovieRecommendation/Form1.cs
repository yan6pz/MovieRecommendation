using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRecommendation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Мeasures));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Мeasures status;
            int userId = 0;
            List<int> movieIds = new List<int>();
            List<string> movieIdStrings = txtMovies.Text.Split(',').ToList();

            foreach (string movieIdString in movieIdStrings)
            {
                int id = 0;
                if (int.TryParse(movieIdString, out id))
                {
                    movieIds.Add(id);
                }
            }
           
            Enum.TryParse<Мeasures>(comboBox1.SelectedValue.ToString(), out status);

            if (int.TryParse(txtUserId.Text, out userId))
            {
                List<Result> results = new List<Result>();
                var rec = new Recommender();

                foreach (int movieId in movieIds)
                {
                    switch (status)
                    {
                        case Мeasures.EuclideanDistance:
                            results.Add(rec.RecommendEuclideanDistanceSimilarity(userId, movieId));
                            break;

                        case Мeasures.PearsonCorrelativity:
                            results.Add(rec.RecommendPearsonCorrelationSimilarity(userId, movieId));
                            break;

                        case Мeasures.TanimotoSimilarity:
                            results.Add(rec.RecommendTanimotoSimilarity(userId, movieId));
                            break;

                        case Мeasures.UncenteredCosine:
                            results.Add(rec.RecommendLLRSimilarity(userId, movieId));
                            break;
                    }
                }

                if (movieIds.Count > 1)
                {
                    resultLabel.Visible = false;
                    realValue.Visible = false;
                    float sum = 0;
                    foreach (Result res in results)
                    {                 
                        sum = sum + res.CalculatePercentOfSuccess(status);
                    }
                    percent.Text = (sum / results.Count).ToString("0.00");
                }
                else
                {
                    resultLabel.Visible = true; 
                    realValue.Visible = true;
                    percent.Text = results[0].CalculatePercentOfSuccess(status).ToString("0.00") + "%";
                    resultLabel.Text = results[0].PredictedValue.ToString("0.00");
                    realValue.Text = results[0].RealValue.ToString("0.00");
                   
                }

            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void userId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
