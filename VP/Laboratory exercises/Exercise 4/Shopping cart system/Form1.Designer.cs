namespace Shopping_cart_system
{
    partial class ShoppingCartSystem
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
            this.listBox_ProductsToBeAdded = new System.Windows.Forms.ListBox();
            this.listBox_ProductsAdded = new System.Windows.Forms.ListBox();
            this.lb_List0fProducts = new System.Windows.Forms.Label();
            this.lb_Cart = new System.Windows.Forms.Label();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_AddNewProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProductFromCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ShowName = new System.Windows.Forms.TextBox();
            this.txt_ShowCategory = new System.Windows.Forms.TextBox();
            this.txt_ShowPrice = new System.Windows.Forms.TextBox();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ClearList0fProducts = new System.Windows.Forms.Button();
            this.btn_ClearCart = new System.Windows.Forms.Button();
            this.num0fProducts = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num0fProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_ProductsToBeAdded
            // 
            this.listBox_ProductsToBeAdded.FormattingEnabled = true;
            this.listBox_ProductsToBeAdded.Location = new System.Drawing.Point(12, 27);
            this.listBox_ProductsToBeAdded.Name = "listBox_ProductsToBeAdded";
            this.listBox_ProductsToBeAdded.Size = new System.Drawing.Size(208, 420);
            this.listBox_ProductsToBeAdded.TabIndex = 0;
            this.listBox_ProductsToBeAdded.SelectedIndexChanged += new System.EventHandler(this.listBox_ProductsToBeAdded_SelectedIndexChanged);
            // 
            // listBox_ProductsAdded
            // 
            this.listBox_ProductsAdded.FormattingEnabled = true;
            this.listBox_ProductsAdded.Location = new System.Drawing.Point(393, 27);
            this.listBox_ProductsAdded.Name = "listBox_ProductsAdded";
            this.listBox_ProductsAdded.Size = new System.Drawing.Size(208, 420);
            this.listBox_ProductsAdded.TabIndex = 1;
            // 
            // lb_List0fProducts
            // 
            this.lb_List0fProducts.AutoSize = true;
            this.lb_List0fProducts.Location = new System.Drawing.Point(12, 11);
            this.lb_List0fProducts.Name = "lb_List0fProducts";
            this.lb_List0fProducts.Size = new System.Drawing.Size(105, 13);
            this.lb_List0fProducts.TabIndex = 2;
            this.lb_List0fProducts.Text = "Листа на продукти:";
            // 
            // lb_Cart
            // 
            this.lb_Cart.AutoSize = true;
            this.lb_Cart.Location = new System.Drawing.Point(390, 11);
            this.lb_Cart.Name = "lb_Cart";
            this.lb_Cart.Size = new System.Drawing.Size(57, 13);
            this.lb_Cart.TabIndex = 3;
            this.lb_Cart.Text = "Кожничка";
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.Location = new System.Drawing.Point(226, 289);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(161, 23);
            this.btn_AddToCart.TabIndex = 4;
            this.btn_AddToCart.Text = "Додади во кошничка >>";
            this.btn_AddToCart.UseVisualStyleBackColor = true;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(226, 408);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(161, 23);
            this.btn_DeleteProduct.TabIndex = 5;
            this.btn_DeleteProduct.Text = "Избриши продукт";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // btn_AddNewProduct
            // 
            this.btn_AddNewProduct.Location = new System.Drawing.Point(226, 366);
            this.btn_AddNewProduct.Name = "btn_AddNewProduct";
            this.btn_AddNewProduct.Size = new System.Drawing.Size(161, 23);
            this.btn_AddNewProduct.TabIndex = 6;
            this.btn_AddNewProduct.Text = "Додади нов продукт";
            this.btn_AddNewProduct.UseVisualStyleBackColor = true;
            this.btn_AddNewProduct.Click += new System.EventHandler(this.btn_AddNewProduct_Click);
            // 
            // btn_DeleteProductFromCart
            // 
            this.btn_DeleteProductFromCart.Location = new System.Drawing.Point(226, 327);
            this.btn_DeleteProductFromCart.Name = "btn_DeleteProductFromCart";
            this.btn_DeleteProductFromCart.Size = new System.Drawing.Size(161, 23);
            this.btn_DeleteProductFromCart.TabIndex = 7;
            this.btn_DeleteProductFromCart.Text = "Избриши од кошничка";
            this.btn_DeleteProductFromCart.UseVisualStyleBackColor = true;
            this.btn_DeleteProductFromCart.Click += new System.EventHandler(this.btn_DeleteProductFromCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Детали за продуктот";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Категорија";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Име";
            // 
            // txt_ShowName
            // 
            this.txt_ShowName.Location = new System.Drawing.Point(239, 65);
            this.txt_ShowName.Name = "txt_ShowName";
            this.txt_ShowName.ReadOnly = true;
            this.txt_ShowName.Size = new System.Drawing.Size(117, 20);
            this.txt_ShowName.TabIndex = 12;
            this.txt_ShowName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_ShowCategory
            // 
            this.txt_ShowCategory.Location = new System.Drawing.Point(239, 104);
            this.txt_ShowCategory.Name = "txt_ShowCategory";
            this.txt_ShowCategory.ReadOnly = true;
            this.txt_ShowCategory.Size = new System.Drawing.Size(117, 20);
            this.txt_ShowCategory.TabIndex = 13;
            // 
            // txt_ShowPrice
            // 
            this.txt_ShowPrice.Location = new System.Drawing.Point(239, 143);
            this.txt_ShowPrice.Name = "txt_ShowPrice";
            this.txt_ShowPrice.ReadOnly = true;
            this.txt_ShowPrice.Size = new System.Drawing.Size(117, 20);
            this.txt_ShowPrice.TabIndex = 14;
            this.txt_ShowPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.Location = new System.Drawing.Point(444, 457);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.ReadOnly = true;
            this.txt_TotalPrice.Size = new System.Drawing.Size(157, 20);
            this.txt_TotalPrice.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Вкупно:";
            // 
            // btn_ClearList0fProducts
            // 
            this.btn_ClearList0fProducts.Location = new System.Drawing.Point(15, 523);
            this.btn_ClearList0fProducts.Name = "btn_ClearList0fProducts";
            this.btn_ClearList0fProducts.Size = new System.Drawing.Size(208, 23);
            this.btn_ClearList0fProducts.TabIndex = 17;
            this.btn_ClearList0fProducts.Text = "Испразни ја листата со продукти ?";
            this.btn_ClearList0fProducts.UseVisualStyleBackColor = true;
            this.btn_ClearList0fProducts.Click += new System.EventHandler(this.btn_ClearList0fProducts_Click);
            // 
            // btn_ClearCart
            // 
            this.btn_ClearCart.Location = new System.Drawing.Point(393, 523);
            this.btn_ClearCart.Name = "btn_ClearCart";
            this.btn_ClearCart.Size = new System.Drawing.Size(208, 23);
            this.btn_ClearCart.TabIndex = 18;
            this.btn_ClearCart.Text = "Испразни ја кошничката ?";
            this.btn_ClearCart.UseVisualStyleBackColor = true;
            this.btn_ClearCart.Click += new System.EventHandler(this.btn_ClearCart_Click);
            // 
            // num0fProducts
            // 
            this.num0fProducts.Location = new System.Drawing.Point(245, 230);
            this.num0fProducts.Name = "num0fProducts";
            this.num0fProducts.Size = new System.Drawing.Size(120, 20);
            this.num0fProducts.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Количина на продуктот:";
            // 
            // ShoppingCartSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 558);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num0fProducts);
            this.Controls.Add(this.btn_ClearCart);
            this.Controls.Add(this.btn_ClearList0fProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TotalPrice);
            this.Controls.Add(this.txt_ShowPrice);
            this.Controls.Add(this.txt_ShowCategory);
            this.Controls.Add(this.txt_ShowName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteProductFromCart);
            this.Controls.Add(this.btn_AddNewProduct);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.lb_Cart);
            this.Controls.Add(this.lb_List0fProducts);
            this.Controls.Add(this.listBox_ProductsAdded);
            this.Controls.Add(this.listBox_ProductsToBeAdded);
            this.Name = "ShoppingCartSystem";
            this.Text = "Потрошувачка кошничка";
            this.Load += new System.EventHandler(this.ShoppingCartSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num0fProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_ProductsToBeAdded;
        private System.Windows.Forms.ListBox listBox_ProductsAdded;
        private System.Windows.Forms.Label lb_List0fProducts;
        private System.Windows.Forms.Label lb_Cart;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_AddNewProduct;
        private System.Windows.Forms.Button btn_DeleteProductFromCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ShowName;
        private System.Windows.Forms.TextBox txt_ShowCategory;
        private System.Windows.Forms.TextBox txt_ShowPrice;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ClearList0fProducts;
        private System.Windows.Forms.Button btn_ClearCart;
        private System.Windows.Forms.NumericUpDown num0fProducts;
        private System.Windows.Forms.Label label6;
    }
}

