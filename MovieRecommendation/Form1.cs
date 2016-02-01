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
                var rec = new Recommender();

                if (status == Мeasures.EuclideanDistance)
                {
                    resultLabel.Text = rec.RecommendEuclideanDistanceSimilarity(userId, movieIds[0]).ToString();
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
