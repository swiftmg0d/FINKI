namespace Ordering_a_pizza
{
    public partial class Ordering_a_pizza : Form
    {
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
        }
        private void Ordering_a_pizza_Load(object sender, EventArgs e)
        {
            loadPrices();
        }
    }
}