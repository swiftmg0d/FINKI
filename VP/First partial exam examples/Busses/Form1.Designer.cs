namespace Busses
{
    partial class Busses
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
            this.Автобуси = new System.Windows.Forms.Label();
            this.listBox_Busses = new System.Windows.Forms.ListBox();
            this.listBox_Routes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Линии = new System.Windows.Forms.GroupBox();
            this.txt_AvgPriceRoutes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MostExpensive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddBus = new System.Windows.Forms.Button();
            this.btn_AddRoute = new System.Windows.Forms.Button();
            this.btn_DeleteBus = new System.Windows.Forms.Button();
            this.Линии.SuspendLayout();
            this.SuspendLayout();
            // 
            // Автобуси
            // 
            this.Автобуси.AutoSize = true;
            this.Автобуси.Location = new System.Drawing.Point(12, 9);
            this.Автобуси.Name = "Автобуси";
            this.Автобуси.Size = new System.Drawing.Size(54, 13);
            this.Автобуси.TabIndex = 0;
            this.Автобуси.Text = "Автобуси";
            // 
            // listBox_Busses
            // 
            this.listBox_Busses.FormattingEnabled = true;
            this.listBox_Busses.Location = new System.Drawing.Point(15, 25);
            this.listBox_Busses.Name = "listBox_Busses";
            this.listBox_Busses.Size = new System.Drawing.Size(251, 251);
            this.listBox_Busses.TabIndex = 1;
            this.listBox_Busses.SelectedIndexChanged += new System.EventHandler(this.listBox_Busses_SelectedIndexChanged);
            // 
            // listBox_Routes
            // 
            this.listBox_Routes.FormattingEnabled = true;
            this.listBox_Routes.Location = new System.Drawing.Point(284, 25);
            this.listBox_Routes.Name = "listBox_Routes";
            this.listBox_Routes.Size = new System.Drawing.Size(251, 251);
            this.listBox_Routes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Линии";
            // 
            // Линии
            // 
            this.Линии.Controls.Add(this.txt_AvgPriceRoutes);
            this.Линии.Controls.Add(this.label3);
            this.Линии.Controls.Add(this.txt_MostExpensive);
            this.Линии.Controls.Add(this.label2);
            this.Линии.Location = new System.Drawing.Point(284, 294);
            this.Линии.Name = "Линии";
            this.Линии.Size = new System.Drawing.Size(251, 124);
            this.Линии.TabIndex = 4;
            this.Линии.TabStop = false;
            this.Линии.Text = "Линии";
            // 
            // txt_AvgPriceRoutes
            // 
            this.txt_AvgPriceRoutes.Location = new System.Drawing.Point(12, 83);
            this.txt_AvgPriceRoutes.Name = "txt_AvgPriceRoutes";
            this.txt_AvgPriceRoutes.ReadOnly = true;
            this.txt_AvgPriceRoutes.Size = new System.Drawing.Size(233, 20);
            this.txt_AvgPriceRoutes.TabIndex = 3;
            this.txt_AvgPriceRoutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Просечна чена на линиите";
            // 
            // txt_MostExpensive
            // 
            this.txt_MostExpensive.Location = new System.Drawing.Point(12, 41);
            this.txt_MostExpensive.Name = "txt_MostExpensive";
            this.txt_MostExpensive.ReadOnly = true;
            this.txt_MostExpensive.Size = new System.Drawing.Size(233, 20);
            this.txt_MostExpensive.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Најскапата линија:";
            // 
            // btn_AddBus
            // 
            this.btn_AddBus.Location = new System.Drawing.Point(25, 309);
            this.btn_AddBus.Name = "btn_AddBus";
            this.btn_AddBus.Size = new System.Drawing.Size(227, 23);
            this.btn_AddBus.TabIndex = 5;
            this.btn_AddBus.Text = "Додади автобус";
            this.btn_AddBus.UseVisualStyleBackColor = true;
            this.btn_AddBus.Click += new System.EventHandler(this.btn_AddBus_Click);
            // 
            // btn_AddRoute
            // 
            this.btn_AddRoute.Location = new System.Drawing.Point(25, 378);
            this.btn_AddRoute.Name = "btn_AddRoute";
            this.btn_AddRoute.Size = new System.Drawing.Size(227, 23);
            this.btn_AddRoute.TabIndex = 6;
            this.btn_AddRoute.Text = "Додади линија";
            this.btn_AddRoute.UseVisualStyleBackColor = true;
            this.btn_AddRoute.Click += new System.EventHandler(this.btn_AddRoute_Click);
            // 
            // btn_DeleteBus
            // 
            this.btn_DeleteBus.Location = new System.Drawing.Point(25, 346);
            this.btn_DeleteBus.Name = "btn_DeleteBus";
            this.btn_DeleteBus.Size = new System.Drawing.Size(227, 21);
            this.btn_DeleteBus.TabIndex = 7;
            this.btn_DeleteBus.Text = "Избриши автобус";
            this.btn_DeleteBus.UseVisualStyleBackColor = true;
            this.btn_DeleteBus.Click += new System.EventHandler(this.btn_DeleteBus_Click);
            // 
            // Busses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.btn_DeleteBus);
            this.Controls.Add(this.btn_AddRoute);
            this.Controls.Add(this.btn_AddBus);
            this.Controls.Add(this.Линии);
            this.Controls.Add(this.listBox_Routes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Busses);
            this.Controls.Add(this.Автобуси);
            this.Name = "Busses";
            this.Text = "Автобуси";
            this.Линии.ResumeLayout(false);
            this.Линии.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Автобуси;
        private System.Windows.Forms.ListBox listBox_Busses;
        private System.Windows.Forms.ListBox listBox_Routes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Линии;
        private System.Windows.Forms.TextBox txt_AvgPriceRoutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MostExpensive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddBus;
        private System.Windows.Forms.Button btn_AddRoute;
        private System.Windows.Forms.Button btn_DeleteBus;
    }
}

