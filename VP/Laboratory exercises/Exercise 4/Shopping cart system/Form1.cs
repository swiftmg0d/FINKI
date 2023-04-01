using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_cart_system
{
    public partial class ShoppingCartSystem : Form
    {
        public double totalPrice { get; set; }
        public List<Product> List0fProducts { get; set; }
        public List<Product> List0fAddedProducts { get; set; }  
        public ShoppingCartSystem()
        {
            InitializeComponent();
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            
            Product product = listBox_ProductsToBeAdded.SelectedItem as Product;
            if (product != null)
            {
                double nTimes = (double)num0fProducts.Value;
                listBox_ProductsAdded.Items.Add(product.tString(nTimes));
                listBox_ProductsToBeAdded.Items.Remove(product);
                
                totalPrice += product.Price* nTimes;
                txt_TotalPrice.Text = totalPrice.ToString();
                product.Price= product.Price * nTimes;
                List0fAddedProducts.Add(product);
                clearInfo();
                num0fProducts.Value = 0;
            }
                
                
                
            

            
        }
        private void clearInfo()
        {
            txt_ShowCategory.Text = "";
            txt_ShowName.Text = "";
            txt_ShowPrice.Text = "";
        }
        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (listBox_ProductsToBeAdded.SelectedItem != null)
            { 
  
                listBox_ProductsToBeAdded.Items.Remove(listBox_ProductsToBeAdded.SelectedItem);
                clearInfo();
            }
        }

        private void btn_DeleteProductFromCart_Click(object sender, EventArgs e)
        {
            if (listBox_ProductsAdded.SelectedItem != null)
            {
               
             
                listBox_ProductsAdded.Items.Remove(listBox_ProductsAdded.SelectedItem);
                Product p = (Product)listBox_ProductsAdded.SelectedItem;
                txt_ShowPrice.Text=(totalPrice-=p.Price).ToString();
                
                
                
                
            }
        }

        private void btn_AddNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct newWindow = new AddProduct();
            DialogResult result = newWindow.ShowDialog();
            if (result== DialogResult.OK)
            {
                if (newWindow.CreatedProduct != null)
                {
                    listBox_ProductsToBeAdded.Items.Add(newWindow.CreatedProduct);
                    List0fProducts.Add(newWindow.CreatedProduct);
                   

                }
            }
            
            
        }

        private void ShoppingCartSystem_Load(object sender, EventArgs e)
        {
            List0fProducts=new List<Product>();
            List0fAddedProducts=new List<Product>();
            List0fProducts.Add(new Product("Шампон", "Хигиена", 120.00));
            listBox_ProductsToBeAdded.Items.Add(new Product("Шампон", "Хигиена", 120.00));
            totalPrice = 0;
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_ProductsToBeAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product showProductInfo = listBox_ProductsToBeAdded.SelectedItem as Product;
            if (showProductInfo != null) { 
                txt_ShowCategory.Text = showProductInfo.Category;
                txt_ShowName.Text = showProductInfo.Name;
                txt_ShowPrice.Text = showProductInfo.Price.ToString();
            }
            
        }

       

        private void btn_ClearList0fProducts_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Дали се сигурни?", "Предупредување", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                List0fProducts.Clear();
                listBox_ProductsToBeAdded.Items.Clear();
                clearInfo();
            }
           
            


            
        }

        private void btn_ClearCart_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Дали се сигурни?", "Предупредување", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                List0fAddedProducts.Clear();
                listBox_ProductsAdded.Items.Clear();
                totalPrice = 0;
                txt_TotalPrice.Text = "";
                clearInfo();
            }
          
        }
    }
}
