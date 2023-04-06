using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class Form1 : Form
    {
        public List<Airport> List0fAirports { get; set; }
        public Form1()
        {
            InitializeComponent();
            List0fAirports=new List<Airport>();
        }

        private void btn_AddAirpot_Click(object sender, EventArgs e)
        {
            AddAirport airport=new AddAirport(); 
            
            if(airport.ShowDialog()==DialogResult.OK) {
                List0fAirports.Add(airport.CreatedAirport);
                listBox_Airports.Items.Add(airport.CreatedAirport);
            }
        }

        private void btn_DeleteAirport_Click(object sender, EventArgs e)
        {
            if (listBox_Airports.SelectedItem != null)
            {
                List0fAirports.Remove(listBox_Airports.SelectedItem as Airport);
                listBox_Airports.Items.Remove(listBox_Airports.SelectedItem);
            }
        }

        private void btn_AddDestination_Click(object sender, EventArgs e)
        {
          AddDestination addDestination=new AddDestination();
            if(addDestination.ShowDialog()==DialogResult.OK)
            {
                if(listBox_Airports.SelectedItem!=null)
                {
                    int index=List0fAirports.IndexOf(listBox_Airports.SelectedItem as Airport);
                    List0fAirports[index].Destinations.Add(addDestination.CreatedDestination as Destination);
                   
                }
               
            }
        }

        private void listBox_Airports_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Destinations.Items.Clear();
            if (listBox_Airports.SelectedItem != null)
            {
                List0fAirports[List0fAirports.IndexOf(listBox_Airports.SelectedItem as Airport)].Destinations.ForEach(i =>
                {
                    listBox_Destinations.Items.Add(i);
                });
                Airport a = listBox_Airports.SelectedItem as Airport;
              
                if (a.Destinations.Count == 0)
                {
                    txt_Max.Text = "0";
                    txt_Avg.Text = "0";
                }
                else
                {
                    int max = int.MinValue;
                    double avg = 0;
                    a.Destinations.ForEach(i =>
                    {
                        avg += i.Length;
                        if (i.Price > max)
                        {
                            max = i.Price;
                        }
                    });
                    txt_Max.Text = max.ToString();
                    txt_Avg.Text = (avg / a.Destinations.Count).ToString();
                }
                

            }

        }
    }
}
