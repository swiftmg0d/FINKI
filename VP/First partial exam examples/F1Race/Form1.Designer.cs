namespace F1Race
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
            this.listBox_Drivers = new System.Windows.Forms.ListBox();
            this.btn_AddDriver = new System.Windows.Forms.Button();
            this.btn_DeleteDriver = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_AddLap = new System.Windows.Forms.Button();
            this.num_Time = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BestLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Seconds = new System.Windows.Forms.NumericUpDown();
            this.num_Minutes = new System.Windows.Forms.NumericUpDown();
            this.listBox_Laps = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Drivers);
            this.groupBox1.Controls.Add(this.btn_AddDriver);
            this.groupBox1.Controls.Add(this.btn_DeleteDriver);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 590);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возачи";
            // 
            // listBox_Drivers
            // 
            this.listBox_Drivers.FormattingEnabled = true;
            this.listBox_Drivers.Location = new System.Drawing.Point(6, 19);
            this.listBox_Drivers.Name = "listBox_Drivers";
            this.listBox_Drivers.Size = new System.Drawing.Size(264, 485);
            this.listBox_Drivers.TabIndex = 3;
            this.listBox_Drivers.SelectedIndexChanged += new System.EventHandler(this.listBox_Drivers_SelectedIndexChanged);
            // 
            // btn_AddDriver
            // 
            this.btn_AddDriver.Location = new System.Drawing.Point(6, 510);
            this.btn_AddDriver.Name = "btn_AddDriver";
            this.btn_AddDriver.Size = new System.Drawing.Size(264, 32);
            this.btn_AddDriver.TabIndex = 1;
            this.btn_AddDriver.Text = "Додади возач";
            this.btn_AddDriver.UseVisualStyleBackColor = true;
            this.btn_AddDriver.Click += new System.EventHandler(this.btn_AddDriver_Click);
            // 
            // btn_DeleteDriver
            // 
            this.btn_DeleteDriver.Location = new System.Drawing.Point(6, 548);
            this.btn_DeleteDriver.Name = "btn_DeleteDriver";
            this.btn_DeleteDriver.Size = new System.Drawing.Size(264, 32);
            this.btn_DeleteDriver.TabIndex = 2;
            this.btn_DeleteDriver.Text = "Избриши возач";
            this.btn_DeleteDriver.UseVisualStyleBackColor = true;
            this.btn_DeleteDriver.Click += new System.EventHandler(this.btn_DeleteDriver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_AddLap);
            this.groupBox2.Controls.Add(this.num_Time);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_BestLap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.num_Seconds);
            this.groupBox2.Controls.Add(this.num_Minutes);
            this.groupBox2.Controls.Add(this.listBox_Laps);
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 590);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кругови";
            // 
            // btn_AddLap
            // 
            this.btn_AddLap.Location = new System.Drawing.Point(195, 416);
            this.btn_AddLap.Name = "btn_AddLap";
            this.btn_AddLap.Size = new System.Drawing.Size(75, 23);
            this.btn_AddLap.TabIndex = 13;
            this.btn_AddLap.Text = "Додади круг";
            this.btn_AddLap.UseVisualStyleBackColor = true;
            this.btn_AddLap.Click += new System.EventHandler(this.btn_AddLap_Click);
            // 
            // num_Time
            // 
            this.num_Time.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.num_Time.Location = new System.Drawing.Point(6, 507);
            this.num_Time.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Time.Name = "num_Time";
            this.num_Time.Size = new System.Drawing.Size(120, 20);
            this.num_Time.TabIndex = 12;
            this.num_Time.ValueChanged += new System.EventHandler(this.num_Time_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Време";
            // 
            // txt_BestLap
            // 
            this.txt_BestLap.Location = new System.Drawing.Point(6, 467);
            this.txt_BestLap.Name = "txt_BestLap";
            this.txt_BestLap.ReadOnly = true;
            this.txt_BestLap.Size = new System.Drawing.Size(320, 20);
            this.txt_BestLap.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Најдобар круг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Секунди";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Минути";
            // 
            // num_Seconds
            // 
            this.num_Seconds.Location = new System.Drawing.Point(94, 419);
            this.num_Seconds.Name = "num_Seconds";
            this.num_Seconds.Size = new System.Drawing.Size(76, 20);
            this.num_Seconds.TabIndex = 6;
            this.num_Seconds.ValueChanged += new System.EventHandler(this.num_Seconds_ValueChanged);
            // 
            // num_Minutes
            // 
            this.num_Minutes.Location = new System.Drawing.Point(9, 419);
            this.num_Minutes.Name = "num_Minutes";
            this.num_Minutes.Size = new System.Drawing.Size(76, 20);
            this.num_Minutes.TabIndex = 5;
            this.num_Minutes.ValueChanged += new System.EventHandler(this.num_Minutes_ValueChanged);
            // 
            // listBox_Laps
            // 
            this.listBox_Laps.FormattingEnabled = true;
            this.listBox_Laps.Location = new System.Drawing.Point(6, 19);
            this.listBox_Laps.Name = "listBox_Laps";
            this.listBox_Laps.Size = new System.Drawing.Size(343, 381);
            this.listBox_Laps.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ф1 Трка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Drivers;
        private System.Windows.Forms.Button btn_AddDriver;
        private System.Windows.Forms.Button btn_DeleteDriver;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddLap;
        private System.Windows.Forms.NumericUpDown num_Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BestLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Seconds;
        private System.Windows.Forms.NumericUpDown num_Minutes;
        private System.Windows.Forms.ListBox listBox_Laps;
    }
}

