namespace Ordering_a_pizza
{
    public partial class Ordering_a_pizza : Form
    {
        int totalPrice = 0;
        int prevPrice_listBox = 0;
        int[] prevPrice_Drinks = new int[3];
        int[] prevPrice_Ingridients = new int[3];
        List<String> pizzaList = new List<string>();
        List<String> ingridientsList=new List<string>();
        List<String> drinksList = new List<String>();
        List<String> desertList=new List<string>();

        public Ordering_a_pizza()
        {
            InitializeComponent();
        }
        private void loadPrices()
        {
            smallSize_price.Text = "200";
            mediumSize_price.Text = "300";
            largeSize_price.Text = "500";
            pappers_price.Text = "40";
            extraCheese_price.Text = "30";
            ketchap_price.Text = "20";
            sodaPrice.Text = "60";
            sodaQuantity.Text = "0";
            juicePrice.Text = "70";
            juiceQuantity.Text = "0";
            beerPrice.Text = "80";
            beerQuantity.Text = "0";
            paid.Text = "0";
            toReturn.Text = "0";
        }
        private void updatePrice()
        {
            totalPayment.Text = totalPrice.ToString();
        }
        private void Ordering_a_pizza_Load(object sender, EventArgs e)
        {
            loadPrices();
            for (int i = 0; i < prevPrice_Drinks.Length; i++)
            {
                prevPrice_Drinks[i] = 0;
            }
        }

        private void listBox_dessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_dessert.SelectedIndex == 0) { desertPrice.Text = "80"; totalPrice -= prevPrice_listBox; prevPrice_listBox = 80; totalPrice += 80; updatePrice(); }
            else if (listBox_dessert.SelectedIndex == 1) { desertPrice.Text = "120"; totalPrice -= prevPrice_listBox; prevPrice_listBox = 120; totalPrice += 120; updatePrice(); }
            else if (listBox_dessert.SelectedIndex == 2) { desertPrice.Text = "160"; totalPrice -= prevPrice_listBox; prevPrice_listBox = 160; totalPrice += 160; updatePrice(); }
        }

        private void sodaQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalSoda.Text = (int.Parse(sodaQuantity.Text) * int.Parse(sodaPrice.Text)).ToString();

            }
            catch (Exception ex) { }
        }

        private void juiceQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalJuice.Text = (int.Parse(juicePrice.Text) * int.Parse(juiceQuantity.Text)).ToString();

            }
            catch (Exception ex) { }
        }

        private void beerQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalBeer.Text = (int.Parse(beerQuantity.Text) * int.Parse(beerPrice.Text)).ToString();

            }
            catch (Exception ex) { }
        }

        private void rd_btn_smallSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_btn_smallSize.Checked == true)
            {
                totalPrice += int.Parse(smallSize_price.Text);
                updatePrice();
                pizzaList.Add("Мала пица");
            }
            else
            {
                totalPrice -= int.Parse(smallSize_price.Text);
                pizzaList.Remove("Мала пица");
                updatePrice();
            }
        }

        private void rd_btn_mediumSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_btn_mediumSize.Checked == true)
            {
                totalPrice += int.Parse(mediumSize_price.Text);
                pizzaList.Add("Средна пица");
                updatePrice();
            }
            else
            {
                totalPrice -= int.Parse(mediumSize_price.Text);
                pizzaList.Remove("Средна пица");
                updatePrice();
            }
        }

        private void rd_btn_largeSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_btn_largeSize.Checked == true)
            {
                totalPrice += int.Parse(largeSize_price.Text);
                updatePrice();
                pizzaList.Add("Голема пица");
            }
            else
            {
                totalPrice -= int.Parse(largeSize_price.Text);
                updatePrice();
                pizzaList.Remove("Голема пица");
            }

        }
        private void totalSoda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalPrice -= prevPrice_Drinks[0];
                totalPrice += int.Parse(totalSoda.Text);
                prevPrice_Drinks[0] = int.Parse(totalSoda.Text);
                updatePrice();
            }
            catch
            {

            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Дали сакаш да ја откажиш порачката?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }


        }

        private void totalJuice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalPrice -= prevPrice_Drinks[1];
                totalPrice += int.Parse(totalJuice.Text);
                prevPrice_Drinks[1] = int.Parse(totalJuice.Text);
                updatePrice();
            }
            catch
            {

            }
        }

        private void totalBeer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalPrice -= prevPrice_Drinks[2];
                totalPrice += int.Parse(totalBeer.Text);
                prevPrice_Drinks[2] = int.Parse(totalBeer.Text);
                updatePrice();
            }
            catch
            {

            }
        }

        private void paid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toReturn.Text = (int.Parse(paid.Text) - int.Parse(totalPayment.Text)).ToString();
            }
            catch
            {

            }
        }



        private void totalPayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toReturn.Text = (int.Parse(paid.Text) - int.Parse(totalPayment.Text)).ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = " ";
            pizzaList.ForEach(x =>
            {
                s += x + "\n";
            });
            if(ingridientsList.Count > 0) {
                s += "Додатоци: \n";
                ingridientsList.ForEach(x => s += x + "\n");
            }
            MessageBox.Show(s);
        }

        private void ch_btn_peppers_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_btn_peppers.Checked)
            {
                totalPrice += int.Parse(pappers_price.Text);
                ingridientsList.Add("Феферонки");
            }
            else
            {
                totalPrice -= int.Parse(pappers_price.Text);
                ingridientsList.Remove("Феферонки");
            }
            updatePrice();
        }

        private void ch_btn_extraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_btn_extraCheese.Checked)
            {
                totalPrice += int.Parse(extraCheese_price.Text);
                ingridientsList.Add("Екстра сирење");
            }
            else
            {
                totalPrice -= int.Parse(extraCheese_price.Text);
                ingridientsList.Remove("Екстра сирење");
            }
            updatePrice();
        }

        private void ch_btn_ketchap_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_btn_ketchap.Checked)
            {
                totalPrice += int.Parse(ketchap_price.Text);
                ingridientsList.Add("Кечап");
            }
            else
            {
                totalPrice -= int.Parse(ketchap_price.Text);
                ingridientsList.Remove("Кечап");
            }
            updatePrice();
        }
    }
}