using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_rating_system
{
    
    public partial class FilmRatingSystem : Form
    {
        public List<Film> listFilms{ get; set; }
        public FilmRatingSystem()
        {
            InitializeComponent();
        }

        private void FilmRatingSystem_Load(object sender, EventArgs e)
        {
           listFilms=new List<Film>();
           listFilms.Add(new Film("Maze Runner", 2014));
           listFilms.Add(new Film("Maze Runner 2", 2015));
            listFilms.Add(new Film("Red Notice", 2022));
            listFilms.Add(new Film("The Whale", 2022));
            listFilms.ForEach(i=>listBox_Films.Items.Add(i));
        }

        private void btn_AddFilm_Click(object sender, EventArgs e)
        {
            AddFilm addFilm = new AddFilm();
            addFilm.ShowDialog();
            if(addFilm.FilmCreated!= null)
            {
                listBox_Films.Items.Add(addFilm.FilmCreated);
                listFilms.Add(addFilm.FilmCreated);
            }
           
        }

        private void getRating_SelectedItemChanged(object sender, EventArgs e)
        {
           
        }
        private void updateRatings(Film f1)
        {
            lb_Name.Text = $"Име: {f1.Name}";
            lb_Year.Text = $"Година: {f1.Year0fRelease}";
            lb_numRatings.Text = $"Бр. на рејтизи: {f1.RatingsList.Count()}";
            lb_avgRatings.Text = $"Просечен рејтинг: {f1.avg}";
        }
        

        
        private void listBox_Films_SelectedIndexChanged(object sender, EventArgs e)
       
        {
            if(listBox_Films.SelectedItem!=null)
            {
                Film f1 = (Film)listBox_Films.SelectedItem;
                if (f1.RatingsList.Count ==0)
                {
                    lb_Max.Text = " ";
                    lb_Min.Text = " ";
                }
                else
                {
                    lb_Max.Text = $"Максимален рајтинг: {f1.RatingsList.Max()}";
                    lb_Min.Text = $"Минимален рајтинг: {f1.RatingsList.Min()}";
                }
                updateRatings(f1);
            }
            
            
        }

        private void btn_addRating_Click(object sender, EventArgs e)
        {
            if (getRating.Text.Length>0) { 
                int num=int.Parse(getRating.Text);
                Film f1 = (Film)listBox_Films.SelectedItem;
                f1.RatingsList.Add(num);
                f1.updateAvg();
                updateRatings(f1);
                lb_Max.Text = $"Максимален рајтинг: {f1.RatingsList.Max()}";
                lb_Min.Text = $"Минимален рајтинг: {f1.RatingsList.Min()}";
                
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteRatings_Click(object sender, EventArgs e)
        {
            if(listBox_Films.SelectedItem != null)
            {
                Film f1 = (Film)listBox_Films.SelectedItem;
                f1.RatingsList.Clear();
                f1.avg = 1.0;
                f1.updateAvg();
                updateRatings(f1);
                lb_Max.Text = " ";
                lb_Min.Text = " "; 
            }
        }

        private void textBox_Year_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Year.Text.Length>0)
            {
                List<Film> nList = new List<Film>();
                listFilms.ForEach(i =>
                {
                    if (i.Year0fRelease == int.Parse(textBox_Year.Text)){
                        nList.Add(i);
                    }
                });
                if (nList.Count > 0)
                {
                    Film MaxRatingsFilm = null;
                    Film MostRatingsFIlm = null;
                    int max = int.MinValue;
                    double maxAvg = double.MinValue;
                    nList.ForEach(i =>
                    {
                      if(i.RatingsList.Count > max) {
                            max = i.RatingsList.Count();
                            MostRatingsFIlm = i;
                        }
                        if (i.avg > maxAvg)
                        {
                            maxAvg = i.avg;
                            MaxRatingsFilm = i;
                        }
                    });
                    if (MaxRatingsFilm != null)
                    {
                        textBox_MaxRatingFilm.Text = MaxRatingsFilm.ToString();
                    }
                    if(MostRatingsFIlm != null)
                    {
                        textBox_MostRatingsFilms.Text=MostRatingsFIlm.ToString();
                    }
                }
                else
                {
                    textBox_MaxRatingFilm.Text = "Нема филмови во таа година";
                    textBox_MostRatingsFilms.Text= "Нема филмови во таа година";
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
