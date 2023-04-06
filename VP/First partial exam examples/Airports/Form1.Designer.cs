namespace Airports
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_Airports = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Avg = new System.Windows.Forms.TextBox();
            this.txt_Max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_Destinations = new System.Windows.Forms.ListBox();
            this.btn_AddAirpot = new System.Windows.Forms.Button();
            this.btn_AddDestination = new System.Windows.Forms.Button();
            this.btn_DeleteAirport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Airports);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Аеродроми";
            // 
            // listBox_Airports
            // 
            this.listBox_Airports.FormattingEnabled = true;
            this.listBox_Airports.Location = new System.Drawing.Point(16, 19);
            this.listBox_Airports.Name = "listBox_Airports";
            this.listBox_Airports.Size = new System.Drawing.Size(227, 329);
            this.listBox_Airports.TabIndex = 0;
            this.listBox_Airports.SelectedIndexChanged += new System.EventHandler(this.listBox_Airports_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Avg);
            this.groupBox2.Controls.Add(this.txt_Max);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(305, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дестинации";
            // 
            // txt_Avg
            // 
            this.txt_Avg.Location = new System.Drawing.Point(16, 90);
            this.txt_Avg.Name = "txt_Avg";
            this.txt_Avg.ReadOnly = true;
            this.txt_Avg.Size = new System.Drawing.Size(208, 20);
            this.txt_Avg.TabIndex = 3;
            this.txt_Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Max
            // 
            this.txt_Max.Location = new System.Drawing.Point(16, 46);
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.ReadOnly = true;
            this.txt_Max.Size = new System.Drawing.Size(208, 20);
            this.txt_Max.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Просечна должина на дестинациите";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Најскапа дестинација";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_Destinations);
            this.groupBox3.Location = new System.Drawing.Point(305, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 368);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дестинации";
            // 
            // listBox_Destinations
            // 
            this.listBox_Destinations.FormattingEnabled = true;
            this.listBox_Destinations.Location = new System.Drawing.Point(16, 20);
            this.listBox_Destinations.Name = "listBox_Destinations";
            this.listBox_Destinations.Size = new System.Drawing.Size(227, 329);
            this.listBox_Destinations.TabIndex = 1;
            // 
            // btn_AddAirpot
            // 
            this.btn_AddAirpot.Location = new System.Drawing.Point(28, 398);
            this.btn_AddAirpot.Name = "btn_AddAirpot";
            this.btn_AddAirpot.Size = new System.Drawing.Size(227, 31);
            this.btn_AddAirpot.TabIndex = 3;
            this.btn_AddAirpot.Text = "Додади аеродром";
            this.btn_AddAirpot.UseVisualStyleBackColor = true;
            this.btn_AddAirpot.Click += new System.EventHandler(this.btn_AddAirpot_Click);
            // 
            // btn_AddDestination
            // 
            this.btn_AddDestination.Location = new System.Drawing.Point(28, 503);
            this.btn_AddDestination.Name = "btn_AddDestination";
            this.btn_AddDestination.Size = new System.Drawing.Size(227, 31);
            this.btn_AddDestination.TabIndex = 4;
            this.btn_AddDestination.Text = "Додади дестинација";
            this.btn_AddDestination.UseVisualStyleBackColor = true;
            this.btn_AddDestination.Click += new System.EventHandler(this.btn_AddDestination_Click);
            // 
            // btn_DeleteAirport
            // 
            this.btn_DeleteAirport.Location = new System.Drawing.Point(28, 451);
            this.btn_DeleteAirport.Name = "btn_DeleteAirport";
            this.btn_DeleteAirport.Size = new System.Drawing.Size(227, 31);
            this.btn_DeleteAirport.TabIndex = 5;
            this.btn_DeleteAirport.Text = "Избриши аердром";
            this.btn_DeleteAirport.UseVisualStyleBackColor = true;
            this.btn_DeleteAirport.Click += new System.EventHandler(this.btn_DeleteAirport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 587);
            this.Controls.Add(this.btn_DeleteAirport);
            this.Controls.Add(this.btn_AddDestination);
            this.Controls.Add(this.btn_AddAirpot);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Airports;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Avg;
        private System.Windows.Forms.TextBox txt_Max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_Destinations;
        private System.Windows.Forms.Button btn_AddAirpot;
        private System.Windows.Forms.Button btn_AddDestination;
        private System.Windows.Forms.Button btn_DeleteAirport;
    }
}

