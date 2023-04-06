namespace Airports
{
    partial class AddAirport
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
            this.btn_CancelAirport = new System.Windows.Forms.Button();
            this.btn_SaveAirpot = new System.Windows.Forms.Button();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CancelAirport);
            this.groupBox1.Controls.Add(this.btn_SaveAirpot);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_City);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади аердром";
            // 
            // btn_CancelAirport
            // 
            this.btn_CancelAirport.Location = new System.Drawing.Point(150, 173);
            this.btn_CancelAirport.Name = "btn_CancelAirport";
            this.btn_CancelAirport.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelAirport.TabIndex = 9;
            this.btn_CancelAirport.Text = "Откажи";
            this.btn_CancelAirport.UseVisualStyleBackColor = true;
            this.btn_CancelAirport.Click += new System.EventHandler(this.btn_CancelAirport_Click);
            // 
            // btn_SaveAirpot
            // 
            this.btn_SaveAirpot.Location = new System.Drawing.Point(23, 173);
            this.btn_SaveAirpot.Name = "btn_SaveAirpot";
            this.btn_SaveAirpot.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveAirpot.TabIndex = 8;
            this.btn_SaveAirpot.Text = "Зачувај";
            this.btn_SaveAirpot.UseVisualStyleBackColor = true;
            this.btn_SaveAirpot.Click += new System.EventHandler(this.btn_SaveAirpot_Click);
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(23, 129);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(100, 20);
            this.txt_Code.TabIndex = 7;
            this.txt_Code.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Code_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кратенка:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(23, 83);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(202, 20);
            this.txt_Name.TabIndex = 5;
            this.txt_Name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Name_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Име:";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(23, 44);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(202, 20);
            this.txt_City.TabIndex = 3;
            this.txt_City.Validating += new System.ComponentModel.CancelEventHandler(this.txt_City_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Град:";
            // 
            // AddAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAirport";
            this.Text = "Нов аеродром";
            this.Load += new System.EventHandler(this.AddAirport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CancelAirport;
        private System.Windows.Forms.Button btn_SaveAirpot;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label label1;
    }
}