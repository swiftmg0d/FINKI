namespace Busses
{
    partial class AddRoute
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Цена = new System.Windows.Forms.Label();
            this.num_Price = new System.Windows.Forms.NumericUpDown();
            this.num_Minutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Час = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.num_Hours = new System.Windows.Forms.NumericUpDown();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.Цена);
            this.groupBox1.Controls.Add(this.num_Price);
            this.groupBox1.Controls.Add(this.num_Minutes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Час);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.num_Hours);
            this.groupBox1.Controls.Add(this.txt_Destination);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади линија";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(120, 183);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(96, 23);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Откажи";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(18, 183);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Додади";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Цена
            // 
            this.Цена.AutoSize = true;
            this.Цена.Location = new System.Drawing.Point(15, 128);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(33, 13);
            this.Цена.TabIndex = 8;
            this.Цена.Text = "Цена";
            // 
            // num_Price
            // 
            this.num_Price.Location = new System.Drawing.Point(18, 144);
            this.num_Price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Price.Name = "num_Price";
            this.num_Price.Size = new System.Drawing.Size(96, 20);
            this.num_Price.TabIndex = 7;
            // 
            // num_Minutes
            // 
            this.num_Minutes.Location = new System.Drawing.Point(82, 95);
            this.num_Minutes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Minutes.Name = "num_Minutes";
            this.num_Minutes.Size = new System.Drawing.Size(58, 20);
            this.num_Minutes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Минута";
            // 
            // Час
            // 
            this.Час.AutoSize = true;
            this.Час.Location = new System.Drawing.Point(15, 79);
            this.Час.Name = "Час";
            this.Час.Size = new System.Drawing.Size(27, 13);
            this.Час.TabIndex = 4;
            this.Час.Text = "Час";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // num_Hours
            // 
            this.num_Hours.Location = new System.Drawing.Point(18, 95);
            this.num_Hours.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_Hours.Name = "num_Hours";
            this.num_Hours.Size = new System.Drawing.Size(58, 20);
            this.num_Hours.TabIndex = 2;
            // 
            // txt_Destination
            // 
            this.txt_Destination.Location = new System.Drawing.Point(18, 43);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(261, 20);
            this.txt_Destination.TabIndex = 1;
            this.txt_Destination.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Destination_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дестинација:";
            // 
            // AddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 243);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRoute";
            this.Text = "Нова линија";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label Цена;
        private System.Windows.Forms.NumericUpDown num_Price;
        private System.Windows.Forms.NumericUpDown num_Minutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Час;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown num_Hours;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}