namespace F1Race
{
    partial class AddDriver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddDriver = new System.Windows.Forms.Button();
            this.btn_CancelDriver = new System.Windows.Forms.Button();
            this.cBox_isFirst = new System.Windows.Forms.CheckBox();
            this.num_Age = new System.Windows.Forms.NumericUpDown();
            this.txt_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Age)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Возраст";
            // 
            // btn_AddDriver
            // 
            this.btn_AddDriver.Location = new System.Drawing.Point(93, 98);
            this.btn_AddDriver.Name = "btn_AddDriver";
            this.btn_AddDriver.Size = new System.Drawing.Size(75, 23);
            this.btn_AddDriver.TabIndex = 2;
            this.btn_AddDriver.Text = "Додади";
            this.btn_AddDriver.UseVisualStyleBackColor = true;
            this.btn_AddDriver.Click += new System.EventHandler(this.btn_AddDriver_Click);
            // 
            // btn_CancelDriver
            // 
            this.btn_CancelDriver.Location = new System.Drawing.Point(12, 98);
            this.btn_CancelDriver.Name = "btn_CancelDriver";
            this.btn_CancelDriver.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelDriver.TabIndex = 3;
            this.btn_CancelDriver.Text = "Откажи";
            this.btn_CancelDriver.UseVisualStyleBackColor = true;
            this.btn_CancelDriver.Click += new System.EventHandler(this.btn_CancelDriver_Click);
            // 
            // cBox_isFirst
            // 
            this.cBox_isFirst.AutoSize = true;
            this.cBox_isFirst.Location = new System.Drawing.Point(141, 67);
            this.cBox_isFirst.Name = "cBox_isFirst";
            this.cBox_isFirst.Size = new System.Drawing.Size(78, 17);
            this.cBox_isFirst.TabIndex = 4;
            this.cBox_isFirst.Text = "Прв возач";
            this.cBox_isFirst.UseVisualStyleBackColor = true;
            // 
            // num_Age
            // 
            this.num_Age.Location = new System.Drawing.Point(15, 64);
            this.num_Age.Name = "num_Age";
            this.num_Age.Size = new System.Drawing.Size(120, 20);
            this.num_Age.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(12, 25);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(209, 20);
            this.txt_Name.TabIndex = 6;
            this.txt_Name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Name_Validating);
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 131);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.num_Age);
            this.Controls.Add(this.cBox_isFirst);
            this.Controls.Add(this.btn_CancelDriver);
            this.Controls.Add(this.btn_AddDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDriver";
            this.Text = "Додади возач";
            this.Load += new System.EventHandler(this.AddDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddDriver;
        private System.Windows.Forms.Button btn_CancelDriver;
        private System.Windows.Forms.CheckBox cBox_isFirst;
        private System.Windows.Forms.NumericUpDown num_Age;
        private System.Windows.Forms.TextBox txt_Name;
    }
}