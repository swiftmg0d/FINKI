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
        public ShoppingCartSystem()
        {
            InitializeComponent();
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            if(listBox_ProductsToBeAdded.SelectedItem != null)
            {
                listBox_ProductsAdded.Items.Add(listBox_ProductsToBeAdded.SelectedItem);
                listBox_ProductsToBeAdded.Items.Remove(listBox_ProductsToBeAdded.SelectedItem);
            }

            
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (listBox_ProductsToBeAdded.SelectedItem != null)
            { 
  
                listBox_ProductsToBeAdded.Items.Remove(listBox_ProductsToBeAdded.SelectedItem);
            }
        }
    }
}
