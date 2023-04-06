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
    public partial class AddDestination : Form
    {
        public ErrorProvider errorProvider { get; set; }
        public Destination CreatedDestination { get; set; }
        public AddDestination()
        {
            InitializeComponent();
            errorProvider=new ErrorProvider();
        }
        private bool ValidateName()
        {
            bool valid = true;
            if (txt_Name.Text == "")
            {
                errorProvider.SetError(txt_Name, "Полето не смее да биде празно!");
                valid=false;
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

        private void btn_CancelDestination_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void btn_AddDestination_Click(object sender, EventArgs e)
        {
            if(ValidateName())
            {
                this.DialogResult = DialogResult.OK;
                CreatedDestination=new Destination(txt_Name.Text,(int)num_Length.Value,(int)num_Price.Value);
                this.Close();
            }
            
          
        }
    }
}
