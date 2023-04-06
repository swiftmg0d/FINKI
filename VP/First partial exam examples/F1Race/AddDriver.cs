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
    public partial class AddDriver : Form
    {
        public ErrorProvider errorProvider { get; set; }
        public Driver CreatedDriver { get; set; }
        public AddDriver()
        {
            InitializeComponent();
            errorProvider=new ErrorProvider();
        }
        private bool ValidateName()
        {
            bool valid = true;
            if (txt_Name.Text == "")
            {
                valid=false;
                errorProvider.SetError(txt_Name, "Полето не смее да е празно!");
            }
            else
            {
                errorProvider.SetError(txt_Name, "");

            }
            return valid;
        }
        private void txt_Name_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }

        private void btn_CancelDriver_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel; 
            this.Close();
        }

        private void btn_AddDriver_Click(object sender, EventArgs e)
        {
            if (ValidateName())
            {
                if (cBox_isFirst.Checked == true)
                {
                    CreatedDriver = new Driver(txt_Name.Text, (int)num_Age.Value,true);
                }
                else
                {
                    CreatedDriver = new Driver(txt_Name.Text, (int)num_Age.Value, false);

                }
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {

        }
    }
}
