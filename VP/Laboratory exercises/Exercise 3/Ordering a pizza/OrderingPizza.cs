using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering_a_pizza
{
    public partial class OrderingPizza : Form
    {
        public ErrorProvider errorProvider { get; set; }
        public int TotalPrice { get; set; }
        public int PrevPricePizzaSize { get; set; }
        public int PrevPriceDrinks { get; set; }
        public int PrevPriceDrinks1 { get; set; }
        public int PrevPriceDrinks2 { get; set; }
        public  Pizza OrderPizza { get; set; }
        public Drinks Drinks { get; set; }
        public List<Dessert> List0fDesserts { get; set; }
        public List<Dessert> List0fOrderDesserts { get; set; }
        public OrderingPizza()
        {
            InitializeComponent();
        }
        private void UpdatePrice()
        {
            txt_TotalPrice.Text = TotalPrice.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider=new ErrorProvider();
            TotalPrice = 0;
            PrevPricePizzaSize = 0;
            PrevPriceDrinks = 0;
            PrevPriceDrinks1 = 0;
            PrevPriceDrinks2 = 0;


            OrderPizza = new Pizza();
            OrderPizza.PizzaSize = new Sizes();
            OrderPizza.PizzaAccessories = new Аccessories();
            Drinks = new Drinks();

            txt_SmallPrice.Text =OrderPizza.PizzaSize.SmallPrice.ToString();
            txt_MediumPrice.Text = OrderPizza.PizzaSize.MediumPrice.ToString();
            txt_LargePrice.Text=OrderPizza.PizzaSize.LargePrice.ToString();

            txt_ExtraCheesePrice.Text = OrderPizza.PizzaAccessories.ExtraCheesePrice.ToString();
            txt_HotPappersPrice.Text = OrderPizza.PizzaAccessories.HotPappersPrice.ToString();
            txt_KetchapPrice.Text = OrderPizza.PizzaAccessories.KetchapPrice.ToString();

            txt_SodaPrice.Text = Drinks.SodaPrice.ToString();
            txt_SodaQuantity.Text = "0";
            
            txt_JuicePrice.Text=Drinks.JuicePrice.ToString();
            txt_JuiceQuantity.Text = "0";

            txt_BeerPrice.Text = Drinks.BeerPrice.ToString();
            txt_BeerQuantity.Text = "0";

            txt_TotalPrice.Text=TotalPrice.ToString();

            List0fDesserts = new List<Dessert>();
            List0fDesserts.Add(new Dessert("Овошна пита", 100));
            List0fDesserts.Add(new Dessert("Сладолед", 40));
            List0fDesserts.Add(new Dessert("Торта", 150));
            List0fDesserts.ForEach(i=>{
                listBox_Desserts.Items.Add(i);
            });
            List0fOrderDesserts = new List<Dessert>();
        }

        private void rBtn_Small_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice -= PrevPricePizzaSize;
            PrevPricePizzaSize = OrderPizza.PizzaSize.SmallPrice;
            TotalPrice += OrderPizza.PizzaSize.SmallPrice;
            UpdatePrice();
        }

        private void rBtn_Medium_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice -= PrevPricePizzaSize;
            PrevPricePizzaSize = OrderPizza.PizzaSize.MediumPrice;
            TotalPrice += OrderPizza.PizzaSize.MediumPrice;
            UpdatePrice(); ;
        }

        private void rBtn_Large_CheckedChanged(object sender, EventArgs e)
        {
            TotalPrice -= PrevPricePizzaSize;
            PrevPricePizzaSize = OrderPizza.PizzaSize.LargePrice;
            TotalPrice += OrderPizza.PizzaSize.LargePrice;
            UpdatePrice();
        }

        private void cBox_HotPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_HotPeppers.Checked==true)
            {
                TotalPrice += OrderPizza.PizzaAccessories.HotPappersPrice;
                UpdatePrice();
            }
            else
            {
                TotalPrice -= OrderPizza.PizzaAccessories.HotPappersPrice;
                UpdatePrice();
            }
        }

        private void cBox_ExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_ExtraCheese.Checked == true)
            {
                TotalPrice += OrderPizza.PizzaAccessories.ExtraCheesePrice;
                UpdatePrice();
            }
            else
            {
                TotalPrice -= OrderPizza.PizzaAccessories.ExtraCheesePrice;
                UpdatePrice();
            }
        }

        private void cBox_Ketchap_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_Ketchap.Checked == true)
            {
                TotalPrice += OrderPizza.PizzaAccessories.KetchapPrice;
                UpdatePrice();
            }
            else
            {
                TotalPrice -= OrderPizza.PizzaAccessories.KetchapPrice;
                UpdatePrice();
            }
        }

        private void txt_SodaQuantity_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_SodaQuantity.Text))
            {

                txt_TotalSodaPrice.Text = "0";
            }
            else
            {
                txt_TotalSodaPrice.Text = (int.Parse(txt_SodaQuantity.Text) * Drinks.SodaPrice).ToString();
                

            }
            
        }

        private void txt_JuiceQuantity_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_JuiceQuantity.Text))
            {
                txt_TotalJuicePrice.Text = "0";

            }
            else
            {
                txt_TotalJuicePrice.Text = (int.Parse(txt_JuiceQuantity.Text) * Drinks.JuicePrice).ToString();
                
            }
            
        }

        private void txt_BeerQuantity_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txt_BeerQuantity.Text))
            {
                txt_TotalBeerPrice.Text = "0";

            }
            else
            {
                txt_TotalBeerPrice.Text = (int.Parse(txt_BeerQuantity.Text) * Drinks.BeerPrice).ToString();
                
            }
          
            
        }

        private void txt_TotalSodaPrice_TextChanged(object sender, EventArgs e)
        {
            TotalPrice -= PrevPriceDrinks;
            if (txt_TotalSodaPrice.Text.Length > 0)
            {
                PrevPriceDrinks = int.Parse(txt_TotalSodaPrice.Text);
                TotalPrice+= int.Parse(txt_TotalSodaPrice.Text);
                UpdatePrice();
            }
        }

        private void txt_TotalJuicePrice_TextChanged(object sender, EventArgs e)
        {
            TotalPrice -= PrevPriceDrinks1;
            if (txt_TotalJuicePrice.Text.Length > 0)
            {
                PrevPriceDrinks1 = int.Parse(txt_TotalJuicePrice.Text);
                TotalPrice += int.Parse(txt_TotalJuicePrice.Text);
                UpdatePrice();
            }
        }

        private void txt_TotalBeerPrice_TextChanged(object sender, EventArgs e)
        {
            TotalPrice -= PrevPriceDrinks2;
            if (txt_TotalBeerPrice.Text.Length > 0)
            {
                PrevPriceDrinks2 = int.Parse(txt_TotalBeerPrice.Text);
                TotalPrice += int.Parse(txt_TotalBeerPrice.Text);
                UpdatePrice();
            }
        }

        private void listBox_Desserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Desserts.SelectedItem != null)
            {
                Dessert SelectedDessert = (Dessert)listBox_Desserts.SelectedItem;
                txt_PriceDessert.Text = SelectedDessert.Price.ToString();
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            if (listBox_Desserts.SelectedItem != null)
            {
                Dessert SelectedDessert = (Dessert)listBox_Desserts.SelectedItem;
                List0fOrderDesserts.Add(SelectedDessert);
                TotalPrice += SelectedDessert.Price;
                UpdatePrice();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (listBox_Desserts.SelectedItem != null)
            {
                Dessert SelectedDessert = (Dessert)listBox_Desserts.SelectedItem;
                if (List0fOrderDesserts.Contains(SelectedDessert))
                {
                    TotalPrice-=SelectedDessert.Price;
                    UpdatePrice();
                    List0fOrderDesserts.Remove(SelectedDessert);
                }
                
            }
        }

        private void txt_Paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_Paid.Text.Length > 0)
            {
                txt_ToReturn.Text = (int.Parse(txt_Paid.Text) - TotalPrice).ToString();
            }
        }
    }
    }

