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
            pappers_price = new TextBox();
            extraCheese_price = new TextBox();
            ketchap_price = new TextBox();
            ch_btn_ketchap = new CheckBox();
            ch_btn_extraCheese = new CheckBox();
            ch_btn_peppers = new CheckBox();
            grBox_drinks = new GroupBox();
            totalBeer = new TextBox();
            totalSoda = new TextBox();
            totalJuice = new TextBox();
            beerPrice = new TextBox();
            sodaPrice = new TextBox();
            juicePrice = new TextBox();
            beerQuantity = new TextBox();
            sodaQuantity = new TextBox();
            juiceQuantity = new TextBox();
            lb_total = new Label();
            lb_price = new Label();
            lb_quantity = new Label();
            lb_beer = new Label();
            lb_juice = new Label();
            lb_soda = new Label();
            grBox_desert = new GroupBox();
            btn_exit = new Button();
            button1 = new Button();
            desertPrice = new TextBox();
            lb_desertPrice = new Label();
            listBox_dessert = new ListBox();
            grBox_payment = new GroupBox();
            toReturn = new TextBox();
            paid = new TextBox();
            totalPayment = new TextBox();
            lb_Paid = new Label();
            lb_toReturn = new Label();
            lb_totalPayment = new Label();
            grBox_size.SuspendLayout();
            grBox_ingredients.SuspendLayout();
            grBox_drinks.SuspendLayout();
            grBox_desert.SuspendLayout();
            grBox_payment.SuspendLayout();
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
            rd_btn_largeSize.CheckedChanged += rd_btn_largeSize_CheckedChanged;
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
            rd_btn_mediumSize.CheckedChanged += rd_btn_mediumSize_CheckedChanged;
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
            rd_btn_smallSize.CheckedChanged += rd_btn_smallSize_CheckedChanged;
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
            // pappers_price
            // 
            pappers_price.Location = new Point(183, 24);
            pappers_price.Multiline = true;
            pappers_price.Name = "pappers_price";
            pappers_price.Size = new Size(65, 19);
            pappers_price.TabIndex = 8;
            // 
            // extraCheese_price
            // 
            extraCheese_price.Location = new Point(183, 49);
            extraCheese_price.Multiline = true;
            extraCheese_price.Name = "extraCheese_price";
            extraCheese_price.Size = new Size(65, 19);
            extraCheese_price.TabIndex = 7;
            // 
            // ketchap_price
            // 
            ketchap_price.Location = new Point(183, 74);
            ketchap_price.Multiline = true;
            ketchap_price.Name = "ketchap_price";
            ketchap_price.Size = new Size(65, 19);
            ketchap_price.TabIndex = 6;
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
            ch_btn_ketchap.CheckedChanged += ch_btn_ketchap_CheckedChanged;
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
            ch_btn_extraCheese.CheckedChanged += ch_btn_extraCheese_CheckedChanged;
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
            ch_btn_peppers.CheckedChanged += ch_btn_peppers_CheckedChanged;
            // 
            // grBox_drinks
            // 
            grBox_drinks.Controls.Add(totalBeer);
            grBox_drinks.Controls.Add(totalSoda);
            grBox_drinks.Controls.Add(totalJuice);
            grBox_drinks.Controls.Add(beerPrice);
            grBox_drinks.Controls.Add(sodaPrice);
            grBox_drinks.Controls.Add(juicePrice);
            grBox_drinks.Controls.Add(beerQuantity);
            grBox_drinks.Controls.Add(sodaQuantity);
            grBox_drinks.Controls.Add(juiceQuantity);
            grBox_drinks.Controls.Add(lb_total);
            grBox_drinks.Controls.Add(lb_price);
            grBox_drinks.Controls.Add(lb_quantity);
            grBox_drinks.Controls.Add(lb_beer);
            grBox_drinks.Controls.Add(lb_juice);
            grBox_drinks.Controls.Add(lb_soda);
            grBox_drinks.Location = new Point(12, 139);
            grBox_drinks.Name = "grBox_drinks";
            grBox_drinks.Size = new Size(562, 152);
            grBox_drinks.TabIndex = 9;
            grBox_drinks.TabStop = false;
            grBox_drinks.Text = "Пијалок";
            // 
            // totalBeer
            // 
            totalBeer.Location = new Point(470, 105);
            totalBeer.Multiline = true;
            totalBeer.Name = "totalBeer";
            totalBeer.ReadOnly = true;
            totalBeer.Size = new Size(65, 19);
            totalBeer.TabIndex = 24;
            totalBeer.TextChanged += totalBeer_TextChanged;
            // 
            // totalSoda
            // 
            totalSoda.Location = new Point(470, 44);
            totalSoda.Multiline = true;
            totalSoda.Name = "totalSoda";
            totalSoda.ReadOnly = true;
            totalSoda.Size = new Size(65, 19);
            totalSoda.TabIndex = 23;
            totalSoda.TextChanged += totalSoda_TextChanged;
            // 
            // totalJuice
            // 
            totalJuice.Location = new Point(470, 75);
            totalJuice.Multiline = true;
            totalJuice.Name = "totalJuice";
            totalJuice.ReadOnly = true;
            totalJuice.Size = new Size(65, 19);
            totalJuice.TabIndex = 22;
            totalJuice.TextChanged += totalJuice_TextChanged;
            // 
            // beerPrice
            // 
            beerPrice.Location = new Point(363, 105);
            beerPrice.Multiline = true;
            beerPrice.Name = "beerPrice";
            beerPrice.Size = new Size(65, 19);
            beerPrice.TabIndex = 21;
            // 
            // sodaPrice
            // 
            sodaPrice.Location = new Point(363, 44);
            sodaPrice.Multiline = true;
            sodaPrice.Name = "sodaPrice";
            sodaPrice.Size = new Size(65, 19);
            sodaPrice.TabIndex = 20;
            // 
            // juicePrice
            // 
            juicePrice.Location = new Point(363, 75);
            juicePrice.Multiline = true;
            juicePrice.Name = "juicePrice";
            juicePrice.Size = new Size(65, 19);
            juicePrice.TabIndex = 19;
            // 
            // beerQuantity
            // 
            beerQuantity.Location = new Point(237, 105);
            beerQuantity.Multiline = true;
            beerQuantity.Name = "beerQuantity";
            beerQuantity.Size = new Size(65, 19);
            beerQuantity.TabIndex = 18;
            beerQuantity.TextChanged += beerQuantity_TextChanged;
            // 
            // sodaQuantity
            // 
            sodaQuantity.Location = new Point(237, 44);
            sodaQuantity.Multiline = true;
            sodaQuantity.Name = "sodaQuantity";
            sodaQuantity.Size = new Size(65, 19);
            sodaQuantity.TabIndex = 17;
            sodaQuantity.TextChanged += sodaQuantity_TextChanged;
            // 
            // juiceQuantity
            // 
            juiceQuantity.Location = new Point(237, 75);
            juiceQuantity.Multiline = true;
            juiceQuantity.Name = "juiceQuantity";
            juiceQuantity.Size = new Size(65, 19);
            juiceQuantity.TabIndex = 16;
            juiceQuantity.TextChanged += juiceQuantity_TextChanged;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(479, 19);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(47, 15);
            lb_total.TabIndex = 15;
            lb_total.Text = "Вкупно";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new Point(378, 19);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(35, 15);
            lb_price.TabIndex = 14;
            lb_price.Text = "Цена";
            // 
            // lb_quantity
            // 
            lb_quantity.AutoSize = true;
            lb_quantity.Location = new Point(237, 19);
            lb_quantity.Name = "lb_quantity";
            lb_quantity.Size = new Size(62, 15);
            lb_quantity.TabIndex = 13;
            lb_quantity.Text = "Количина";
            // 
            // lb_beer
            // 
            lb_beer.AutoSize = true;
            lb_beer.Location = new Point(18, 102);
            lb_beer.Name = "lb_beer";
            lb_beer.Size = new Size(36, 15);
            lb_beer.TabIndex = 12;
            lb_beer.Text = "Пиво";
            // 
            // lb_juice
            // 
            lb_juice.AutoSize = true;
            lb_juice.Location = new Point(16, 72);
            lb_juice.Name = "lb_juice";
            lb_juice.Size = new Size(153, 15);
            lb_juice.TabIndex = 11;
            lb_juice.Text = "Сок од јаболко / портокал";
            // 
            // lb_soda
            // 
            lb_soda.AutoSize = true;
            lb_soda.Location = new Point(16, 44);
            lb_soda.Name = "lb_soda";
            lb_soda.Size = new Size(153, 15);
            lb_soda.TabIndex = 10;
            lb_soda.Text = "Кока кола / Фанта / Спрајт";
            // 
            // grBox_desert
            // 
            grBox_desert.Controls.Add(btn_exit);
            grBox_desert.Controls.Add(button1);
            grBox_desert.Controls.Add(desertPrice);
            grBox_desert.Controls.Add(lb_desertPrice);
            grBox_desert.Controls.Add(listBox_dessert);
            grBox_desert.Location = new Point(12, 297);
            grBox_desert.Name = "grBox_desert";
            grBox_desert.Size = new Size(266, 156);
            grBox_desert.TabIndex = 10;
            grBox_desert.TabStop = false;
            grBox_desert.Text = "Десерт";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(143, 109);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(106, 23);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Откажи";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(143, 80);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 0;
            button1.Text = "Нарачај";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // desertPrice
            // 
            desertPrice.Location = new Point(143, 51);
            desertPrice.Name = "desertPrice";
            desertPrice.Size = new Size(106, 23);
            desertPrice.TabIndex = 2;
            // 
            // lb_desertPrice
            // 
            lb_desertPrice.AutoSize = true;
            lb_desertPrice.Location = new Point(143, 22);
            lb_desertPrice.Name = "lb_desertPrice";
            lb_desertPrice.Size = new Size(93, 15);
            lb_desertPrice.TabIndex = 1;
            lb_desertPrice.Text = "Цена на десерт:";
            // 
            // listBox_dessert
            // 
            listBox_dessert.FormattingEnabled = true;
            listBox_dessert.ItemHeight = 15;
            listBox_dessert.Items.AddRange(new object[] { "Овошна пита\t", "Сладолед", "Торта" });
            listBox_dessert.Location = new Point(6, 22);
            listBox_dessert.Name = "listBox_dessert";
            listBox_dessert.Size = new Size(120, 109);
            listBox_dessert.TabIndex = 0;
            listBox_dessert.SelectedIndexChanged += listBox_dessert_SelectedIndexChanged;
            // 
            // grBox_payment
            // 
            grBox_payment.Controls.Add(toReturn);
            grBox_payment.Controls.Add(paid);
            grBox_payment.Controls.Add(totalPayment);
            grBox_payment.Controls.Add(lb_Paid);
            grBox_payment.Controls.Add(lb_toReturn);
            grBox_payment.Controls.Add(lb_totalPayment);
            grBox_payment.Location = new Point(308, 297);
            grBox_payment.Name = "grBox_payment";
            grBox_payment.Size = new Size(266, 156);
            grBox_payment.TabIndex = 11;
            grBox_payment.TabStop = false;
            grBox_payment.Text = "Наплата";
            // 
            // toReturn
            // 
            toReturn.Location = new Point(154, 85);
            toReturn.Name = "toReturn";
            toReturn.Size = new Size(106, 23);
            toReturn.TabIndex = 30;
            // 
            // paid
            // 
            paid.Location = new Point(154, 56);
            paid.Name = "paid";
            paid.Size = new Size(106, 23);
            paid.TabIndex = 29;
            paid.TextChanged += paid_TextChanged;
            // 
            // totalPayment
            // 
            totalPayment.Location = new Point(154, 22);
            totalPayment.Name = "totalPayment";
            totalPayment.ReadOnly = true;
            totalPayment.Size = new Size(106, 23);
            totalPayment.TabIndex = 28;
            totalPayment.TextChanged += totalPayment_TextChanged;
            // 
            // lb_Paid
            // 
            lb_Paid.AutoSize = true;
            lb_Paid.Location = new Point(13, 59);
            lb_Paid.Name = "lb_Paid";
            lb_Paid.Size = new Size(70, 15);
            lb_Paid.TabIndex = 27;
            lb_Paid.Text = "Наплатено:";
            // 
            // lb_toReturn
            // 
            lb_toReturn.AutoSize = true;
            lb_toReturn.Location = new Point(13, 88);
            lb_toReturn.Name = "lb_toReturn";
            lb_toReturn.Size = new Size(73, 15);
            lb_toReturn.TabIndex = 26;
            lb_toReturn.Text = "За враќање:";
            // 
            // lb_totalPayment
            // 
            lb_totalPayment.AutoSize = true;
            lb_totalPayment.Location = new Point(13, 30);
            lb_totalPayment.Name = "lb_totalPayment";
            lb_totalPayment.Size = new Size(115, 15);
            lb_totalPayment.TabIndex = 25;
            lb_totalPayment.Text = "Вкупно за плаќање:";
            // 
            // Ordering_a_pizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 465);
            Controls.Add(grBox_payment);
            Controls.Add(grBox_desert);
            Controls.Add(grBox_drinks);
            Controls.Add(grBox_ingredients);
            Controls.Add(grBox_size);
            Name = "Ordering_a_pizza";
            Text = "Нарачка на пица";
            Load += Ordering_a_pizza_Load;
            grBox_size.ResumeLayout(false);
            grBox_size.PerformLayout();
            grBox_ingredients.ResumeLayout(false);
            grBox_ingredients.PerformLayout();
            grBox_drinks.ResumeLayout(false);
            grBox_drinks.PerformLayout();
            grBox_desert.ResumeLayout(false);
            grBox_desert.PerformLayout();
            grBox_payment.ResumeLayout(false);
            grBox_payment.PerformLayout();
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
        private GroupBox grBox_drinks;
        private TextBox totalBeer;
        private TextBox totalSoda;
        private TextBox totalJuice;
        private TextBox beerPrice;
        private TextBox sodaPrice;
        private TextBox juicePrice;
        private TextBox beerQuantity;
        private TextBox sodaQuantity;
        private TextBox juiceQuantity;
        private Label lb_total;
        private Label lb_price;
        private Label lb_quantity;
        private Label lb_beer;
        private Label lb_juice;
        private Label lb_soda;
        private GroupBox grBox_desert;
        private ListBox listBox_dessert;
        private GroupBox grBox_payment;
        private TextBox desertPrice;
        private Label lb_desertPrice;
        private Button btn_exit;
        private Button button1;
        private TextBox toReturn;
        private TextBox paid;
        private TextBox totalPayment;
        private Label lb_Paid;
        private Label lb_toReturn;
        private Label lb_totalPayment;
    }
}