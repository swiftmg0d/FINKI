using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busses
{
    public partial class Busses : Form
    {
        public List<Bus> busList;
        public Busses()
        {
            busList=new List<Bus>();
            InitializeComponent();
            busList.Add(new Bus("Strumica Express", "3421", true));
            busList.Add(new Bus("Ohrid Express", "1234", true));
            busList.ForEach(b =>
            {
                b.List0fRoutes.Add(new Route("Skopje",2,40,50));
                listBox_Busses.Items.Add(b);
            });
           
        }

        private void btn_AddBus_Click(object sender, EventArgs e)
        {
            AddBus addBus = new AddBus();
            if (addBus.ShowDialog() == DialogResult.OK)
            {
                busList.Add(addBus.CreatedBus);
                listBox_Busses.Items.Add(addBus.CreatedBus);
            }
        }

        private void btn_AddRoute_Click(object sender, EventArgs e)
        {
            AddRoute addRoute = new AddRoute();
            if(addRoute.ShowDialog() == DialogResult.OK)
            {
                Bus bus = listBox_Busses.SelectedItem as Bus;
                if (bus != null)
                {
                    bus.List0fRoutes.Add(addRoute.CreatedRoute);
                    listBox_Routes.Items.Add(addRoute.CreatedRoute);
                    int max = int.MinValue;
                    Route maxRoute = null;
                    double avg = 0;
                    foreach (Route r in bus.List0fRoutes)
                    {
                        avg += r.Price;
                        if (r.Price > max)
                        {
                            maxRoute = r;
                            max = r.Price;

                        }
                    }
                    txt_AvgPriceRoutes.Text = (avg / bus.List0fRoutes.Count).ToString();
                    txt_MostExpensive.Text = maxRoute.ToString();
                }
            }
        }

        private void btn_DeleteBus_Click(object sender, EventArgs e)
        {
            Bus bus = listBox_Busses.SelectedItem as Bus;
            DialogResult result = MessageBox.Show("Дали сте сигурни?", "Бришење на автобус", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (bus != null)
                {
                    listBox_Busses.Items.Remove(bus);
                    busList.Remove(bus);
                    txt_AvgPriceRoutes.Text = "";
                    txt_MostExpensive.Text = "";
                }
            }
            
        }

        private void listBox_Busses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Routes.Items.Clear();
            Bus bus= listBox_Busses.SelectedItem as Bus;
            if (bus != null)
            {
                bus.List0fRoutes.ForEach(i=>{
                    listBox_Routes.Items.Add(i);
                });
                if (bus.List0fRoutes.Count == 0)
                {
                    txt_AvgPriceRoutes.Text = "";
                    txt_MostExpensive.Text = "";
                }
                else
                {
                    int max = int.MinValue;
                    Route maxRoute = null;
                    double avg = 0;
                    foreach (Route r in bus.List0fRoutes)
                    {
                        avg += r.Price;
                        if (r.Price > max)
                        {
                            maxRoute = r;
                            max = r.Price;

                        }
                    }
                    txt_AvgPriceRoutes.Text = (avg / bus.List0fRoutes.Count).ToString();
                    txt_MostExpensive.Text = maxRoute.ToString();
                }
                
            }
            
        }
    }
}
