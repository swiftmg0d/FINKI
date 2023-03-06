namespace Ordering_a_pizza
{
    partial class Ordering_a_pizza
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grBox_size = new GroupBox();
            largeSize_price = new TextBox();
            mediumSize_price = new TextBox();
            smallSize_price = new TextBox();
            rd_btn_largeSize = new RadioButton();
            rd_btn_mediumSize = new RadioButton();
            rd_btn_smallSize = new RadioButton();
            grBox_ingredients = new GroupBox();
            ch_btn_peppers = new CheckBox();
            ch_btn_extraCheese = new CheckBox();
            ch_btn_ketchap = new CheckBox();
            ketchap_price = new TextBox();
            extraCheese_price = new TextBox();
            pappers_price = new TextBox();
            grBox_size.SuspendLayout();
            grBox_ingredients.SuspendLayout();
            SuspendLayout();
            // 
            // grBox_size
            // 
            grBox_size.Controls.Add(largeSize_price);
            grBox_size.Controls.Add(mediumSize_price);
            grBox_size.Controls.Add(smallSize_price);
            grBox_size.Controls.Add(rd_btn_largeSize);
            grBox_size.Controls.Add(rd_btn_mediumSize);
            grBox_size.Controls.Add(rd_btn_smallSize);
            grBox_size.Location = new Point(12, 12);
            grBox_size.Name = "grBox_size";
            grBox_size.Size = new Size(266, 111);
            grBox_size.TabIndex = 0;
            grBox_size.TabStop = false;
            grBox_size.Text = "Големина";
            // 
            // largeSize_price
            // 
            largeSize_price.Location = new Point(184, 72);
            largeSize_price.Multiline = true;
            largeSize_price.Name = "largeSize_price";
            largeSize_price.Size = new Size(65, 19);
            largeSize_price.TabIndex = 7;
            // 
            // mediumSize_price
            // 
            mediumSize_price.Location = new Point(184, 47);
            mediumSize_price.Multiline = true;
            mediumSize_price.Name = "mediumSize_price";
            mediumSize_price.Size = new Size(65, 19);
            mediumSize_price.TabIndex = 6;
            // 
            // smallSize_price
            // 
            smallSize_price.Location = new Point(184, 21);
            smallSize_price.Multiline = true;
            smallSize_price.Name = "smallSize_price";
            smallSize_price.Size = new Size(65, 19);
            smallSize_price.TabIndex = 5;
            // 
            // rd_btn_largeSize
            // 
            rd_btn_largeSize.AutoSize = true;
            rd_btn_largeSize.Location = new Point(6, 72);
            rd_btn_largeSize.Name = "rd_btn_largeSize";
            rd_btn_largeSize.Size = new Size(66, 19);
            rd_btn_largeSize.TabIndex = 4;
            rd_btn_largeSize.TabStop = true;
            rd_btn_largeSize.Text = "Голема";
            rd_btn_largeSize.UseVisualStyleBackColor = true;
            // 
            // rd_btn_mediumSize
            // 
            rd_btn_mediumSize.AutoSize = true;
            rd_btn_mediumSize.Location = new Point(6, 47);
            rd_btn_mediumSize.Name = "rd_btn_mediumSize";
            rd_btn_mediumSize.Size = new Size(65, 19);
            rd_btn_mediumSize.TabIndex = 3;
            rd_btn_mediumSize.TabStop = true;
            rd_btn_mediumSize.Text = "Средна";
            rd_btn_mediumSize.UseVisualStyleBackColor = true;
            // 
            // rd_btn_smallSize
            // 
            rd_btn_smallSize.AutoSize = true;
            rd_btn_smallSize.Location = new Point(6, 22);
            rd_btn_smallSize.Name = "rd_btn_smallSize";
            rd_btn_smallSize.Size = new Size(55, 19);
            rd_btn_smallSize.TabIndex = 2;
            rd_btn_smallSize.TabStop = true;
            rd_btn_smallSize.Text = "Мала";
            rd_btn_smallSize.UseVisualStyleBackColor = true;
            // 
            // grBox_ingredients
            // 
            grBox_ingredients.Controls.Add(pappers_price);
            grBox_ingredients.Controls.Add(extraCheese_price);
            grBox_ingredients.Controls.Add(ketchap_price);
            grBox_ingredients.Controls.Add(ch_btn_ketchap);
            grBox_ingredients.Controls.Add(ch_btn_extraCheese);
            grBox_ingredients.Controls.Add(ch_btn_peppers);
            grBox_ingredients.Location = new Point(308, 12);
            grBox_ingredients.Name = "grBox_ingredients";
            grBox_ingredients.Size = new Size(266, 111);
            grBox_ingredients.TabIndex = 1;
            grBox_ingredients.TabStop = false;
            grBox_ingredients.Text = "Додатоци";
            // 
            // ch_btn_peppers
            // 
            ch_btn_peppers.AutoSize = true;
            ch_btn_peppers.Location = new Point(13, 24);
            ch_btn_peppers.Name = "ch_btn_peppers";
            ch_btn_peppers.Size = new Size(90, 19);
            ch_btn_peppers.TabIndex = 0;
            ch_btn_peppers.Text = "Феферонки";
            ch_btn_peppers.UseVisualStyleBackColor = true;
            // 
            // ch_btn_extraCheese
            // 
            ch_btn_extraCheese.AutoSize = true;
            ch_btn_extraCheese.Location = new Point(13, 47);
            ch_btn_extraCheese.Name = "ch_btn_extraCheese";
            ch_btn_extraCheese.Size = new Size(107, 19);
            ch_btn_extraCheese.TabIndex = 1;
            ch_btn_extraCheese.Text = "Екстра сирење";
            ch_btn_extraCheese.UseVisualStyleBackColor = true;
            // 
            // ch_btn_ketchap
            // 
            ch_btn_ketchap.AutoSize = true;
            ch_btn_ketchap.Location = new Point(13, 74);
            ch_btn_ketchap.Name = "ch_btn_ketchap";
            ch_btn_ketchap.Size = new Size(59, 19);
            ch_btn_ketchap.TabIndex = 2;
            ch_btn_ketchap.Text = "Кечап";
            ch_btn_ketchap.UseVisualStyleBackColor = true;
            // 
            // ketchap_price
            // 
            ketchap_price.Location = new Point(183, 74);
            ketchap_price.Multiline = true;
            ketchap_price.Name = "ketchap_price";
            ketchap_price.Size = new Size(65, 19);
            ketchap_price.TabIndex = 6;
            // 
            // extraCheese_price
            // 
            extraCheese_price.Location = new Point(183, 49);
            extraCheese_price.Multiline = true;
            extraCheese_price.Name = "extraCheese_price";
            extraCheese_price.Size = new Size(65, 19);
            extraCheese_price.TabIndex = 7;
            // 
            // pappers_price
            // 
            pappers_price.Location = new Point(183, 24);
            pappers_price.Multiline = true;
            pappers_price.Name = "pappers_price";
            pappers_price.Size = new Size(65, 19);
            pappers_price.TabIndex = 8;
            // 
            // Ordering_a_pizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 465);
            Controls.Add(grBox_ingredients);
            Controls.Add(grBox_size);
            Name = "Ordering_a_pizza";
            Text = "Нарачка на пица";
            Load += Ordering_a_pizza_Load;
            grBox_size.ResumeLayout(false);
            grBox_size.PerformLayout();
            grBox_ingredients.ResumeLayout(false);
            grBox_ingredients.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grBox_size;
        private TextBox largeSize_price;
        private TextBox mediumSize_price;
        private TextBox smallSize_price;
        private RadioButton rd_btn_largeSize;
        private RadioButton rd_btn_mediumSize;
        private RadioButton rd_btn_smallSize;
        private GroupBox grBox_ingredients;
        private TextBox pappers_price;
        private TextBox extraCheese_price;
        private TextBox ketchap_price;
        private CheckBox ch_btn_ketchap;
        private CheckBox ch_btn_extraCheese;
        private CheckBox ch_btn_peppers;
    }
}