using System;
using System.Linq;
using System.Windows.Forms;

namespace DelosSantos_MyFirstApp
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {


            if (this.ValidateAllTextBox() && this.ValidateAllComboBox())
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show("Successfully Registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please agree to the conditions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Fill complete all missing fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool ValidateAllTextBox()
        {
            if (Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text))) return false;
            else return true;
        }
        bool ValidateAllComboBox()
        {
            if (Controls.OfType<ComboBox>().Any(x => string.IsNullOrWhiteSpace(x.Text))) return false;
            else return true;
        }

    }
}
