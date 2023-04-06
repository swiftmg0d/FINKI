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
    public partial class AddAirport : Form
    {
        public Airport CreatedAirport { get; set; }
        public ErrorProvider errorProvider { get; set; }
        public AddAirport()
        {
            InitializeComponent();
            errorProvider= new ErrorProvider();
        }

        private void AddAirport_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateCity()
        {
            bool bStatus = true;
            if (txt_City.Text == "")
            {
                errorProvider.SetError(txt_City, "Внесете правилни информации");
                bStatus = false;
            }
            else
            {
                errorProvider.SetError(txt_City, "");

            }
            return bStatus;
        }
       
        private void txt_City_Validating(object sender, CancelEventArgs e)
        {
            ValidateCity();
        }
        private bool ValidateName()
        {
            bool bStatus = true;
            if (txt_Name.Text == "")
            {
                errorProvider.SetError(txt_Name, "Внесете правилни информации");
                bStatus = false;
            }
            else
            {
                errorProvider.SetError(txt_Name, "");

            }
            return bStatus;
        }
        private void txt_Name_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }
        private bool ValidateCodeLength()
        {
            bool lStatus = true;
        

            if (txt_Code.Text.Length != 3)
            {
                lStatus = false;
                errorProvider.SetError(txt_Code, "Должината на кодот мора да е еднаква на 3");
            }
            else
            {
                errorProvider.SetError(txt_Code, "");

            }
            bool bStatus = false;

            foreach (char c in txt_Code.Text)
            {
                if (char.IsUpper(c) && char.IsLetter(c))
                {
                    errorProvider.SetError(txt_Code, "");
                    bStatus = true;
                    if (txt_Code.Text.Length != 3)
                    {
                        lStatus = false;
                        errorProvider.SetError(txt_Code, "Должината на кодот мора да е еднаква на 3");
                    }
                    else
                    {
                        errorProvider.SetError(txt_Code, "");

                    }
                }
                else
                {
                    errorProvider.SetError(txt_Code, "Кодот мора да е составен од големи букви");
                   
                }
            }



            return lStatus && bStatus;
        }
       
        private void txt_Code_Validating(object sender, CancelEventArgs e)
        {
            ValidateCodeLength();
            
        }

        private void btn_SaveAirpot_Click(object sender, EventArgs e)
        {
            if(ValidateName() && ValidateCity() && ValidateCodeLength())
            {
                this.DialogResult= DialogResult.OK;
                CreatedAirport = new Airport(txt_City.Text, txt_Name.Text, txt_Code.Text);
                this.Close();
            }
        }

        private void btn_CancelAirport_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
