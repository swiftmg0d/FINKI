using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_rating_system
{
    
    public partial class AddFilm : Form
    {
        public Film FilmCreated { get; set; }
        public AddFilm()
        {
            InitializeComponent();
        }

        private void AddFilm_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_addFilm_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text.Length > 0 && textBox_Year.Text.Length > 0)
            {
                FilmCreated = new Film(textBox_Name.Text, int.Parse(textBox_Year.Text));
            }


            this.Close();
        }
    }
}
