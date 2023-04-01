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
            this.SuspendLayout();
            // 
            // listBox_ProductsToBeAdded
            // 
            this.listBox_ProductsToBeAdded.FormattingEnabled = true;
            this.listBox_ProductsToBeAdded.Items.AddRange(new object[] {
            "Месо",
            "Хамбургер",
            "Јаболки"});
            this.listBox_ProductsToBeAdded.Location = new System.Drawing.Point(12, 27);
            this.listBox_ProductsToBeAdded.Name = "listBox_ProductsToBeAdded";
            this.listBox_ProductsToBeAdded.Size = new System.Drawing.Size(208, 420);
            this.listBox_ProductsToBeAdded.TabIndex = 0;
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
            this.btn_AddToCart.Location = new System.Drawing.Point(226, 245);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(161, 23);
            this.btn_AddToCart.TabIndex = 4;
            this.btn_AddToCart.Text = "Додади во кошничка >>";
            this.btn_AddToCart.UseVisualStyleBackColor = true;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(226, 274);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(161, 23);
            this.btn_DeleteProduct.TabIndex = 5;
            this.btn_DeleteProduct.Text = "Избриши продукт";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // ShoppingCartSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 558);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.lb_Cart);
            this.Controls.Add(this.lb_List0fProducts);
            this.Controls.Add(this.listBox_ProductsAdded);
            this.Controls.Add(this.listBox_ProductsToBeAdded);
            this.Name = "ShoppingCartSystem";
            this.Text = "Потрошувачка кошничка";
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
    }
}

