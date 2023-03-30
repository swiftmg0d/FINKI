namespace Film_rating_system
{
    partial class AddFilm
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
            this.components = new System.ComponentModel.Container();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.btn_addFilm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(39, 123);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(137, 20);
            this.textBox_Year.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(39, 62);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(138, 20);
            this.textBox_Name.TabIndex = 2;
            // 
            // btn_addFilm
            // 
            this.btn_addFilm.Location = new System.Drawing.Point(72, 159);
            this.btn_addFilm.Name = "btn_addFilm";
            this.btn_addFilm.Size = new System.Drawing.Size(75, 23);
            this.btn_addFilm.TabIndex = 3;
            this.btn_addFilm.Text = "Додади";
            this.btn_addFilm.UseVisualStyleBackColor = true;
            this.btn_addFilm.Click += new System.EventHandler(this.btn_addFilm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Година на издавање:";
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addFilm);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Year);
            this.Name = "AddFilm";
            this.Text = "AddFilm";
            this.Load += new System.EventHandler(this.AddFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button btn_addFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}