namespace Airports
{
    partial class AddDestination
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.num_Length = new System.Windows.Forms.NumericUpDown();
            this.num_Price = new System.Windows.Forms.NumericUpDown();
            this.btn_AddDestination = new System.Windows.Forms.Button();
            this.btn_CancelDestination = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CancelDestination);
            this.groupBox1.Controls.Add(this.btn_AddDestination);
            this.groupBox1.Controls.Add(this.num_Price);
            this.groupBox1.Controls.Add(this.num_Length);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади дестинација";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Цена:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(20, 46);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(185, 20);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Name_Validating);
            // 
            // num_Length
            // 
            this.num_Length.Location = new System.Drawing.Point(20, 87);
            this.num_Length.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.num_Length.Name = "num_Length";
            this.num_Length.Size = new System.Drawing.Size(120, 20);
            this.num_Length.TabIndex = 3;
            // 
            // num_Price
            // 
            this.num_Price.Location = new System.Drawing.Point(20, 126);
            this.num_Price.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.num_Price.Name = "num_Price";
            this.num_Price.Size = new System.Drawing.Size(120, 20);
            this.num_Price.TabIndex = 4;
            // 
            // btn_AddDestination
            // 
            this.btn_AddDestination.Location = new System.Drawing.Point(20, 176);
            this.btn_AddDestination.Name = "btn_AddDestination";
            this.btn_AddDestination.Size = new System.Drawing.Size(70, 30);
            this.btn_AddDestination.TabIndex = 5;
            this.btn_AddDestination.Text = "Додади";
            this.btn_AddDestination.UseVisualStyleBackColor = true;
            this.btn_AddDestination.Click += new System.EventHandler(this.btn_AddDestination_Click);
            // 
            // btn_CancelDestination
            // 
            this.btn_CancelDestination.Location = new System.Drawing.Point(115, 176);
            this.btn_CancelDestination.Name = "btn_CancelDestination";
            this.btn_CancelDestination.Size = new System.Drawing.Size(70, 30);
            this.btn_CancelDestination.TabIndex = 6;
            this.btn_CancelDestination.Text = "Откажи";
            this.btn_CancelDestination.UseVisualStyleBackColor = true;
            this.btn_CancelDestination.Click += new System.EventHandler(this.btn_CancelDestination_Click);
            // 
            // AddDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 236);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddDestination";
            this.Text = "Нова дестинација";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CancelDestination;
        private System.Windows.Forms.Button btn_AddDestination;
        private System.Windows.Forms.NumericUpDown num_Price;
        private System.Windows.Forms.NumericUpDown num_Length;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}