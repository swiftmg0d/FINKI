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
    public partial class AddProduct : Form
    {
        public Product CreatedProduct { get; set; }
        public String returnType { get ; set; } 
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Length > 0 && txt_Category.Text.Length>0 && txt_Price.Text.Length>0) {
                CreatedProduct = new Product(txt_Name.Text, txt_Category.Text, double.Parse(txt_Price.Text));
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
