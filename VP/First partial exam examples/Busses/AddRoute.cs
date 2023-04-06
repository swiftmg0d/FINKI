using System;
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
    public partial class AddRoute : Form
    {
        public Route CreatedRoute { get; set; }
        public AddRoute()
        {
            InitializeComponent();
        }
        public bool ValidateDestination()
        {
            ErrorProvider errorProvider = new ErrorProvider();  
            bool valid = true;
            if (txt_Destination.Text == "")
            {
                errorProvider.SetError(txt_Destination, "Внесете валидна дестинација!");
                valid = false;
            }
            else
            {
                errorProvider.SetError(txt_Destination, "");
            }
            return valid;
        }
        private void txt_Destination_Validating(object sender, CancelEventArgs e)
        {
            ValidateDestination();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ValidateDestination())
            {
                CreatedRoute=new Route(txt_Destination.Text,(int)num_Hours.Value,(int)num_Minutes.Value,(int)num_Price.Value);
                this.DialogResult=DialogResult.OK;
            }
        }
    }
}
