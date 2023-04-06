namespace Busses
{
    partial class AddBus
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
            this.btn_CancelBuss = new System.Windows.Forms.Button();
            this.btn_AddBuss = new System.Windows.Forms.Button();
            this.cBox_IsLocal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Registration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CancelBuss);
            this.groupBox1.Controls.Add(this.btn_AddBuss);
            this.groupBox1.Controls.Add(this.cBox_IsLocal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Registration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади автобус";
            // 
            // btn_CancelBuss
            // 
            this.btn_CancelBuss.Location = new System.Drawing.Point(98, 154);
            this.btn_CancelBuss.Name = "btn_CancelBuss";
            this.btn_CancelBuss.Size = new System.Drawing.Size(65, 29);
            this.btn_CancelBuss.TabIndex = 7;
            this.btn_CancelBuss.Text = "Откажи";
            this.btn_CancelBuss.UseVisualStyleBackColor = true;
            this.btn_CancelBuss.Click += new System.EventHandler(this.btn_CancelBuss_Click);
            // 
            // btn_AddBuss
            // 
            this.btn_AddBuss.Location = new System.Drawing.Point(27, 154);
            this.btn_AddBuss.Name = "btn_AddBuss";
            this.btn_AddBuss.Size = new System.Drawing.Size(65, 29);
            this.btn_AddBuss.TabIndex = 6;
            this.btn_AddBuss.Text = "Зачувај";
            this.btn_AddBuss.UseVisualStyleBackColor = true;
            this.btn_AddBuss.Click += new System.EventHandler(this.btn_AddBuss_Click);
            // 
            // cBox_IsLocal
            // 
            this.cBox_IsLocal.AutoSize = true;
            this.cBox_IsLocal.Location = new System.Drawing.Point(18, 120);
            this.cBox_IsLocal.Name = "cBox_IsLocal";
            this.cBox_IsLocal.Size = new System.Drawing.Size(113, 17);
            this.cBox_IsLocal.TabIndex = 5;
            this.cBox_IsLocal.Text = "Дали е локален?";
            this.cBox_IsLocal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Локален";
            // 
            // txt_Registration
            // 
            this.txt_Registration.Location = new System.Drawing.Point(18, 81);
            this.txt_Registration.Name = "txt_Registration";
            this.txt_Registration.Size = new System.Drawing.Size(191, 20);
            this.txt_Registration.TabIndex = 3;
            this.txt_Registration.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Registration_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Регистрација:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(18, 42);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(191, 20);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Name_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // AddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 213);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBus";
            this.Text = "Нов автобус";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CancelBuss;
        private System.Windows.Forms.Button btn_AddBuss;
        private System.Windows.Forms.CheckBox cBox_IsLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Registration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
    }
}