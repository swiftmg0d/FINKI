using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class Form1 : Form
    {
        public List<Driver> List0fDrivers { get; set; }
        public int Minutes { get; set; }
        public Form1()
        {
            InitializeComponent();
            List0fDrivers = new List<Driver>();
            Minutes = 0;
        }

        private void btn_AddDriver_Click(object sender, EventArgs e)
        {
            AddDriver addDriver = new AddDriver();
            if (addDriver.ShowDialog() == DialogResult.OK)
            {
                List0fDrivers.Add(addDriver.CreatedDriver);
                listBox_Drivers.Items.Add(addDriver.CreatedDriver);
            }
        }

        private void btn_DeleteDriver_Click(object sender, EventArgs e)
        {
            if (listBox_Drivers.SelectedItem != null)
            {
                DialogResult result=MessageBox.Show("Дали сте сигурни?", "Бришење на даден возач", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    List0fDrivers.Remove(listBox_Drivers.SelectedItem as Driver);
                    listBox_Drivers.Items.Remove(listBox_Drivers.SelectedItem as Driver);
                }
                else
                {

                }
                
            }
        }

        private void btn_AddLap_Click(object sender, EventArgs e)
        {
            int min = int.MaxValue;
            Lap minLap = null;
            txt_BestLap.Text = "";
            if (listBox_Drivers.SelectedItem != null)
            {
                List0fDrivers[List0fDrivers.IndexOf(listBox_Drivers.SelectedItem as Driver)].List0fLaps.Add(new Lap((int)num_Minutes.Value, (int)num_Seconds.Value));
                Lap p = new Lap((int)num_Minutes.Value, (int)num_Seconds.Value);
                if (p.GetFullTime() > (int)num_Time.Value)
                {
                    listBox_Laps.Items.Add(p);
                }

            }
            if (listBox_Drivers.SelectedItem != null)
            {
                List0fDrivers[List0fDrivers.IndexOf(listBox_Drivers.SelectedItem as Driver)].List0fLaps.ForEach(i =>
                {
                    if (i.GetFullTime() < min)
                    {
                        min = i.GetFullTime();
                        minLap = i;
                    }

                });
            }
            if (minLap != null)
            {
                txt_BestLap.Text = minLap.ToString();
            }
        }

        private void listBox_Drivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Laps.Items.Clear();
            int min = int.MaxValue;
            Lap minLap = null;
            txt_BestLap.Text = "";
            if (listBox_Drivers.SelectedItem != null)
            {
                List0fDrivers[List0fDrivers.IndexOf(listBox_Drivers.SelectedItem as Driver)].List0fLaps.ForEach(i =>
                {
                    if (i.GetFullTime() < min)
                    {
                        min = i.GetFullTime();
                        minLap = i;
                    }
                    listBox_Laps.Items.Add(i);
                });
            }
            if (minLap != null)
            {
                txt_BestLap.Text = minLap.ToString();
            }

        }

        

        private void num_Time_ValueChanged(object sender, EventArgs e)
        {
            listBox_Laps.Items.Clear();
            if (listBox_Drivers.SelectedItem != null)
            {
                List0fDrivers[List0fDrivers.IndexOf(listBox_Drivers.SelectedItem as Driver)].List0fLaps.ForEach(i =>
                {

                    if (i.GetFullTime() > (int)num_Time.Value)
                    {
                        listBox_Laps.Items.Add(i);
                    }
                });
            }
        }

        private void num_Seconds_ValueChanged(object sender, EventArgs e)
        {
            if((int)num_Seconds.Value > 59) {
                num_Minutes.Value += 1;
                num_Seconds.Value = 0;
            }
            


        }

        private void num_Minutes_ValueChanged(object sender, EventArgs e)
        {
            if((int)num_Seconds.Value==0 && (int)num_Minutes.Value >= 0)
            {
                if (Minutes + 1 == (int)num_Minutes.Value)
                {
                    Minutes += 1;
                }
                else if(Minutes-1==(int)num_Minutes.Value)
                {
                    Minutes -= 1;
                    num_Seconds.Value = 59;
                }
            }
            else
            {
                Minutes = (int)num_Minutes.Value;
            }
        }
    }
}
