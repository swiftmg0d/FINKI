namespace Film_rating_system
{
    partial class FilmRatingSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Films = new System.Windows.Forms.ListBox();
            this.btn_AddFilm = new System.Windows.Forms.Button();
            this.btn_addRating = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Year = new System.Windows.Forms.Label();
            this.lb_numRatings = new System.Windows.Forms.Label();
            this.lb_avgRatings = new System.Windows.Forms.Label();
            this.lb_Min = new System.Windows.Forms.Label();
            this.lb_Max = new System.Windows.Forms.Label();
            this.btn_deleteRatings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.textBox_MaxRatingFilm = new System.Windows.Forms.TextBox();
            this.textBox_MostRatingsFilms = new System.Windows.Forms.TextBox();
            this.getRating = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.getRating)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Films
            // 
            this.listBox_Films.FormattingEnabled = true;
            this.listBox_Films.Location = new System.Drawing.Point(12, 12);
            this.listBox_Films.Name = "listBox_Films";
            this.listBox_Films.Size = new System.Drawing.Size(197, 342);
            this.listBox_Films.TabIndex = 0;
            this.listBox_Films.SelectedIndexChanged += new System.EventHandler(this.listBox_Films_SelectedIndexChanged);
            // 
            // btn_AddFilm
            // 
            this.btn_AddFilm.Location = new System.Drawing.Point(36, 360);
            this.btn_AddFilm.Name = "btn_AddFilm";
            this.btn_AddFilm.Size = new System.Drawing.Size(131, 37);
            this.btn_AddFilm.TabIndex = 1;
            this.btn_AddFilm.Text = "Додади филм";
            this.btn_AddFilm.UseVisualStyleBackColor = true;
            this.btn_AddFilm.Click += new System.EventHandler(this.btn_AddFilm_Click);
            // 
            // btn_addRating
            // 
            this.btn_addRating.Location = new System.Drawing.Point(391, 51);
            this.btn_addRating.Name = "btn_addRating";
            this.btn_addRating.Size = new System.Drawing.Size(106, 23);
            this.btn_addRating.TabIndex = 3;
            this.btn_addRating.Text = "Додади рејтинг";
            this.btn_addRating.UseVisualStyleBackColor = true;
            this.btn_addRating.Click += new System.EventHandler(this.btn_addRating_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информации за селектираниот филм:";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(320, 116);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(0, 13);
            this.lb_Name.TabIndex = 5;
            // 
            // lb_Year
            // 
            this.lb_Year.AutoSize = true;
            this.lb_Year.Location = new System.Drawing.Point(320, 141);
            this.lb_Year.Name = "lb_Year";
            this.lb_Year.Size = new System.Drawing.Size(0, 13);
            this.lb_Year.TabIndex = 6;
            // 
            // lb_numRatings
            // 
            this.lb_numRatings.AutoSize = true;
            this.lb_numRatings.Location = new System.Drawing.Point(320, 169);
            this.lb_numRatings.Name = "lb_numRatings";
            this.lb_numRatings.Size = new System.Drawing.Size(0, 13);
            this.lb_numRatings.TabIndex = 7;
            // 
            // lb_avgRatings
            // 
            this.lb_avgRatings.AutoSize = true;
            this.lb_avgRatings.Location = new System.Drawing.Point(320, 198);
            this.lb_avgRatings.Name = "lb_avgRatings";
            this.lb_avgRatings.Size = new System.Drawing.Size(0, 13);
            this.lb_avgRatings.TabIndex = 8;
            // 
            // lb_Min
            // 
            this.lb_Min.AutoSize = true;
            this.lb_Min.Location = new System.Drawing.Point(320, 229);
            this.lb_Min.Name = "lb_Min";
            this.lb_Min.Size = new System.Drawing.Size(0, 13);
            this.lb_Min.TabIndex = 9;
            this.lb_Min.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_Max
            // 
            this.lb_Max.AutoSize = true;
            this.lb_Max.Location = new System.Drawing.Point(320, 256);
            this.lb_Max.Name = "lb_Max";
            this.lb_Max.Size = new System.Drawing.Size(0, 13);
            this.lb_Max.TabIndex = 10;
            // 
            // btn_deleteRatings
            // 
            this.btn_deleteRatings.Location = new System.Drawing.Point(36, 413);
            this.btn_deleteRatings.Name = "btn_deleteRatings";
            this.btn_deleteRatings.Size = new System.Drawing.Size(131, 37);
            this.btn_deleteRatings.TabIndex = 11;
            this.btn_deleteRatings.Text = "Избриши рајтинзи";
            this.btn_deleteRatings.UseVisualStyleBackColor = true;
            this.btn_deleteRatings.Click += new System.EventHandler(this.btn_deleteRatings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Година";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = " Филм со највисок просечен рејтинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Филм со најмногу рејтинзи";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(258, 334);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(100, 20);
            this.textBox_Year.TabIndex = 15;
            this.textBox_Year.TextChanged += new System.EventHandler(this.textBox_Year_TextChanged);
            // 
            // textBox_MaxRatingFilm
            // 
            this.textBox_MaxRatingFilm.Location = new System.Drawing.Point(323, 388);
            this.textBox_MaxRatingFilm.Name = "textBox_MaxRatingFilm";
            this.textBox_MaxRatingFilm.ReadOnly = true;
            this.textBox_MaxRatingFilm.Size = new System.Drawing.Size(174, 20);
            this.textBox_MaxRatingFilm.TabIndex = 16;
            // 
            // textBox_MostRatingsFilms
            // 
            this.textBox_MostRatingsFilms.Location = new System.Drawing.Point(323, 446);
            this.textBox_MostRatingsFilms.Name = "textBox_MostRatingsFilms";
            this.textBox_MostRatingsFilms.ReadOnly = true;
            this.textBox_MostRatingsFilms.Size = new System.Drawing.Size(174, 20);
            this.textBox_MostRatingsFilms.TabIndex = 17;
            // 
            // getRating
            // 
            this.getRating.Location = new System.Drawing.Point(391, 25);
            this.getRating.Name = "getRating";
            this.getRating.Size = new System.Drawing.Size(120, 20);
            this.getRating.TabIndex = 18;
            this.getRating.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FilmRatingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 478);
            this.Controls.Add(this.getRating);
            this.Controls.Add(this.textBox_MostRatingsFilms);
            this.Controls.Add(this.textBox_MaxRatingFilm);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_deleteRatings);
            this.Controls.Add(this.lb_Max);
            this.Controls.Add(this.lb_Min);
            this.Controls.Add(this.lb_avgRatings);
            this.Controls.Add(this.lb_numRatings);
            this.Controls.Add(this.lb_Year);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addRating);
            this.Controls.Add(this.btn_AddFilm);
            this.Controls.Add(this.listBox_Films);
            this.Name = "FilmRatingSystem";
            this.Text = "Film rating system";
            this.Load += new System.EventHandler(this.FilmRatingSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Films;
        private System.Windows.Forms.Button btn_AddFilm;
        private System.Windows.Forms.Button btn_addRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Year;
        private System.Windows.Forms.Label lb_numRatings;
        private System.Windows.Forms.Label lb_avgRatings;
        private System.Windows.Forms.Label lb_Min;
        private System.Windows.Forms.Label lb_Max;
        private System.Windows.Forms.Button btn_deleteRatings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.TextBox textBox_MaxRatingFilm;
        private System.Windows.Forms.TextBox textBox_MostRatingsFilms;
        private System.Windows.Forms.NumericUpDown getRating;
    }
}

