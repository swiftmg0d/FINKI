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
    public partial class AddBus : Form
    {
        public ErrorProvider errorProvider { get; set; }
        public Bus CreatedBus { get; set; }
        public AddBus()
        {
            InitializeComponent();
            errorProvider=new ErrorProvider();
        }

        private void btn_AddBuss_Click(object sender, EventArgs e)
        {
            if (ValidateName() && ValidateRegistration())
            {
                if (cBox_IsLocal.Checked == true)
                {
                    CreatedBus = new Bus(txt_Name.Text, txt_Registration.Text,true);
                }
                else
                {
                    CreatedBus = new Bus(txt_Name.Text, txt_Registration.Text, false);
                }
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btn_CancelBuss_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private bool ValidateName()
        {
            bool valid = true;
            if (txt_Name.Text == "")
            {
                valid = false;
                errorProvider.SetError(txt_Name, "Внесете правило име!");
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
        private bool ValidateRegistration()
        {
            bool valid = true;
            bool isValid = true;
            foreach(char c in txt_Registration.Text)
            {
                if (char.IsNumber(c) == false)
                {
                    isValid = false;
                    break;
                }
            }
            if(txt_Registration.Text.Length==3 && isValid)
            {
                errorProvider.SetError(txt_Registration, "");
            
            }
            else
            {
                errorProvider.SetError(txt_Registration, "Регистрација мора да биде составена од броеви и големината да е 3");
                valid = false;

            }


            return valid;
        }
        private void txt_Registration_Validating(object sender, CancelEventArgs e)
        {
            ValidateRegistration();
        }
    }
}
